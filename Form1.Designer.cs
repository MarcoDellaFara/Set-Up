
namespace SetUp
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstlbl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.grbScore = new System.Windows.Forms.GroupBox();
            this.rgbConfig = new System.Windows.Forms.GroupBox();
            this.nudLimitTieBreak = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.trbBrightness = new System.Windows.Forms.TrackBar();
            this.chkEnableBuzzer = new System.Windows.Forms.CheckBox();
            this.chkKillerPoint = new System.Windows.Forms.CheckBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnTimeSet = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.rgbConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlbl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(710, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstlbl1
            // 
            this.tstlbl1.Name = "tstlbl1";
            this.tstlbl1.Size = new System.Drawing.Size(40, 17);
            this.tstlbl1.Text = "COM?";
            // 
            // btnConnection
            // 
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.Location = new System.Drawing.Point(12, 374);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(52, 51);
            this.btnConnection.TabIndex = 46;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(388, 374);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(148, 51);
            this.btnRead.TabIndex = 47;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // grbScore
            // 
            this.grbScore.Location = new System.Drawing.Point(7, 8);
            this.grbScore.Name = "grbScore";
            this.grbScore.Size = new System.Drawing.Size(375, 352);
            this.grbScore.TabIndex = 48;
            this.grbScore.TabStop = false;
            this.grbScore.Text = "Score";
            // 
            // rgbConfig
            // 
            this.rgbConfig.Controls.Add(this.nudLimitTieBreak);
            this.rgbConfig.Controls.Add(this.label2);
            this.rgbConfig.Controls.Add(this.txtNameB);
            this.rgbConfig.Controls.Add(this.label1);
            this.rgbConfig.Controls.Add(this.txtNameA);
            this.rgbConfig.Controls.Add(this.lblBrightness);
            this.rgbConfig.Controls.Add(this.trbBrightness);
            this.rgbConfig.Controls.Add(this.chkEnableBuzzer);
            this.rgbConfig.Controls.Add(this.chkKillerPoint);
            this.rgbConfig.Location = new System.Drawing.Point(388, 8);
            this.rgbConfig.Name = "rgbConfig";
            this.rgbConfig.Size = new System.Drawing.Size(312, 352);
            this.rgbConfig.TabIndex = 49;
            this.rgbConfig.TabStop = false;
            this.rgbConfig.Text = "Config";
            // 
            // nudLimitTieBreak
            // 
            this.nudLimitTieBreak.Location = new System.Drawing.Point(20, 89);
            this.nudLimitTieBreak.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLimitTieBreak.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLimitTieBreak.Name = "nudLimitTieBreak";
            this.nudLimitTieBreak.Size = new System.Drawing.Size(32, 20);
            this.nudLimitTieBreak.TabIndex = 12;
            this.nudLimitTieBreak.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 2";
            // 
            // txtNameB
            // 
            this.txtNameB.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtNameB.Location = new System.Drawing.Point(20, 291);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(89, 55);
            this.txtNameB.TabIndex = 8;
            this.txtNameB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameB.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player 1";
            // 
            // txtNameA
            // 
            this.txtNameA.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtNameA.Location = new System.Drawing.Point(20, 208);
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(89, 55);
            this.txtNameA.TabIndex = 4;
            this.txtNameA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameA.TextChanged += new System.EventHandler(this.txtNameA_TextChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(29, 128);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(56, 13);
            this.lblBrightness.TabIndex = 3;
            this.lblBrightness.Text = "Brightness";
            // 
            // trbBrightness
            // 
            this.trbBrightness.LargeChange = 1;
            this.trbBrightness.Location = new System.Drawing.Point(20, 144);
            this.trbBrightness.Maximum = 12;
            this.trbBrightness.Minimum = 1;
            this.trbBrightness.Name = "trbBrightness";
            this.trbBrightness.Size = new System.Drawing.Size(205, 45);
            this.trbBrightness.SmallChange = 2;
            this.trbBrightness.TabIndex = 2;
            this.trbBrightness.Value = 3;
            // 
            // chkEnableBuzzer
            // 
            this.chkEnableBuzzer.AutoSize = true;
            this.chkEnableBuzzer.Checked = true;
            this.chkEnableBuzzer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableBuzzer.Location = new System.Drawing.Point(20, 54);
            this.chkEnableBuzzer.Name = "chkEnableBuzzer";
            this.chkEnableBuzzer.Size = new System.Drawing.Size(77, 17);
            this.chkEnableBuzzer.TabIndex = 1;
            this.chkEnableBuzzer.Text = "Buzzer ON";
            this.chkEnableBuzzer.UseVisualStyleBackColor = true;
            // 
            // chkKillerPoint
            // 
            this.chkKillerPoint.AutoSize = true;
            this.chkKillerPoint.Location = new System.Drawing.Point(20, 31);
            this.chkKillerPoint.Name = "chkKillerPoint";
            this.chkKillerPoint.Size = new System.Drawing.Size(75, 17);
            this.chkKillerPoint.TabIndex = 0;
            this.chkKillerPoint.Text = "Killer Point";
            this.chkKillerPoint.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(552, 374);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(148, 51);
            this.btnWrite.TabIndex = 50;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnTimeSet
            // 
            this.btnTimeSet.Location = new System.Drawing.Point(144, 374);
            this.btnTimeSet.Name = "btnTimeSet";
            this.btnTimeSet.Size = new System.Drawing.Size(148, 51);
            this.btnTimeSet.TabIndex = 51;
            this.btnTimeSet.Text = "Time Set";
            this.btnTimeSet.UseVisualStyleBackColor = true;
            this.btnTimeSet.Click += new System.EventHandler(this.btnTimeSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.btnTimeSet);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rgbConfig);
            this.Controls.Add(this.grbScore);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "SetUp Table Ver.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.rgbConfig.ResumeLayout(false);
            this.rgbConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstlbl1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.GroupBox grbScore;
        private System.Windows.Forms.GroupBox rgbConfig;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.CheckBox chkKillerPoint;
        private System.Windows.Forms.CheckBox chkEnableBuzzer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameA;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar trbBrightness;
        private System.Windows.Forms.NumericUpDown nudLimitTieBreak;
        private System.Windows.Forms.Button btnTimeSet;
    }
}

