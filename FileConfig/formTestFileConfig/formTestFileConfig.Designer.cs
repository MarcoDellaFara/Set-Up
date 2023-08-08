namespace formTestFileConfig
{
    partial class formTestFileConfig
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
            this.grpProperty = new System.Windows.Forms.GroupBox();
            this.btnReadPropersty = new System.Windows.Forms.Button();
            this.btnWriteProperty = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtNameKey = new System.Windows.Forms.TextBox();
            this.txtNameSession = new System.Windows.Forms.TextBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblKeyName = new System.Windows.Forms.Label();
            this.lblSessionName = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblPathFile = new System.Windows.Forms.Label();
            this.Methods = new System.Windows.Forms.GroupBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.grpProperty.SuspendLayout();
            this.Methods.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProperty
            // 
            this.grpProperty.Controls.Add(this.btnReadPropersty);
            this.grpProperty.Controls.Add(this.btnWriteProperty);
            this.grpProperty.Controls.Add(this.txtValue);
            this.grpProperty.Controls.Add(this.txtNameKey);
            this.grpProperty.Controls.Add(this.txtNameSession);
            this.grpProperty.Controls.Add(this.txtFileName);
            this.grpProperty.Controls.Add(this.txtFilePath);
            this.grpProperty.Controls.Add(this.lblValue);
            this.grpProperty.Controls.Add(this.lblKeyName);
            this.grpProperty.Controls.Add(this.lblSessionName);
            this.grpProperty.Controls.Add(this.lblFileName);
            this.grpProperty.Controls.Add(this.lblPathFile);
            this.grpProperty.Location = new System.Drawing.Point(12, 12);
            this.grpProperty.Name = "grpProperty";
            this.grpProperty.Size = new System.Drawing.Size(598, 157);
            this.grpProperty.TabIndex = 12;
            this.grpProperty.TabStop = false;
            this.grpProperty.Text = "Property";
            // 
            // btnReadPropersty
            // 
            this.btnReadPropersty.Location = new System.Drawing.Point(507, 88);
            this.btnReadPropersty.Name = "btnReadPropersty";
            this.btnReadPropersty.Size = new System.Drawing.Size(85, 60);
            this.btnReadPropersty.TabIndex = 22;
            this.btnReadPropersty.Text = "Read Property";
            this.btnReadPropersty.UseVisualStyleBackColor = true;
            this.btnReadPropersty.Click += new System.EventHandler(this.btnReadPropersty_Click);
            // 
            // btnWriteProperty
            // 
            this.btnWriteProperty.Location = new System.Drawing.Point(507, 22);
            this.btnWriteProperty.Name = "btnWriteProperty";
            this.btnWriteProperty.Size = new System.Drawing.Size(85, 60);
            this.btnWriteProperty.TabIndex = 21;
            this.btnWriteProperty.Text = "Write Property";
            this.btnWriteProperty.UseVisualStyleBackColor = true;
            this.btnWriteProperty.Click += new System.EventHandler(this.btnWriteProperty_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(91, 129);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(410, 20);
            this.txtValue.TabIndex = 0;
            // 
            // txtNameKey
            // 
            this.txtNameKey.Location = new System.Drawing.Point(91, 100);
            this.txtNameKey.Name = "txtNameKey";
            this.txtNameKey.Size = new System.Drawing.Size(410, 20);
            this.txtNameKey.TabIndex = 20;
            // 
            // txtNameSession
            // 
            this.txtNameSession.Location = new System.Drawing.Point(91, 74);
            this.txtNameSession.Name = "txtNameSession";
            this.txtNameSession.Size = new System.Drawing.Size(410, 20);
            this.txtNameSession.TabIndex = 19;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(91, 48);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(410, 20);
            this.txtFileName.TabIndex = 18;
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(91, 22);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(410, 20);
            this.txtFilePath.TabIndex = 17;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(6, 129);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 16;
            this.lblValue.Text = "Value";
            // 
            // lblKeyName
            // 
            this.lblKeyName.AutoSize = true;
            this.lblKeyName.Location = new System.Drawing.Point(6, 103);
            this.lblKeyName.Name = "lblKeyName";
            this.lblKeyName.Size = new System.Drawing.Size(56, 13);
            this.lblKeyName.TabIndex = 15;
            this.lblKeyName.Text = "Key Name";
            // 
            // lblSessionName
            // 
            this.lblSessionName.AutoSize = true;
            this.lblSessionName.Location = new System.Drawing.Point(6, 77);
            this.lblSessionName.Name = "lblSessionName";
            this.lblSessionName.Size = new System.Drawing.Size(75, 13);
            this.lblSessionName.TabIndex = 14;
            this.lblSessionName.Text = "Session Name";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(6, 51);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 13;
            this.lblFileName.Text = "Name File";
            // 
            // lblPathFile
            // 
            this.lblPathFile.AutoSize = true;
            this.lblPathFile.Location = new System.Drawing.Point(6, 25);
            this.lblPathFile.Name = "lblPathFile";
            this.lblPathFile.Size = new System.Drawing.Size(48, 13);
            this.lblPathFile.TabIndex = 12;
            this.lblPathFile.Text = "Path File";
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.btnWrite);
            this.Methods.Controls.Add(this.btnRead);
            this.Methods.Location = new System.Drawing.Point(14, 177);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(596, 277);
            this.Methods.TabIndex = 13;
            this.Methods.TabStop = false;
            this.Methods.Text = "Methods";
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(11, 62);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(78, 30);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(11, 26);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(78, 30);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // formTestFileConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 466);
            this.Controls.Add(this.Methods);
            this.Controls.Add(this.grpProperty);
            this.Name = "formTestFileConfig";
            this.Text = "FileConfig - TEST FORM CLASS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProperty.ResumeLayout(false);
            this.grpProperty.PerformLayout();
            this.Methods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpProperty;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtNameKey;
        private System.Windows.Forms.TextBox txtNameSession;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblKeyName;
        private System.Windows.Forms.Label lblSessionName;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblPathFile;
        private System.Windows.Forms.GroupBox Methods;
        private System.Windows.Forms.Button btnWriteProperty;
        private System.Windows.Forms.Button btnReadPropersty;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
    }
}

