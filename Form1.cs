using System;
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

namespace SetUp
{

    public partial class Form1 : Form
    {


        //struct marco {

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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string Ver = Application.ProductVersion.Substring(0, 5);
            string VerCompile = Application.ProductVersion.Substring(6);

            this.Text = this.Text + Ver + " (" + VerCompile + ")";

            Resfresh_StatusCom();
        }

        private void Resfresh_StatusCom()
        {
            if (frmCON.Status)
            {
                tstlbl1.Text = frmCON.ComName;
                tstlbl1.BackColor = Color.Lime;
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            frmCON.Show();
            while (frmCON.Visible)
            {
                Application.DoEvents();
            }
            Resfresh_StatusCom();
        }

        int RxCount = 0;
        byte[] buf = new byte[16];
        string[] chr = { " ","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

        private void btnRead_Click(object sender, EventArgs e)
        {
            frmCON.SerialPort.Write("SetUpR");
            Thread.Sleep(1000);
            RxCount = frmCON.SerialPort.BytesToRead;
            frmCON.SerialPort.Read(buf, 0, RxCount);

            if((buf[0] & 1) == 1)
            {chkKillerPoint.Checked = true;}
            else
            {chkKillerPoint.Checked = false;}

            if ((buf[0] & 2) == 2)
            { chkEnableBuzzer.Checked = true; }
            else
            { chkEnableBuzzer.Checked = false; }

            if ((buf[0] & 4) == 4)
            { chkExtraTieBreak.Checked = true; }
            else
            { chkExtraTieBreak.Checked = false; }

            trbBrightness.Value = buf[1] / 10;

            txtNameA.Text = chr[buf[2]] + chr[buf[3]] + chr[buf[4]];
            txtNameB.Text = chr[buf[5]] + chr[buf[6]] + chr[buf[7]];

            nudN_Set.Value = buf[8];
            nudSetLimit.Value = buf[9];

            nudLimitTieBreak.Value = buf[10];
            nudLimitTieBreakExtra.Value = buf[11];
        }

        private void btnReadScore_Click(object sender, EventArgs e)
        {
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

            switch(buf[12])
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

        }

        private void btnWriteScore_Click(object sender, EventArgs e)
        {
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

            if(txtTurnoB.BackColor == Color.Yellow)
            {
                buf[13] += 2;
            }

            frmCON.SerialPort.Write("ScoreW");
            frmCON.SerialPort.Write(buf, 0, 14);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            buf[0] = 0;
            if(chkKillerPoint.Checked) { buf[0] += 1; }
            if(chkEnableBuzzer.Checked) { buf[0] += 2; }
            if(chkExtraTieBreak.Checked) { buf[0] += 4; }

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

        private void btnTimeSet_Click(object sender, EventArgs e)
        {

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
    }
}
