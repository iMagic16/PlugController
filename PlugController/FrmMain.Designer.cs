namespace PlugController
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.BtnALLOFF = new System.Windows.Forms.Button();
            this.Btn4Off = new System.Windows.Forms.Button();
            this.Btn4On = new System.Windows.Forms.Button();
            this.Btn3Off = new System.Windows.Forms.Button();
            this.Btn3On = new System.Windows.Forms.Button();
            this.Btn2Off = new System.Windows.Forms.Button();
            this.Btn2On = new System.Windows.Forms.Button();
            this.Btn1Off = new System.Windows.Forms.Button();
            this.BtnALLON = new System.Windows.Forms.Button();
            this.Btn1On = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(204, 158);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 20);
            this.webBrowser1.TabIndex = 10;
            // 
            // BtnALLOFF
            // 
            this.BtnALLOFF.BackgroundImage = global::PlugController.Properties.Resources._005_power_off;
            this.BtnALLOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnALLOFF.Location = new System.Drawing.Point(81, 237);
            this.BtnALLOFF.Name = "BtnALLOFF";
            this.BtnALLOFF.Size = new System.Drawing.Size(62, 49);
            this.BtnALLOFF.TabIndex = 18;
            this.BtnALLOFF.Text = "All";
            this.BtnALLOFF.UseVisualStyleBackColor = true;
            this.BtnALLOFF.Click += new System.EventHandler(this.BtnALLOFF_Click);
            // 
            // Btn4Off
            // 
            this.Btn4Off.BackgroundImage = global::PlugController.Properties.Resources._004_computer_off;
            this.Btn4Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn4Off.Location = new System.Drawing.Point(81, 178);
            this.Btn4Off.Name = "Btn4Off";
            this.Btn4Off.Size = new System.Drawing.Size(62, 49);
            this.Btn4Off.TabIndex = 25;
            this.Btn4Off.UseVisualStyleBackColor = true;
            this.Btn4Off.Click += new System.EventHandler(this.Btn4OFF_Click);
            // 
            // Btn4On
            // 
            this.Btn4On.BackgroundImage = global::PlugController.Properties.Resources._004_computer;
            this.Btn4On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn4On.Location = new System.Drawing.Point(13, 178);
            this.Btn4On.Name = "Btn4On";
            this.Btn4On.Size = new System.Drawing.Size(62, 49);
            this.Btn4On.TabIndex = 24;
            this.Btn4On.UseVisualStyleBackColor = true;
            this.Btn4On.Click += new System.EventHandler(this.Btn4ON_Click);
            // 
            // Btn3Off
            // 
            this.Btn3Off.BackgroundImage = global::PlugController.Properties.Resources._002_fan_off;
            this.Btn3Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn3Off.Location = new System.Drawing.Point(81, 123);
            this.Btn3Off.Name = "Btn3Off";
            this.Btn3Off.Size = new System.Drawing.Size(62, 49);
            this.Btn3Off.TabIndex = 23;
            this.Btn3Off.UseVisualStyleBackColor = true;
            this.Btn3Off.Click += new System.EventHandler(this.Btn3OFF_Click);
            // 
            // Btn3On
            // 
            this.Btn3On.BackgroundImage = global::PlugController.Properties.Resources._002_fan;
            this.Btn3On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn3On.Location = new System.Drawing.Point(13, 123);
            this.Btn3On.Name = "Btn3On";
            this.Btn3On.Size = new System.Drawing.Size(62, 49);
            this.Btn3On.TabIndex = 22;
            this.Btn3On.UseVisualStyleBackColor = true;
            this.Btn3On.Click += new System.EventHandler(this.Btn3ON_Click);
            // 
            // Btn2Off
            // 
            this.Btn2Off.BackgroundImage = global::PlugController.Properties.Resources._003_lamp_off;
            this.Btn2Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn2Off.Location = new System.Drawing.Point(81, 68);
            this.Btn2Off.Name = "Btn2Off";
            this.Btn2Off.Size = new System.Drawing.Size(62, 49);
            this.Btn2Off.TabIndex = 21;
            this.Btn2Off.UseVisualStyleBackColor = true;
            this.Btn2Off.Click += new System.EventHandler(this.Btn2OFF_Click);
            // 
            // Btn2On
            // 
            this.Btn2On.BackgroundImage = global::PlugController.Properties.Resources._003_lamp;
            this.Btn2On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn2On.Location = new System.Drawing.Point(13, 68);
            this.Btn2On.Name = "Btn2On";
            this.Btn2On.Size = new System.Drawing.Size(62, 49);
            this.Btn2On.TabIndex = 20;
            this.Btn2On.UseVisualStyleBackColor = true;
            this.Btn2On.Click += new System.EventHandler(this.Btn2ON_Click);
            // 
            // Btn1Off
            // 
            this.Btn1Off.BackgroundImage = global::PlugController.Properties.Resources._003_lamp_off;
            this.Btn1Off.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn1Off.Location = new System.Drawing.Point(81, 13);
            this.Btn1Off.Name = "Btn1Off";
            this.Btn1Off.Size = new System.Drawing.Size(62, 49);
            this.Btn1Off.TabIndex = 19;
            this.Btn1Off.UseVisualStyleBackColor = true;
            this.Btn1Off.Click += new System.EventHandler(this.Btn1OFF_Click);
            // 
            // BtnALLON
            // 
            this.BtnALLON.BackgroundImage = global::PlugController.Properties.Resources._005_power_on;
            this.BtnALLON.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnALLON.Location = new System.Drawing.Point(12, 237);
            this.BtnALLON.Name = "BtnALLON";
            this.BtnALLON.Size = new System.Drawing.Size(62, 49);
            this.BtnALLON.TabIndex = 17;
            this.BtnALLON.Text = "All";
            this.BtnALLON.UseVisualStyleBackColor = true;
            this.BtnALLON.Click += new System.EventHandler(this.BtnALLON_Click);
            // 
            // Btn1On
            // 
            this.Btn1On.BackgroundImage = global::PlugController.Properties.Resources._003_lamp;
            this.Btn1On.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn1On.Location = new System.Drawing.Point(13, 13);
            this.Btn1On.Name = "Btn1On";
            this.Btn1On.Size = new System.Drawing.Size(62, 49);
            this.Btn1On.TabIndex = 0;
            this.Btn1On.UseVisualStyleBackColor = true;
            this.Btn1On.Click += new System.EventHandler(this.Btn1ON_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(157, 298);
            this.Controls.Add(this.Btn4Off);
            this.Controls.Add(this.Btn4On);
            this.Controls.Add(this.Btn3Off);
            this.Controls.Add(this.Btn3On);
            this.Controls.Add(this.Btn2Off);
            this.Controls.Add(this.Btn2On);
            this.Controls.Add(this.Btn1Off);
            this.Controls.Add(this.BtnALLOFF);
            this.Controls.Add(this.BtnALLON);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Btn1On);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plug Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn1On;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button BtnALLOFF;
        private System.Windows.Forms.Button BtnALLON;
        private System.Windows.Forms.Button Btn1Off;
        private System.Windows.Forms.Button Btn2On;
        private System.Windows.Forms.Button Btn2Off;
        private System.Windows.Forms.Button Btn3On;
        private System.Windows.Forms.Button Btn3Off;
        private System.Windows.Forms.Button Btn4On;
        private System.Windows.Forms.Button Btn4Off;
    }
}

