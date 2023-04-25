namespace GCMServer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtMStatus = new System.Windows.Forms.TextBox();
            this.btnMOn = new System.Windows.Forms.Button();
            this.btnMOff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDVR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSOff = new System.Windows.Forms.Button();
            this.btnSOn = new System.Windows.Forms.Button();
            this.txtSStatus = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMStatus
            // 
            this.txtMStatus.Location = new System.Drawing.Point(8, 19);
            this.txtMStatus.Name = "txtMStatus";
            this.txtMStatus.ReadOnly = true;
            this.txtMStatus.Size = new System.Drawing.Size(157, 20);
            this.txtMStatus.TabIndex = 0;
            this.txtMStatus.TabStop = false;
            this.txtMStatus.Text = "Detector Status";
            // 
            // btnMOn
            // 
            this.btnMOn.Location = new System.Drawing.Point(8, 46);
            this.btnMOn.Name = "btnMOn";
            this.btnMOn.Size = new System.Drawing.Size(75, 23);
            this.btnMOn.TabIndex = 1;
            this.btnMOn.Text = "On";
            this.btnMOn.UseVisualStyleBackColor = true;
            this.btnMOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnMOff
            // 
            this.btnMOff.Location = new System.Drawing.Point(90, 46);
            this.btnMOff.Name = "btnMOff";
            this.btnMOff.Size = new System.Drawing.Size(75, 23);
            this.btnMOff.TabIndex = 2;
            this.btnMOff.Text = "Off";
            this.btnMOff.UseVisualStyleBackColor = true;
            this.btnMOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(49, 10);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(156, 20);
            this.txtTime.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 13);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(33, 13);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDVR);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.txtBaud);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Location = new System.Drawing.Point(16, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 223);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(72, 124);
            this.txtDevice.Multiline = true;
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(118, 64);
            this.txtDevice.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Device ID:";
            // 
            // txtDVR
            // 
            this.txtDVR.Location = new System.Drawing.Point(72, 72);
            this.txtDVR.Name = "txtDVR";
            this.txtDVR.Size = new System.Drawing.Size(118, 20);
            this.txtDVR.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "DVR Name:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(72, 98);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(118, 20);
            this.txtIP.TabIndex = 11;
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(72, 46);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(118, 20);
            this.txtBaud.TabIndex = 10;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(72, 19);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(118, 20);
            this.txtPort.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud Rate:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Port Name:";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(119, 194);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 5;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMOff);
            this.groupBox2.Controls.Add(this.btnMOn);
            this.groupBox2.Controls.Add(this.txtMStatus);
            this.groupBox2.Location = new System.Drawing.Point(226, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 81);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Motion Sensor Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSOff);
            this.groupBox3.Controls.Add(this.btnSOn);
            this.groupBox3.Controls.Add(this.txtSStatus);
            this.groupBox3.Location = new System.Drawing.Point(226, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(172, 81);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Smoke Detector Controls";
            // 
            // btnSOff
            // 
            this.btnSOff.Location = new System.Drawing.Point(90, 46);
            this.btnSOff.Name = "btnSOff";
            this.btnSOff.Size = new System.Drawing.Size(75, 23);
            this.btnSOff.TabIndex = 2;
            this.btnSOff.Text = "Off";
            this.btnSOff.UseVisualStyleBackColor = true;
            this.btnSOff.Click += new System.EventHandler(this.btnSOff_Click);
            // 
            // btnSOn
            // 
            this.btnSOn.Location = new System.Drawing.Point(8, 46);
            this.btnSOn.Name = "btnSOn";
            this.btnSOn.Size = new System.Drawing.Size(75, 23);
            this.btnSOn.TabIndex = 1;
            this.btnSOn.Text = "On";
            this.btnSOn.UseVisualStyleBackColor = true;
            this.btnSOn.Click += new System.EventHandler(this.btnSOn_Click);
            // 
            // txtSStatus
            // 
            this.txtSStatus.Location = new System.Drawing.Point(8, 19);
            this.txtSStatus.Name = "txtSStatus";
            this.txtSStatus.ReadOnly = true;
            this.txtSStatus.Size = new System.Drawing.Size(157, 20);
            this.txtSStatus.TabIndex = 0;
            this.txtSStatus.TabStop = false;
            this.txtSStatus.Text = "Detector Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GCMServer.Properties.Resources.D_Point_logo;
            this.pictureBox1.Location = new System.Drawing.Point(255, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 271);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DPoint Motion/Smoke Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtMStatus;
        private System.Windows.Forms.Button btnMOn;
        private System.Windows.Forms.Button btnMOff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSOff;
        private System.Windows.Forms.Button btnSOn;
        private System.Windows.Forms.TextBox txtSStatus;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

