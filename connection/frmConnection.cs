using System;
using System.Drawing;
using System.IO.Ports;
using System.Management;
using System.Threading;
using System.Windows.Forms;


namespace connection
{
    public partial class frmConnection : Form
    {
        String[] arPortManufactory = new String[0];
        private bool _Status = false;

        public bool Status
        {
            get { return _Status; }
        }

        private string _ComName = "";

        public string strRX = "";
        public string strRX_Hex = "";
        public int NumberByteRX = 0;

        private bool F_Timer1 = false;

        public string ComName
        {
            get { return _ComName; }
        }

        public frmConnection()
        {
            InitializeComponent();

            //string str = "";
            //int i;

            RefreshPort();

        }

        public bool Write(string strTx, int TimeOut_mSec, string strRx_Check, string Error)
        {
            bool res = false;

            Timer1.Interval = TimeOut_mSec;
            Timer1.Enabled = true;
            F_Timer1 = false;
            Timer1.Start();

            strRX = "";
            strRX_Hex = "";
            NumberByteRX = 0;

            SerialPort.Write(strTx);

            while (strRX == "")
            {
                Application.DoEvents();
                Thread.Sleep(5);

                if (F_Timer1)
                {
                    throw new ArgumentException(Error + Environment.NewLine + "Tempo Limite della Risposta dalla Porta Seriale Scaduto.");
                }
            }

            if (strRX.Contains(strRx_Check))
            {
                res = true;
            }

            Timer1.Stop();

            return res;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            F_Timer1 = true;
            Timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void frmConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void btnRefresch_Click(object sender, EventArgs e)
        {
            RefreshPort();
        }
        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            FileConfig cfg = new FileConfig();

            cfg.NameFile = "App.Config";
            cfg.Session = "appSettings";

            cfg.Write("SerialPort_IsOpen", SerialPort.IsOpen.ToString());
            cfg.Write("PortName", cmbPortName.Text);
            cfg.Write("BaudRate", cmbBaudRate.Text);

        }
        void RefreshPort()
        {
            string str = "";
            int i;

            FileConfig cfg = new FileConfig();
            cfg.NameFile = "App.Config";
            cfg.Session = "appSettings";

            GetSerialPort();

            cmbPortName.Items.Clear();

            String[] ports = SerialPort.GetPortNames();
            cmbPortName.Items.AddRange(ports);

            foreach (string s in arPortManufactory)
            {
                for (i = 0; i < cmbPortName.Items.Count; i++)
                {
                    str = cmbPortName.Items[i].ToString();
                    int firstChr = s.IndexOf(" (" + str);

                    if (firstChr >= 0)
                    {
                        cmbPortName.Items[i] += " - " + s.Remove(firstChr);
                    }
                }
            }

            //leggi ed imposta le Porte salvate
            str = cfg.Read("PortName");

            for (i = 0; i < cmbPortName.Items.Count; i++)
            {
                cmbPortName.SelectedIndex = i;
                if (str == cmbPortName.Text)
                {
                    cmbPortName.SelectedIndex = i;
                    break;
                }
                else
                {
                    cmbPortName.SelectedIndex = -1;
                }
            }

            str = cfg.Read("BaudRate");
            for (i = 0; i < cmbBaudRate.Items.Count; i++)
            {
                cmbBaudRate.SelectedIndex = i;
                if (str == cmbBaudRate.Text)
                {
                    cmbBaudRate.SelectedIndex = i;
                    break;
                }
                else
                {
                    cmbBaudRate.SelectedIndex = -1;
                }
            }

            //TENTATIVO DI APERTURA COM
            if ((cmbPortName.Text == "" || cmbBaudRate.Text == "") || (cfg.Read("SerialPort_IsOpen") != "True"))
            {
                txtPortInformation.Text = "Please select Port Names end settings";
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
            }
            else
            {
                if ((!SerialPort.IsOpen) && (OpenPort()))
                {
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                }
            }
        }
        private void GetSerialPort()
        {
            try
            {
                //ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\cimv2", "SELECT * FROM Win32_PnPEntity WHERE ClassGuid=\"{4d36e978-e325-11ce-bfc1-08002be10318}\"");

                int i = 0;
                foreach (ManagementObject queryObj in searcher.Get())
                {
                    if (queryObj["Caption"].ToString().Contains("(COM"))
                    {
                        Array.Resize(ref arPortManufactory, i + 1);
                        arPortManufactory[i] = queryObj["Name"].ToString();
                        i++;
                    }
                }
                searcher.Dispose();
            }
            catch (ManagementException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        bool OpenPort()
        {
            bool res = false;

            try
            {
                if (cmbPortName.Text == "" || cmbBaudRate.Text == "")
                {
                    txtPortInformation.Text = "Please select Port Names end settings";
                }
                else
                {
                    SerialPort.PortName = cmbPortName.Text.Substring(0, 5);
                    SerialPort.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    SerialPort.Open();
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                    cmbPortName.Enabled = false;
                    cmbBaudRate.Enabled = false;
                    txtPortInformation.Text = "OPEN " + cmbPortName.Text.Substring(6);
                    txtPortInformation.BackColor = Color.Lime;
                    res = true;

                    _Status = true;
                    _ComName = SerialPort.PortName;
                }
            }
            catch (UnauthorizedAccessException)
            {
                txtPortInformation.BackColor = Color.Red;
                txtPortInformation.Text = "Unauthorized Access";

                _Status = false;
                _ComName = "";
            }

            return res;
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            SerialPort.Close();
            btnClosePort.Enabled = false;
            btnOpenPort.Enabled = true;
            cmbPortName.Enabled = true;
            cmbBaudRate.Enabled = true;
            txtPortInformation.Text = "Port Closed";
            txtPortInformation.BackColor = Color.White;

            _Status = false;
            _ComName = "";
        }

        private void cmbBaseComand_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStringSend.Text = cmbBaseComand.Text;
        }

        private void btnSEND_Click(object sender, EventArgs e)
        {
            Timer1.Interval = Int32.Parse(txtTimeOut.Text);
            Timer1.Enabled = true;
            F_Timer1 = false;
            Timer1.Start();

            strRX = "";
            strRX_Hex = "";

            txtRXData.Text = "";
            txtRXDataHex.Text = "";
            NumberByteRX = 0;

            SerialPort.Write(txtStringSend.Text + "\r");

            while (strRX == "")
            {
                Application.DoEvents();
                Thread.Sleep(5);

                if (F_Timer1) { break; }
            }

            lblNumberByte.Text = NumberByteRX.ToString();
            txtRXData.Text = strRX;
            txtRXDataHex.Text = strRX_Hex;
        }
    }
}
