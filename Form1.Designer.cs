
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
            this.btnRead = new System.Windows.Forms.Button();
            this.grbScore = new System.Windows.Forms.GroupBox();
            this.chkCambioCampo = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.optSet4 = new System.Windows.Forms.RadioButton();
            this.optSet3 = new System.Windows.Forms.RadioButton();
            this.optSet2 = new System.Windows.Forms.RadioButton();
            this.optSet1 = new System.Windows.Forms.RadioButton();
            this.optSet0 = new System.Windows.Forms.RadioButton();
            this.txtSetB_4 = new System.Windows.Forms.TextBox();
            this.txtSetB_3 = new System.Windows.Forms.TextBox();
            this.txtSetB_2 = new System.Windows.Forms.TextBox();
            this.txtSetB_1 = new System.Windows.Forms.TextBox();
            this.txtSetB_0 = new System.Windows.Forms.TextBox();
            this.txtSetA_4 = new System.Windows.Forms.TextBox();
            this.txtSetA_3 = new System.Windows.Forms.TextBox();
            this.txtSetA_2 = new System.Windows.Forms.TextBox();
            this.txtSetA_1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSetA_0 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtTurnoB = new System.Windows.Forms.TextBox();
            this.txtTurnoA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGameB = new System.Windows.Forms.TextBox();
            this.txtGameA = new System.Windows.Forms.TextBox();
            this.rgbConfig = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkNameEnable = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameA = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkEnableBuzzer = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.trbBrightness = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkExtraTieBreak = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudLimitTieBreakExtra = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudSetLimit = new System.Windows.Forms.NumericUpDown();
            this.chkKillerPoint = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudN_Set = new System.Windows.Forms.NumericUpDown();
            this.nudLimitTieBreak = new System.Windows.Forms.NumericUpDown();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnTimeSet = new System.Windows.Forms.Button();
            this.btnReadScore = new System.Windows.Forms.Button();
            this.btnWriteScore = new System.Windows.Forms.Button();
            this.btnConnection = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.grbScore.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.rgbConfig.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreakExtra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN_Set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreak)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstlbl1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 525);
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
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(388, 471);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(148, 51);
            this.btnRead.TabIndex = 47;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // grbScore
            // 
            this.grbScore.Controls.Add(this.chkCambioCampo);
            this.grbScore.Controls.Add(this.groupBox7);
            this.grbScore.Controls.Add(this.groupBox6);
            this.grbScore.Location = new System.Drawing.Point(7, 8);
            this.grbScore.Name = "grbScore";
            this.grbScore.Size = new System.Drawing.Size(375, 457);
            this.grbScore.TabIndex = 48;
            this.grbScore.TabStop = false;
            this.grbScore.Text = "Score";
            // 
            // chkCambioCampo
            // 
            this.chkCambioCampo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCambioCampo.Image = global::SetUp.Properties.Resources._1494937143_reload;
            this.chkCambioCampo.Location = new System.Drawing.Point(147, 405);
            this.chkCambioCampo.Name = "chkCambioCampo";
            this.chkCambioCampo.Size = new System.Drawing.Size(79, 46);
            this.chkCambioCampo.TabIndex = 2;
            this.chkCambioCampo.UseVisualStyleBackColor = true;
            this.chkCambioCampo.CheckedChanged += new System.EventHandler(this.chkCambioCampo_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.optSet4);
            this.groupBox7.Controls.Add(this.optSet3);
            this.groupBox7.Controls.Add(this.optSet2);
            this.groupBox7.Controls.Add(this.optSet1);
            this.groupBox7.Controls.Add(this.optSet0);
            this.groupBox7.Controls.Add(this.txtSetB_4);
            this.groupBox7.Controls.Add(this.txtSetB_3);
            this.groupBox7.Controls.Add(this.txtSetB_2);
            this.groupBox7.Controls.Add(this.txtSetB_1);
            this.groupBox7.Controls.Add(this.txtSetB_0);
            this.groupBox7.Controls.Add(this.txtSetA_4);
            this.groupBox7.Controls.Add(this.txtSetA_3);
            this.groupBox7.Controls.Add(this.txtSetA_2);
            this.groupBox7.Controls.Add(this.txtSetA_1);
            this.groupBox7.Controls.Add(this.label10);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.txtSetA_0);
            this.groupBox7.Location = new System.Drawing.Point(11, 175);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(352, 224);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Set";
            // 
            // optSet4
            // 
            this.optSet4.AutoSize = true;
            this.optSet4.Location = new System.Drawing.Point(279, 106);
            this.optSet4.Name = "optSet4";
            this.optSet4.Size = new System.Drawing.Size(47, 17);
            this.optSet4.TabIndex = 32;
            this.optSet4.TabStop = true;
            this.optSet4.Text = "Set5";
            this.optSet4.UseVisualStyleBackColor = true;
            // 
            // optSet3
            // 
            this.optSet3.AutoSize = true;
            this.optSet3.Location = new System.Drawing.Point(215, 106);
            this.optSet3.Name = "optSet3";
            this.optSet3.Size = new System.Drawing.Size(47, 17);
            this.optSet3.TabIndex = 31;
            this.optSet3.TabStop = true;
            this.optSet3.Text = "Set4";
            this.optSet3.UseVisualStyleBackColor = true;
            // 
            // optSet2
            // 
            this.optSet2.AutoSize = true;
            this.optSet2.Location = new System.Drawing.Point(150, 106);
            this.optSet2.Name = "optSet2";
            this.optSet2.Size = new System.Drawing.Size(47, 17);
            this.optSet2.TabIndex = 30;
            this.optSet2.TabStop = true;
            this.optSet2.Text = "Set3";
            this.optSet2.UseVisualStyleBackColor = true;
            // 
            // optSet1
            // 
            this.optSet1.AutoSize = true;
            this.optSet1.Location = new System.Drawing.Point(85, 106);
            this.optSet1.Name = "optSet1";
            this.optSet1.Size = new System.Drawing.Size(47, 17);
            this.optSet1.TabIndex = 29;
            this.optSet1.TabStop = true;
            this.optSet1.Text = "Set2";
            this.optSet1.UseVisualStyleBackColor = true;
            // 
            // optSet0
            // 
            this.optSet0.AutoSize = true;
            this.optSet0.Location = new System.Drawing.Point(23, 106);
            this.optSet0.Name = "optSet0";
            this.optSet0.Size = new System.Drawing.Size(47, 17);
            this.optSet0.TabIndex = 28;
            this.optSet0.TabStop = true;
            this.optSet0.Text = "Set1";
            this.optSet0.UseVisualStyleBackColor = true;
            // 
            // txtSetB_4
            // 
            this.txtSetB_4.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetB_4.Location = new System.Drawing.Point(279, 129);
            this.txtSetB_4.Name = "txtSetB_4";
            this.txtSetB_4.Size = new System.Drawing.Size(59, 55);
            this.txtSetB_4.TabIndex = 27;
            this.txtSetB_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetB_3
            // 
            this.txtSetB_3.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetB_3.Location = new System.Drawing.Point(215, 129);
            this.txtSetB_3.Name = "txtSetB_3";
            this.txtSetB_3.Size = new System.Drawing.Size(59, 55);
            this.txtSetB_3.TabIndex = 26;
            this.txtSetB_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetB_2
            // 
            this.txtSetB_2.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetB_2.Location = new System.Drawing.Point(150, 129);
            this.txtSetB_2.Name = "txtSetB_2";
            this.txtSetB_2.Size = new System.Drawing.Size(59, 55);
            this.txtSetB_2.TabIndex = 25;
            this.txtSetB_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetB_1
            // 
            this.txtSetB_1.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetB_1.Location = new System.Drawing.Point(85, 129);
            this.txtSetB_1.Name = "txtSetB_1";
            this.txtSetB_1.Size = new System.Drawing.Size(59, 55);
            this.txtSetB_1.TabIndex = 24;
            this.txtSetB_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetB_0
            // 
            this.txtSetB_0.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetB_0.Location = new System.Drawing.Point(20, 129);
            this.txtSetB_0.Name = "txtSetB_0";
            this.txtSetB_0.Size = new System.Drawing.Size(59, 55);
            this.txtSetB_0.TabIndex = 23;
            this.txtSetB_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetA_4
            // 
            this.txtSetA_4.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetA_4.Location = new System.Drawing.Point(279, 45);
            this.txtSetA_4.Name = "txtSetA_4";
            this.txtSetA_4.Size = new System.Drawing.Size(59, 55);
            this.txtSetA_4.TabIndex = 22;
            this.txtSetA_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetA_3
            // 
            this.txtSetA_3.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetA_3.Location = new System.Drawing.Point(215, 45);
            this.txtSetA_3.Name = "txtSetA_3";
            this.txtSetA_3.Size = new System.Drawing.Size(59, 55);
            this.txtSetA_3.TabIndex = 21;
            this.txtSetA_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetA_2
            // 
            this.txtSetA_2.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetA_2.Location = new System.Drawing.Point(150, 45);
            this.txtSetA_2.Name = "txtSetA_2";
            this.txtSetA_2.Size = new System.Drawing.Size(59, 55);
            this.txtSetA_2.TabIndex = 20;
            this.txtSetA_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSetA_1
            // 
            this.txtSetA_1.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetA_1.Location = new System.Drawing.Point(85, 45);
            this.txtSetA_1.Name = "txtSetA_1";
            this.txtSetA_1.Size = new System.Drawing.Size(59, 55);
            this.txtSetA_1.TabIndex = 19;
            this.txtSetA_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Player 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Player 1";
            // 
            // txtSetA_0
            // 
            this.txtSetA_0.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtSetA_0.Location = new System.Drawing.Point(20, 45);
            this.txtSetA_0.Name = "txtSetA_0";
            this.txtSetA_0.Size = new System.Drawing.Size(59, 55);
            this.txtSetA_0.TabIndex = 13;
            this.txtSetA_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtTurnoB);
            this.groupBox6.Controls.Add(this.txtTurnoA);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtGameB);
            this.groupBox6.Controls.Add(this.txtGameA);
            this.groupBox6.Location = new System.Drawing.Point(11, 22);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 141);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Game";
            // 
            // txtTurnoB
            // 
            this.txtTurnoB.BackColor = System.Drawing.Color.White;
            this.txtTurnoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnoB.Location = new System.Drawing.Point(193, 34);
            this.txtTurnoB.Name = "txtTurnoB";
            this.txtTurnoB.ReadOnly = true;
            this.txtTurnoB.Size = new System.Drawing.Size(89, 12);
            this.txtTurnoB.TabIndex = 20;
            this.txtTurnoB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTurnoB_MouseClick);
            // 
            // txtTurnoA
            // 
            this.txtTurnoA.BackColor = System.Drawing.Color.White;
            this.txtTurnoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurnoA.Location = new System.Drawing.Point(65, 34);
            this.txtTurnoA.Name = "txtTurnoA";
            this.txtTurnoA.ReadOnly = true;
            this.txtTurnoA.Size = new System.Drawing.Size(89, 12);
            this.txtTurnoA.TabIndex = 19;
            this.txtTurnoA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTurnoA_MouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(160, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 37);
            this.label8.TabIndex = 18;
            this.label8.Text = "-";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Player 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Player 1";
            // 
            // txtGameB
            // 
            this.txtGameB.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtGameB.Location = new System.Drawing.Point(193, 52);
            this.txtGameB.Name = "txtGameB";
            this.txtGameB.Size = new System.Drawing.Size(89, 55);
            this.txtGameB.TabIndex = 15;
            this.txtGameB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGameA
            // 
            this.txtGameA.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtGameA.Location = new System.Drawing.Point(65, 52);
            this.txtGameA.Name = "txtGameA";
            this.txtGameA.Size = new System.Drawing.Size(89, 55);
            this.txtGameA.TabIndex = 13;
            this.txtGameA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rgbConfig
            // 
            this.rgbConfig.Controls.Add(this.groupBox5);
            this.rgbConfig.Controls.Add(this.groupBox4);
            this.rgbConfig.Controls.Add(this.groupBox3);
            this.rgbConfig.Controls.Add(this.groupBox2);
            this.rgbConfig.Controls.Add(this.groupBox1);
            this.rgbConfig.Location = new System.Drawing.Point(388, 8);
            this.rgbConfig.Name = "rgbConfig";
            this.rgbConfig.Size = new System.Drawing.Size(312, 457);
            this.rgbConfig.TabIndex = 49;
            this.rgbConfig.TabStop = false;
            this.rgbConfig.Text = "Config";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkNameEnable);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtNameB);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtNameA);
            this.groupBox5.Location = new System.Drawing.Point(164, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(142, 250);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Setting Name";
            // 
            // chkNameEnable
            // 
            this.chkNameEnable.AutoSize = true;
            this.chkNameEnable.Location = new System.Drawing.Point(10, 26);
            this.chkNameEnable.Name = "chkNameEnable";
            this.chkNameEnable.Size = new System.Drawing.Size(90, 17);
            this.chkNameEnable.TabIndex = 16;
            this.chkNameEnable.Text = "Name Enable";
            this.chkNameEnable.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Player 2";
            // 
            // txtNameB
            // 
            this.txtNameB.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtNameB.Location = new System.Drawing.Point(26, 166);
            this.txtNameB.Name = "txtNameB";
            this.txtNameB.Size = new System.Drawing.Size(89, 55);
            this.txtNameB.TabIndex = 14;
            this.txtNameB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameB.TextChanged += new System.EventHandler(this.txtNameB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Player 1";
            // 
            // txtNameA
            // 
            this.txtNameA.Font = new System.Drawing.Font("Arial Black", 25.25F, System.Drawing.FontStyle.Bold);
            this.txtNameA.Location = new System.Drawing.Point(26, 77);
            this.txtNameA.Name = "txtNameA";
            this.txtNameA.Size = new System.Drawing.Size(89, 55);
            this.txtNameA.TabIndex = 12;
            this.txtNameA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNameA.TextChanged += new System.EventHandler(this.txtNameA_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkEnableBuzzer);
            this.groupBox4.Location = new System.Drawing.Point(6, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 46);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Setting Sound";
            // 
            // chkEnableBuzzer
            // 
            this.chkEnableBuzzer.AutoSize = true;
            this.chkEnableBuzzer.Checked = true;
            this.chkEnableBuzzer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnableBuzzer.Location = new System.Drawing.Point(7, 21);
            this.chkEnableBuzzer.Name = "chkEnableBuzzer";
            this.chkEnableBuzzer.Size = new System.Drawing.Size(77, 17);
            this.chkEnableBuzzer.TabIndex = 2;
            this.chkEnableBuzzer.Text = "Buzzer ON";
            this.chkEnableBuzzer.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBrightness);
            this.groupBox3.Controls.Add(this.trbBrightness);
            this.groupBox3.Location = new System.Drawing.Point(6, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 88);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Setting Display Led";
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(6, 21);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(56, 13);
            this.lblBrightness.TabIndex = 4;
            this.lblBrightness.Text = "Brightness";
            // 
            // trbBrightness
            // 
            this.trbBrightness.LargeChange = 1;
            this.trbBrightness.Location = new System.Drawing.Point(4, 37);
            this.trbBrightness.Maximum = 12;
            this.trbBrightness.Minimum = 1;
            this.trbBrightness.Name = "trbBrightness";
            this.trbBrightness.Size = new System.Drawing.Size(290, 45);
            this.trbBrightness.SmallChange = 2;
            this.trbBrightness.TabIndex = 3;
            this.trbBrightness.Value = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkExtraTieBreak);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nudLimitTieBreakExtra);
            this.groupBox2.Location = new System.Drawing.Point(6, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(152, 103);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Final Times";
            // 
            // chkExtraTieBreak
            // 
            this.chkExtraTieBreak.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkExtraTieBreak.Location = new System.Drawing.Point(10, 19);
            this.chkExtraTieBreak.Name = "chkExtraTieBreak";
            this.chkExtraTieBreak.Size = new System.Drawing.Size(135, 17);
            this.chkExtraTieBreak.TabIndex = 20;
            this.chkExtraTieBreak.Text = "Enable Extra Tie-Breck";
            this.chkExtraTieBreak.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tie-Breck Limit";
            // 
            // nudLimitTieBreakExtra
            // 
            this.nudLimitTieBreakExtra.Location = new System.Drawing.Point(104, 77);
            this.nudLimitTieBreakExtra.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLimitTieBreakExtra.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLimitTieBreakExtra.Name = "nudLimitTieBreakExtra";
            this.nudLimitTieBreakExtra.Size = new System.Drawing.Size(32, 20);
            this.nudLimitTieBreakExtra.TabIndex = 16;
            this.nudLimitTieBreakExtra.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudSetLimit);
            this.groupBox1.Controls.Add(this.chkKillerPoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudN_Set);
            this.groupBox1.Controls.Add(this.nudLimitTieBreak);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 141);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regular Times";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Set Limit";
            // 
            // nudSetLimit
            // 
            this.nudSetLimit.Location = new System.Drawing.Point(104, 45);
            this.nudSetLimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSetLimit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSetLimit.Name = "nudSetLimit";
            this.nudSetLimit.Size = new System.Drawing.Size(32, 20);
            this.nudSetLimit.TabIndex = 21;
            this.nudSetLimit.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // chkKillerPoint
            // 
            this.chkKillerPoint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkKillerPoint.Location = new System.Drawing.Point(10, 109);
            this.chkKillerPoint.Name = "chkKillerPoint";
            this.chkKillerPoint.Size = new System.Drawing.Size(126, 23);
            this.chkKillerPoint.TabIndex = 20;
            this.chkKillerPoint.Text = "Killer Point";
            this.chkKillerPoint.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tie-Breck Limit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "n° Set";
            // 
            // nudN_Set
            // 
            this.nudN_Set.Location = new System.Drawing.Point(104, 19);
            this.nudN_Set.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudN_Set.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudN_Set.Name = "nudN_Set";
            this.nudN_Set.Size = new System.Drawing.Size(32, 20);
            this.nudN_Set.TabIndex = 17;
            this.nudN_Set.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudN_Set.ValueChanged += new System.EventHandler(this.nudN_Set_ValueChanged);
            // 
            // nudLimitTieBreak
            // 
            this.nudLimitTieBreak.Location = new System.Drawing.Point(104, 77);
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
            this.nudLimitTieBreak.TabIndex = 16;
            this.nudLimitTieBreak.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // btnWrite
            // 
            this.btnWrite.Enabled = false;
            this.btnWrite.Location = new System.Drawing.Point(552, 471);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(148, 51);
            this.btnWrite.TabIndex = 50;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnTimeSet
            // 
            this.btnTimeSet.Location = new System.Drawing.Point(70, 471);
            this.btnTimeSet.Name = "btnTimeSet";
            this.btnTimeSet.Size = new System.Drawing.Size(65, 51);
            this.btnTimeSet.TabIndex = 51;
            this.btnTimeSet.Text = "Time Set";
            this.btnTimeSet.UseVisualStyleBackColor = true;
            this.btnTimeSet.Click += new System.EventHandler(this.btnTimeSet_Click);
            // 
            // btnReadScore
            // 
            this.btnReadScore.Location = new System.Drawing.Point(198, 471);
            this.btnReadScore.Name = "btnReadScore";
            this.btnReadScore.Size = new System.Drawing.Size(65, 51);
            this.btnReadScore.TabIndex = 53;
            this.btnReadScore.Text = "READ SCORE";
            this.btnReadScore.UseVisualStyleBackColor = true;
            this.btnReadScore.Click += new System.EventHandler(this.btnReadScore_Click);
            // 
            // btnWriteScore
            // 
            this.btnWriteScore.Enabled = false;
            this.btnWriteScore.Location = new System.Drawing.Point(269, 471);
            this.btnWriteScore.Name = "btnWriteScore";
            this.btnWriteScore.Size = new System.Drawing.Size(65, 51);
            this.btnWriteScore.TabIndex = 54;
            this.btnWriteScore.Text = "WRITE SCORE";
            this.btnWriteScore.UseVisualStyleBackColor = true;
            this.btnWriteScore.Click += new System.EventHandler(this.btnWriteScore_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.Image = ((System.Drawing.Image)(resources.GetObject("btnConnection.Image")));
            this.btnConnection.Location = new System.Drawing.Point(12, 471);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(52, 51);
            this.btnConnection.TabIndex = 46;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 547);
            this.Controls.Add(this.btnWriteScore);
            this.Controls.Add(this.btnReadScore);
            this.Controls.Add(this.btnTimeSet);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.rgbConfig);
            this.Controls.Add(this.grbScore);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SetUp Table Ver.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grbScore.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.rgbConfig.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbBrightness)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreakExtra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSetLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudN_Set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimitTieBreak)).EndInit();
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
        private System.Windows.Forms.Button btnTimeSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkExtraTieBreak;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudLimitTieBreakExtra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudN_Set;
        private System.Windows.Forms.NumericUpDown nudLimitTieBreak;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameA;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkEnableBuzzer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar trbBrightness;
        private System.Windows.Forms.CheckBox chkKillerPoint;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGameB;
        private System.Windows.Forms.TextBox txtGameA;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSetB_4;
        private System.Windows.Forms.TextBox txtSetB_3;
        private System.Windows.Forms.TextBox txtSetB_2;
        private System.Windows.Forms.TextBox txtSetB_1;
        private System.Windows.Forms.TextBox txtSetB_0;
        private System.Windows.Forms.TextBox txtSetA_4;
        private System.Windows.Forms.TextBox txtSetA_3;
        private System.Windows.Forms.TextBox txtSetA_2;
        private System.Windows.Forms.TextBox txtSetA_1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSetA_0;
        private System.Windows.Forms.Button btnReadScore;
        private System.Windows.Forms.RadioButton optSet4;
        private System.Windows.Forms.RadioButton optSet3;
        private System.Windows.Forms.RadioButton optSet2;
        private System.Windows.Forms.RadioButton optSet1;
        private System.Windows.Forms.RadioButton optSet0;
        private System.Windows.Forms.TextBox txtTurnoB;
        private System.Windows.Forms.TextBox txtTurnoA;
        private System.Windows.Forms.Button btnWriteScore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudSetLimit;
        private System.Windows.Forms.CheckBox chkNameEnable;
        private System.Windows.Forms.CheckBox chkCambioCampo;
    }
}

