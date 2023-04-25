using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace GCMServer
{
    public partial class Main : Form
    {
        String deviceId = "APA91bG9XdrbzUK3bOGRiDyKwWyqVZ-aAf8uDJMzrhTYADsHocqziywpdDZGkpN11BMHFESoVtUSFtlJBLeETTfH1YGC_riZAHoo9Zl4QDg2sjGCZrVtDaFErTKr9zd8lIJePTJ9nh6yah4IpvSEaYEsUR9WFVRpgQsJ-JfVrPdcQkPE5HdK4BU";
        String apiKey = "AIzaSyBzJ86Ku9YhuftnUnVFNwBxVDDo42fvD9Q";
        String response;
        String message = "";
        String contentTitle = "";
        String postData;
        String portName;
        int baudRate;
        String ipAddress = "192.168.1.120";
        String dvrName = "test";
        String messageFromArduino = "";
        int motionStatus = 0;
        int smokeStatus = 0;

        DateTime timeNow = DateTime.Now;
        
        public Main()
        {
            InitializeComponent();

            serialPort1.PortName = "COM9";
            serialPort1.BaudRate = 115200;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMOff.Enabled = false;
            btnMOn.Enabled = false;
            btnSOff.Enabled = false;
            btnSOn.Enabled = false;
            btnSet.Enabled = true;

            txtPort.Text = "COM9";
            txtBaud.Text = Convert.ToString("115200");
            txtIP.Text = ipAddress;
            txtDevice.Text = deviceId;
            txtDVR.Text = dvrName;
        }

        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            messageFromArduino = string.Empty;

            try
            {
                messageFromArduino = serialPort1.ReadExisting();
                if (motionStatus == 1 && smokeStatus == 0 && messageFromArduino == "1") motionDetected();
                else if (smokeStatus == 1 && motionStatus == 0 && messageFromArduino == "2") smokeDetected();
                else if (motionStatus == 0 && smokeStatus == 1 && messageFromArduino == "1") MessageBox.Show("Motion Detection Off!");
                else if (smokeStatus == 0 && motionStatus == 1 && messageFromArduino == "2") MessageBox.Show("Smoke Detection Off!");
                else if (motionStatus == 0 && smokeStatus == 0) MessageBox.Show("Detection Off!");
                else if (smokeStatus == 1 && motionStatus == 1)
                {
                    if (messageFromArduino == "1") motionDetected();
                    else if (messageFromArduino == "2") smokeDetected();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }   
        }

        void motionDetected()
        {
            contentTitle = "Motion Detected";
            message = "at " + dvrName + " (" + ipAddress + "). Tap to open app.";
            MessageBox.Show("Motion Detected!");
            sendMessage();
        }

        void smokeDetected()
        {
            contentTitle = "Smoke Detected";
            message = "at " + dvrName + " (" + ipAddress + "). Tap to open app.";
            MessageBox.Show("Smoke Detected!");
            sendMessage();
        }

        void sendMessage()
        {
            postData = "{ \"registration_ids\": [ \"" + deviceId + "\" ], " +
          "\"data\": {\"ipAddress\":\"" + ipAddress + "\", " +
                     "\"dvrName\":\"" + dvrName + "\", " +
                     "\"contentTitle\":\"" + contentTitle + "\", " +
                     "\"message\": \"" + message + "\"}}";

            response = SendGCMNotification(apiKey, postData);

            if (response == "error") MessageBox.Show(response);
            else MessageBox.Show("Notification Sent to Phone");
        }

        /// <summary>
        /// Send a Google Cloud Message. Uses the GCM service and your provided api key.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="postData"></param>
        /// <param name="postDataContentType"></param>
        /// <returns>The response string from the google servers</returns>
        private string SendGCMNotification(string apiKey, string postData, string postDataContentType = "application/json")
        {
            ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateServerCertificate);

            //
            //  MESSAGE CONTENT
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);

            //
            //  CREATE REQUEST
            HttpWebRequest Request = (HttpWebRequest)WebRequest.Create("https://android.googleapis.com/gcm/send");
            Request.Method = "POST";
            Request.KeepAlive = false;
            Request.ContentType = postDataContentType;
            Request.Headers.Add(string.Format("Authorization: key={0}", apiKey));
            Request.ContentLength = byteArray.Length;

            Stream dataStream = Request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            //
            //  SEND MESSAGE
            try
            {
                WebResponse Response = Request.GetResponse();
                HttpStatusCode ResponseCode = ((HttpWebResponse)Response).StatusCode;
                if (ResponseCode.Equals(HttpStatusCode.Unauthorized) || ResponseCode.Equals(HttpStatusCode.Forbidden))
                {
                    var text = "Unauthorized - need new token";
                }
                else if (!ResponseCode.Equals(HttpStatusCode.OK))
                {
                    var text = "Response from web service isn't OK";
                }

                StreamReader Reader = new StreamReader(Response.GetResponseStream());
                string responseLine = Reader.ReadToEnd();
                Reader.Close();

                return responseLine;
            }
            catch (Exception e)
            {
            }
            return "error";
        }

        public static bool ValidateServerCertificate(
                                                    object sender,
                                                    X509Certificate certificate,
                                                    X509Chain chain,
                                                    SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            btnMOn.Enabled = false;
            btnMOff.Enabled = true;
            txtMStatus.Text = "Monitoring ON";
            motionStatus = 1;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            if (smokeStatus == 0) serialPort1.Close();
            btnMOn.Enabled = true;
            btnMOff.Enabled = false;
            txtMStatus.Text = "Monitoring OFF";
            motionStatus = 0;
        }

        private void btnSOn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen) serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            btnSOn.Enabled = false;
            btnSOff.Enabled = true;
            txtSStatus.Text = "Monitoring ON";
            smokeStatus = 1;
        }

        private void btnSOff_Click(object sender, EventArgs e)
        {
            if (motionStatus == 0) serialPort1.Close();
            btnSOn.Enabled = true;
            btnSOff.Enabled = false;
            txtSStatus.Text = "Monitoring OFF";
            smokeStatus = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            portName = txtPort.Text;
            baudRate = Convert.ToInt32(txtBaud.Text);
            ipAddress = txtIP.Text;
            deviceId = txtDevice.Text;
            dvrName = txtDVR.Text;

            serialPort1.PortName = ""+portName;
            serialPort1.BaudRate = baudRate;

            btnMOn.Enabled = true;
            btnSOn.Enabled = true;

            motionStatus = 0;
            smokeStatus = 0;
        }
    }
}