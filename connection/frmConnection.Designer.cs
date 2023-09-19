namespace connection
{
    partial class frmConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnection));
            this.btnSaveConfig = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPortInformation = new System.Windows.Forms.TextBox();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.cmbPortName = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRefresch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNumberByte = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRXDataHex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRXData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStringSend = new System.Windows.Forms.TextBox();
            this.btnSEND = new System.Windows.Forms.Button();
            this.cmbBaseComand = new System.Windows.Forms.ComboBox();
            this.grpInput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveConfig
            // 
            this.btnSaveConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveConfig.Image")));
            this.btnSaveConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSaveConfig.Location = new System.Drawing.Point(247, 369);
            this.btnSaveConfig.Name = "btnSaveConfig";
            this.btnSaveConfig.Size = new System.Drawing.Size(214, 41);
            this.btnSaveConfig.TabIndex = 43;
            this.btnSaveConfig.Text = "Save Configuration";
            this.btnSaveConfig.UseVisualStyleBackColor = true;
            this.btnSaveConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // grpInput
            // 
            this.grpInput.BackColor = System.Drawing.SystemColors.Control;
            this.grpInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpInput.Controls.Add(this.label9);
            this.grpInput.Controls.Add(this.txtPortInformation);
            this.grpInput.Controls.Add(this.btnClosePort);
            this.grpInput.Controls.Add(this.btnOpenPort);
            this.grpInput.Controls.Add(this.cmbPortName);
            this.grpInput.Controls.Add(this.label10);
            this.grpInput.Controls.Add(this.cmbBaudRate);
            this.grpInput.Controls.Add(this.label11);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(683, 119);
            this.grpInput.TabIndex = 44;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "RS232 - Table Tennis/Paddle";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(6, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Port Information";
            // 
            // txtPortInformation
            // 
            this.txtPortInformation.BackColor = System.Drawing.Color.White;
            this.txtPortInformation.CausesValidation = false;
            this.txtPortInformation.Location = new System.Drawing.Point(6, 91);
            this.txtPortInformation.Name = "txtPortInformation";
            this.txtPortInformation.ReadOnly = true;
            this.txtPortInformation.Size = new System.Drawing.Size(670, 20);
            this.txtPortInformation.TabIndex = 0;
            this.txtPortInformation.TabStop = false;
            // 
            // btnClosePort
            // 
            this.btnClosePort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClosePort.Location = new System.Drawing.Point(612, 13);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(64, 48);
            this.btnClosePort.TabIndex = 4;
            this.btnClosePort.Text = "CLOSE PORT";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOpenPort.Location = new System.Drawing.Point(544, 13);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(62, 48);
            this.btnOpenPort.TabIndex = 3;
            this.btnOpenPort.Text = "OPEN PORT";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // cmbPortName
            // 
            this.cmbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPortName.FormattingEnabled = true;
            this.cmbPortName.Location = new System.Drawing.Point(75, 13);
            this.cmbPortName.Name = "cmbPortName";
            this.cmbPortName.Size = new System.Drawing.Size(463, 21);
            this.cmbPortName.Sorted = true;
            this.cmbPortName.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(4, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Port Names";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cmbBaudRate.Location = new System.Drawing.Point(75, 40);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(463, 21);
            this.cmbBaudRate.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(4, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Baud Rate";
            // 
            // btnRefresch
            // 
            this.btnRefresch.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresch.Image")));
            this.btnRefresch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresch.Location = new System.Drawing.Point(14, 369);
            this.btnRefresch.Name = "btnRefresch";
            this.btnRefresch.Size = new System.Drawing.Size(227, 41);
            this.btnRefresch.TabIndex = 42;
            this.btnRefresch.Text = "Refresh Port";
            this.btnRefresch.UseVisualStyleBackColor = true;
            this.btnRefresch.Click += new System.EventHandler(this.btnRefresch_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnClose.Location = new System.Drawing.Point(467, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(225, 41);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNumberByte);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRXDataHex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTimeOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRXData);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtStringSend);
            this.groupBox1.Controls.Add(this.btnSEND);
            this.groupBox1.Controls.Add(this.cmbBaseComand);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 226);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Debug";
            // 
            // lblNumberByte
            // 
            this.lblNumberByte.AutoSize = true;
            this.lblNumberByte.Location = new System.Drawing.Point(101, 195);
            this.lblNumberByte.Name = "lblNumberByte";
            this.lblNumberByte.Size = new System.Drawing.Size(10, 13);
            this.lblNumberByte.TabIndex = 85;
            this.lblNumberByte.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 84;
            this.label12.Text = "RX Numebr Byte:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "RX Data Hex";
            // 
            // txtRXDataHex
            // 
            this.txtRXDataHex.BackColor = System.Drawing.SystemColors.Control;
            this.txtRXDataHex.Location = new System.Drawing.Point(98, 166);
            this.txtRXDataHex.Name = "txtRXDataHex";
            this.txtRXDataHex.ReadOnly = true;
            this.txtRXDataHex.Size = new System.Drawing.Size(484, 20);
            this.txtRXDataHex.TabIndex = 82;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(584, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "Time-Out (mSec)";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(587, 34);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(84, 20);
            this.txtTimeOut.TabIndex = 80;
            this.txtTimeOut.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 79;
            this.label6.Text = "RX Data String";
            // 
            // txtRXData
            // 
            this.txtRXData.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRXData.Location = new System.Drawing.Point(98, 140);
            this.txtRXData.Name = "txtRXData";
            this.txtRXData.ReadOnly = true;
            this.txtRXData.Size = new System.Drawing.Size(483, 20);
            this.txtRXData.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "TX Data String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Base Comand ";
            // 
            // txtStringSend
            // 
            this.txtStringSend.Location = new System.Drawing.Point(85, 95);
            this.txtStringSend.Name = "txtStringSend";
            this.txtStringSend.Size = new System.Drawing.Size(497, 20);
            this.txtStringSend.TabIndex = 75;
            // 
            // btnSEND
            // 
            this.btnSEND.Location = new System.Drawing.Point(587, 94);
            this.btnSEND.Name = "btnSEND";
            this.btnSEND.Size = new System.Drawing.Size(84, 92);
            this.btnSEND.TabIndex = 74;
            this.btnSEND.Text = "SEND";
            this.btnSEND.UseVisualStyleBackColor = true;
            this.btnSEND.Click += new System.EventHandler(this.btnSEND_Click);
            // 
            // cmbBaseComand
            // 
            this.cmbBaseComand.FormattingEnabled = true;
            this.cmbBaseComand.Items.AddRange(new object[] {
            "RX,Ready",
            "RX,PRG=0000,CTR=A,Counter",
            "WX,StartMarking",
            "RX,MarkedCharacter=1998,007",
            "WX,ProgramNo=0000",
            "WX,PRG=1998,BLK=000,MarkingEnable=2,1110001100000101100011000000000000000"});
            this.cmbBaseComand.Location = new System.Drawing.Point(85, 22);
            this.cmbBaseComand.Name = "cmbBaseComand";
            this.cmbBaseComand.Size = new System.Drawing.Size(224, 21);
            this.cmbBaseComand.TabIndex = 73;
            this.cmbBaseComand.Text = "--> Select Comand <--";
            this.cmbBaseComand.SelectedIndexChanged += new System.EventHandler(this.cmbBaseComand_SelectedIndexChanged);
            // 
            // frmConnection
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(703, 417);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveConfig);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnRefresch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConnection";
            this.Text = "Connection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmConnection_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSaveConfig;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPortInformation;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox cmbPortName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRefresch;
        private System.Windows.Forms.Button btnClose;
        public System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStringSend;
        private System.Windows.Forms.Button btnSEND;
        private System.Windows.Forms.ComboBox cmbBaseComand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRXData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRXDataHex;
        private System.Windows.Forms.Label lblNumberByte;
        private System.Windows.Forms.Label label12;
    }
}

