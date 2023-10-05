
namespace SetUp
{
    partial class frmLastNews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLastNews));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btmOK = new System.Windows.Forms.Button();
            this.chkEnableViewLastNews = new System.Windows.Forms.CheckBox();
            this.lblVer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(184, 7);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(604, 420);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "1.1.1\nGestione della mancata connettività ad Internet.\n\n1.1.0\nAggiunto la Verific" +
    "a automatica degli aggiornamenti online all\'avvio del programma.";
            // 
            // btmOK
            // 
            this.btmOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btmOK.Location = new System.Drawing.Point(616, 433);
            this.btmOK.Name = "btmOK";
            this.btmOK.Size = new System.Drawing.Size(172, 34);
            this.btmOK.TabIndex = 1;
            this.btmOK.Text = "&OK";
            this.btmOK.UseVisualStyleBackColor = true;
            this.btmOK.Click += new System.EventHandler(this.btmOK_Click);
            // 
            // chkEnableViewLastNews
            // 
            this.chkEnableViewLastNews.AutoSize = true;
            this.chkEnableViewLastNews.BackColor = System.Drawing.Color.Orange;
            this.chkEnableViewLastNews.Checked = true;
            this.chkEnableViewLastNews.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableViewLastNews.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnableViewLastNews.Location = new System.Drawing.Point(12, 440);
            this.chkEnableViewLastNews.Name = "chkEnableViewLastNews";
            this.chkEnableViewLastNews.Size = new System.Drawing.Size(392, 22);
            this.chkEnableViewLastNews.TabIndex = 2;
            this.chkEnableViewLastNews.Text = "Visualizza questa finestra all\'avvio del programma.";
            this.chkEnableViewLastNews.UseVisualStyleBackColor = false;
            // 
            // lblVer
            // 
            this.lblVer.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.lblVer.Location = new System.Drawing.Point(17, 58);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(139, 29);
            this.lblVer.TabIndex = 3;
            this.lblVer.Text = "label1";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F);
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Actual Version:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLastNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.chkEnableViewLastNews);
            this.Controls.Add(this.btmOK);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLastNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLastNews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btmOK;
        public System.Windows.Forms.CheckBox chkEnableViewLastNews;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblVer;
        public System.Windows.Forms.Label label1;
    }
}