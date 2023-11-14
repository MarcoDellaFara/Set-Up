using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using connection;
using System.IO;

namespace SetUp
{
    public partial class frmMain : Form
    {
        //unsigned Killer_Point:1;
        //    unsigned b1:1;
        //    unsigned b2:1;
        //    unsigned b3:1;
        //    unsigned b4:1;
        //    unsigned b5:1;
        //    unsigned b6:1;
        //    unsigned EnableBuzzer:1;
        //    uint8_t setBrightness;
        //    unsigned char NameA[3];
        //    unsigned char NameB[3];
        //    uint8_t Tie_Break_Limit;
        //    uint16_t CRC;
        //};

frmConnection frmCON = new frmConnection();

        string LocalVer;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LocalVer = Application.ProductVersion.Substring(0, 5);
            string VerCompile = Application.ProductVersion.Substring(6);

            this.Text = this.Text + LocalVer + " (" + VerCompile + ")";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            FileConfig cfg = new FileConfig();

            string NewVer = get_NewVersion();

            if (NewVer == "@NoConnect")
            {
                string str_Connect = cfg.Read("appSettings", "View_MessageNoConnect");

                if (str_Connect == "True")
                {
                    string msg = "Impossibile rilevare aggiornamenti ON-LINE!\r\n" +
                    "Verifica la connessione Internet!\r\n " +
                    "\r\n " +
                    "Vuoi disabilitare questo messaggio all'avvio del Programma?";

                    DialogResult res = MessageBox.Show(msg, "ATTENZIONE", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        cfg.Write("appSettings", "View_MessageNoConnect", "False");
                    }
                }
            }
            else if (NewVer != "")
            {
                if (int.Parse(NewVer.Replace(".", "")) > int.Parse(LocalVer.Replace(".", "")))
                {
                    string msg =    "E' disponibile la nuova versione " + NewVer + " di SetUp. \r\n \r\n " + 
                                    "Vuoi Scaricare ed aggiornare il programma?";

                    DialogResult dres = MessageBox.Show(msg,"Nuovo Aggiornamento",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                    if (dres == DialogResult.Yes)
                    {
                        string url = "https://github.com/MarcoDellaFara/Set-Up/releases/download/" + "v" + NewVer + "/Install-SetUp.msi";

                        //string dest = System.IO.Directory.GetCurrentDirectory() + "\\Install-SetUp.msi";
                        string dest = @"C:\Temp" + @"\Install-SetUp.msi";
                        //string dest = @"C:\Windows\Temp";

                        //string dest = Environment.SpecialFolder.UserProfile + @"\Downloads";

                        //string dest = @GetDownloadFolderPath();

                        if (!Directory.Exists(@"C:\Temp"))
                        {
                            Directory.CreateDirectory(@"C:\Temp");
                        }

                        System.Net.WebClient myWeb = new System.Net.WebClient();
                        myWeb.DownloadFileCompleted += Web_DownloadFileCompleted;
                        myWeb.DownloadFileAsync(new Uri(url), dest);
                    }
                }
                else
                {
                    if (cfg.Read("appSettings", "View_LastNews") == "True")
                    {
                        frmLastNews frm = new frmLastNews();
                        frm.lblVer.Text = LocalVer;
                        frm.Show();

                        while (frm.Visible)
                        {
                            Application.DoEvents();
                        }
                        cfg.Write("appSettings", "View_LastNews", frm.chkEnableViewLastNews.Checked.ToString());
                    }
                }
            }

            Resfresh_StatusCom();

        }

        //private static string GetHomePath()
        //{
        //    // Not in .NET 2.0
        //    // System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        //    if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
        //        return System.Environment.GetEnvironmentVariable("HOME");

        //    return System.Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
        //}


        //private static string GetDownloadFolderPath()
        //{
        //    if (System.Environment.OSVersion.Platform == System.PlatformID.Unix)
        //    {
        //        string pathDownload = System.IO.Path.Combine(GetHomePath(), "Downloads");
        //        return pathDownload;
        //    }

        //    return System.Convert.ToString(
        //        Microsoft.Win32.Registry.GetValue(
        //             @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders"
        //            , "{374DE290-123F-4565-9164-39C4925E467B}"
        //            , String.Empty
        //        )
        //    );
        //}

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            //string path = System.IO.Directory.GetCurrentDirectory() + "\\Install-SetUp.msi";
            string path = @"C:\Temp" + @"\Install-SetUp.msi";
            //string path = @"C:\Windows\Temp";
            //String path = Environment.SpecialFolder.UserProfile + @"\Downloads";

            //string path = GetDownloadFolderPath() + "\\Install -SetUp.msi";

            System.Diagnostics.Process.Start(path);
            System.Threading.Thread.Sleep(1000);
            this.Close();
        }

        private string get_NewVersion()
        {
            try
            {
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.Load("https://github.com/MarcoDellaFara/Set-Up/releases.atom");
                System.Xml.XmlNodeList nodes = doc.GetElementsByTagName("id");
                if (nodes.Count < 2)
                {
                    return "";
                }
                else
                {
                    string[] str = nodes[1].InnerText.Split('/');
                    string result = str[2].Substring(1);
                    return result;
                }
            }
            catch
            {
                return "@NoConnect";
            }
        }

        private bool Resfresh_StatusCom()
        {
            bool res = false;

            if (frmCON.Status)
            {
                tstlbl1.Text = frmCON.ComName;
                tstlbl1.BackColor = Color.Lime;

                res = true;

                clearBuffer();
            }
            else
            {
                tstlbl1.Text = "COM?";
                tstlbl1.BackColor = Color.FromArgb(255,240,240,240);

                MessageBox.Show("Collegamento Assente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return res;
        }

        int RxCount = 0;
        byte[] buf = new byte[16];
        string[] chr = { " ","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!Resfresh_StatusCom()) { return; }

            frmCON.SerialPort.Write("SetUpR");
            Thread.Sleep(1000);
            RxCount = frmCON.SerialPort.BytesToRead;
            frmCON.SerialPort.Read(buf, 0, RxCount);

            if (RxCount == 14)
            {

                if ((buf[0] & 1) == 1)
                { chkKillerPoint.Checked = true; }
                else
                { chkKillerPoint.Checked = false; }

                if ((buf[0] & 2) == 2)
                { chkEnableBuzzer.Checked = true; }
                else
                { chkEnableBuzzer.Checked = false; }

                if ((buf[0] & 4) == 4)
                { chkExtraTieBreak.Checked = true; }
                else
                { chkExtraTieBreak.Checked = false; }

                if ((buf[0] & 8) == 8)
                { chkNameEnable.Checked = true; }
                else
                { chkNameEnable.Checked = false; }

                trbBrightness.Value = buf[1] / 10;

                txtNameA.Text = chr[buf[2]] + chr[buf[3]] + chr[buf[4]];
                txtNameB.Text = chr[buf[5]] + chr[buf[6]] + chr[buf[7]];

                nudN_Set.Value = buf[8];
                nudSetLimit.Value = buf[9];

                nudLimitTieBreak.Value = buf[10];
                nudLimitTieBreakExtra.Value = buf[11];

                btnWrite.Enabled = true;
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (!Resfresh_StatusCom()) { return; }

            buf[0] = 0;
            if(chkKillerPoint.Checked) { buf[0] += 1; }
            if(chkEnableBuzzer.Checked) { buf[0] += 2; }
            if(chkExtraTieBreak.Checked) { buf[0] += 4; }
            if(chkNameEnable.Checked) { buf[0] += 8; }

            buf[1] = (byte)(trbBrightness.Value * 10);

            txtNameA.Text += "   ";

            byte[] b = Encoding.ASCII.GetBytes(txtNameA.Text);

            if (b[0] <= 32) { b[0] = 64; }
            if (b[1] <= 32) { b[1] = 64; }
            if (b[2] <= 32) { b[2] = 64; }

            b[0] -= 64; b[1] -= 64; b[2] -= 64;

            buf[2] = b[0];
            buf[3] = b[1];
            buf[4] = b[2];

            txtNameB.Text += "   ";

            b = Encoding.ASCII.GetBytes(txtNameB.Text);

            if (b[0] <= 32) { b[0] = 64; }
            if (b[1] <= 32) { b[1] = 64; }
            if (b[2] <= 32) { b[2] = 64; }

            b[0] -= 64; b[1] -= 64; b[2] -= 64;

            buf[5] = b[0];
            buf[6] = b[1];
            buf[7] = b[2];

            buf[8] = (byte)nudN_Set.Value;
            buf[9] = (byte)nudSetLimit.Value;
            buf[10] = (byte)nudLimitTieBreak.Value;
            buf[11] = (byte)nudLimitTieBreakExtra.Value;

            buf[12] = 0;
            buf[14] = 0;

            frmCON.SerialPort.Write("SetUpW");
            frmCON.SerialPort.Write(buf, 0, 13);
        }

        private void TimeSet()
        {
            clearBuffer();

            //.year = 00,
            // .month = Ds1302::MONTH_JAN,
            // .day = 1,
            // .hour = 00,
            // .minute = 00,
            // .second = 00,
            // .dow = Ds1302::DOW_MON

            var LDT = DateTime.Now;

            buf[0] = 0; //(byte)LDT.Year;
            buf[1] = 0; // (byte)LDT.Month;
            buf[2] = 0; // (byte)LDT.Day;
            buf[3] = (byte)LDT.Hour;
            buf[4] = (byte)LDT.Minute;
            buf[5] = (byte)LDT.Second;
            buf[6] = 0; //(byte)LDT.DayOfWeek;

            frmCON.SerialPort.Write("TimeSet");
            frmCON.SerialPort.Write(buf, 0, 7);

        }

        private void txtNameA_TextChanged(object sender, EventArgs e)
        {
            txtNameA.Text = txtNameA.Text.ToUpper();

            if (txtNameA.TextLength > 3)
            {
                txtNameA.Text = txtNameA.Text.Substring(0, 3);
            }

            txtNameA.SelectionStart = txtNameA.Text.Length;
        }

        private void txtNameB_TextChanged(object sender, EventArgs e)
        {
            txtNameB.Text = txtNameB.Text.ToUpper();

            if (txtNameB.TextLength > 3)
            {
                txtNameB.Text = txtNameB.Text.Substring(0, 3);
            }

            txtNameB.SelectionStart = txtNameB.Text.Length;
        }

        private void txtTurnoA_MouseClick(object sender, MouseEventArgs e)
        {
            txtTurnoA.BackColor = Color.Yellow;
            txtTurnoB.BackColor = Color.White;
        }

        private void txtTurnoB_MouseClick(object sender, MouseEventArgs e)
        {
            txtTurnoA.BackColor = Color.White;
            txtTurnoB.BackColor = Color.Yellow;
        }

        private void nudN_Set_ValueChanged(object sender, EventArgs e)
        {
            if(nudN_Set.Value > 3)
            {
                chkNameEnable.Checked = false;
            }
        }

        private void chkCambioCampo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void clearBuffer()
        {
            frmCON.SerialPort.DiscardInBuffer();
            frmCON.SerialPort.DiscardOutBuffer();
        }


        private void btn_UpdateDevice_Click(object sender, EventArgs e)
        {

        }

        private void timeSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Resfresh_StatusCom()) { return; }

            TimeSet();
        }

        private void communicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCON.Show();
            while (frmCON.Visible)
            {
                Application.DoEvents();
            }

            Resfresh_StatusCom();

        }

        private void btnReadScore_Click(object sender, EventArgs e)
        {
            if (!Resfresh_StatusCom()) { return; }

            frmCON.SerialPort.Write("ScoreR");
            Thread.Sleep(1000);
            RxCount = frmCON.SerialPort.BytesToRead;
            frmCON.SerialPort.Read(buf, 0, RxCount);

            txtGameA.Text = buf[0].ToString();
            txtGameB.Text = buf[1].ToString();

            txtSetA_0.Text = buf[2].ToString();
            txtSetA_1.Text = buf[3].ToString();
            txtSetA_2.Text = buf[4].ToString();
            txtSetA_3.Text = buf[5].ToString();
            txtSetA_4.Text = buf[6].ToString();

            txtSetB_0.Text = buf[7].ToString();
            txtSetB_1.Text = buf[8].ToString();
            txtSetB_2.Text = buf[9].ToString();
            txtSetB_3.Text = buf[10].ToString();
            txtSetB_4.Text = buf[11].ToString();

            switch (buf[12])
            {
                case 0:
                    optSet0.Checked = true;
                    break;
                case 1:
                    optSet1.Checked = true;
                    break;
                case 2:
                    optSet2.Checked = true;
                    break;
                case 3:
                    optSet3.Checked = true;
                    break;
                case 4:
                    optSet4.Checked = true;
                    break;
            }

            if ((buf[13] & 2) == 2)
            {
                txtTurnoA.BackColor = Color.White;
                txtTurnoB.BackColor = Color.Yellow;
            }
            else
            {
                txtTurnoB.BackColor = Color.White;
                txtTurnoA.BackColor = Color.Yellow;
            }

            if ((buf[13] & 4) == 4)
            {
                chkCambioCampo.Checked = true;
            }
            else
            {
                chkCambioCampo.Checked = false;
            }

            btnWriteScore.Enabled = true;
        }

        private void btnWriteScore_Click(object sender, EventArgs e)
        {
            if (!Resfresh_StatusCom()) { return; }

            buf[0] = (byte)Int16.Parse(txtGameA.Text);
            buf[1] = (byte)Int16.Parse(txtGameB.Text);

            buf[2] = (byte)Int16.Parse(txtSetA_0.Text);
            buf[3] = (byte)Int16.Parse(txtSetA_1.Text);
            buf[4] = (byte)Int16.Parse(txtSetA_2.Text);
            buf[5] = (byte)Int16.Parse(txtSetA_3.Text);
            buf[6] = (byte)Int16.Parse(txtSetA_4.Text);

            buf[7] = (byte)Int16.Parse(txtSetB_0.Text);
            buf[8] = (byte)Int16.Parse(txtSetB_1.Text);
            buf[9] = (byte)Int16.Parse(txtSetB_2.Text);
            buf[10] = (byte)Int16.Parse(txtSetB_3.Text);
            buf[11] = (byte)Int16.Parse(txtSetB_4.Text);

            if (optSet0.Checked) { buf[12] = 0; }
            else if (optSet1.Checked) { buf[12] = 1; }
            else if (optSet2.Checked) { buf[12] = 2; }
            else if (optSet3.Checked) { buf[12] = 3; }
            else if (optSet4.Checked) { buf[12] = 4; }

            if (txtTurnoB.BackColor == Color.Yellow)
            {
                buf[13] |= 0b00000010;
            }
            else
            {
                buf[13] &= 0b11111101;
            }

            if (chkCambioCampo.Checked)
            {
                buf[13] |= 0b00000100;
            }
            else
            {
                buf[13] &= 0b11111011;
            }

            frmCON.SerialPort.Write("ScoreW");
            frmCON.SerialPort.Write(buf, 0, 14);

        }

        private void setLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";
            //byte[] pack = { 255, 0, 255, 255, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            byte[] pack = new byte[768 * 2];
            byte[] s_pack = new byte[32];

            if (!Resfresh_StatusCom()) { return; }

            using (OpenFileDialog ofile = new OpenFileDialog())
            {
                ofile.InitialDirectory = Application.ExecutablePath.ToString();
                ofile.Filter = "logo file (*.logo)|*.logo|All File (*.*)|*.*";
                ofile.FilterIndex = 1;
                ofile.RestoreDirectory = true;

                if (ofile.ShowDialog() == DialogResult.OK)
                {
                    filepath = ofile.FileName;
                }
                else
                {
                    return;
                }
            }

            try
            {
                //byte[] by = new byte[768 * 2];
                pack = File.ReadAllBytes(filepath);

                //using (StreamReader sr = new StreamReader(filepath))
                //{
                //    string str = sr.ReadLine();

                //    pack = str.To;
                //}

                clearBuffer();

                frmCON.SerialPort.Write("Logo_W");

                Thread.Sleep(1000);



                for (int i = 0; i < 48; i++)
                {
                    //Thread.Sleep(10);

                    Array.Copy(pack, i * 32, s_pack, 0, 32);

                    frmCON.SerialPort.Write(s_pack, 0, 32);


                    //RxCount = 0;

                    //while (RxCount == 0)
                    //{
                    //    Thread.Sleep(100);
                    //    RxCount = frmCON.SerialPort.BytesToRead;
                    //    Application.DoEvents();
                    //}

                    Thread.Sleep(50);

                    //RxCount = frmCON.SerialPort.BytesToRead;
                    //frmCON.SerialPort.Read(pack, 0, RxCount);

                }

            }
            catch
            {
                MessageBox.Show("Impossibile aprire il file.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deviceUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // For the example
            //string ex1 = Application.StartupPath;
            //string ex2 = "\\Update";

            // Use ProcessStartInfo class
            //ProcessStartInfo startInfo = new ProcessStartInfo();

            if (!Resfresh_StatusCom()) { return; }

            try
            {
                frmCON.ClosePort();

                Process process = new Process();

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.FileName = Application.StartupPath + "\\esptool.exe";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                process.StartInfo.Arguments = "-p COM3 -b 912600 write_flash 0x10000 firmware.bin";
                process.Start();

                StreamReader reader = process.StandardOutput;
                string output = reader.ReadToEnd();

                Console.WriteLine(output);

                process.WaitForExit();

                Boolean marco = output.Contains("Hash of data verified.");

                if (!marco) { throw new Exception(); }

                frmCON.OpenPort();
            }
            catch (Exception)
            {
                MessageBox.Show("Impossibile aprire il file.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Aggionramento del dispositivo Eseguito con Successo", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
