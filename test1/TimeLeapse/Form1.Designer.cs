﻿namespace TimeLeapse
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axGVSinglePlayer1 = new AxGVSINGLEPLAYERLib.AxGVSinglePlayer();
            this.setDateTime = new System.Windows.Forms.DateTimePicker();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.startDateTime = new System.Windows.Forms.DateTimePicker();
            this.stopDateTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCamNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.axGVSinglePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axGVSinglePlayer1
            // 
            this.axGVSinglePlayer1.Enabled = true;
            this.axGVSinglePlayer1.Location = new System.Drawing.Point(12, 12);
            this.axGVSinglePlayer1.Name = "axGVSinglePlayer1";
            this.axGVSinglePlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGVSinglePlayer1.OcxState")));
            this.axGVSinglePlayer1.Size = new System.Drawing.Size(1920, 1080);
            this.axGVSinglePlayer1.TabIndex = 0;
            this.axGVSinglePlayer1.LoginOK += new System.EventHandler(this.axGVSinglePlayer1_LoginOK);
            this.axGVSinglePlayer1.SearchEvent += new AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_SearchEventHandler(this.axGVSinglePlayer1_SearchEvent);
            this.axGVSinglePlayer1.Picture += new AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_PictureEventHandler(this.axGVSinglePlayer1_Picture);
            this.axGVSinglePlayer1.LoginEvent += new AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_LoginEventHandler(this.axGVSinglePlayer1_LoginEvent);
            // 
            // setDateTime
            // 
            this.setDateTime.CustomFormat = "yyyy/MM/dd HH:mm";
            this.setDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.setDateTime.Location = new System.Drawing.Point(553, 34);
            this.setDateTime.Name = "setDateTime";
            this.setDateTime.Size = new System.Drawing.Size(142, 22);
            this.setDateTime.TabIndex = 2;
            this.setDateTime.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(553, 214);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 3;
            this.txtIP.Text = "192.168.0.222";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(553, 242);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "5552";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(553, 270);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 5;
            this.txtUser.Text = "cj";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(553, 298);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(100, 22);
            this.txtPwd.TabIndex = 6;
            this.txtPwd.Text = "Admin-123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(529, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(520, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(518, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "User:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(492, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "PassWord:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get Snapshot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "test";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // startDateTime
            // 
            this.startDateTime.CustomFormat = "yyyy/MM/dd";
            this.startDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateTime.Location = new System.Drawing.Point(553, 158);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(100, 22);
            this.startDateTime.TabIndex = 14;
            // 
            // stopDateTime
            // 
            this.stopDateTime.CustomFormat = "yyyy/MM/dd";
            this.stopDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.stopDateTime.Location = new System.Drawing.Point(553, 186);
            this.stopDateTime.Name = "stopDateTime";
            this.stopDateTime.Size = new System.Drawing.Size(100, 22);
            this.stopDateTime.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(496, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(499, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "StopDate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(499, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "VideoDate Time:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(620, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Set Time";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCamNo
            // 
            this.txtCamNo.Location = new System.Drawing.Point(553, 326);
            this.txtCamNo.Name = "txtCamNo";
            this.txtCamNo.Size = new System.Drawing.Size(100, 22);
            this.txtCamNo.TabIndex = 20;
            this.txtCamNo.Text = "1";
            this.txtCamNo.TextChanged += new System.EventHandler(this.txtCamNo_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "cam No. :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 480);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCamNo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stopDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.setDateTime);
            this.Controls.Add(this.axGVSinglePlayer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axGVSinglePlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxGVSINGLEPLAYERLib.AxGVSinglePlayer axGVSinglePlayer1;
        private System.Windows.Forms.DateTimePicker setDateTime;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker startDateTime;
        private System.Windows.Forms.DateTimePicker stopDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCamNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timer1;
    }
}

