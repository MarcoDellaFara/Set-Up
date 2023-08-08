using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formTestFileConfig
{
    public partial class formTestFileConfig : Form
    {
        FileConfig cfg = new FileConfig();

        public formTestFileConfig()
        {
            InitializeComponent();
         }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFilePath.Text = cfg.LocalPath;
            txtFileName.Text = cfg.NameFile;
            txtNameSession.Text = cfg.Session;
            txtNameKey.Text = cfg.Key;
            txtValue.Text = cfg.Value;
        }

        private void btnWriteProperty_Click(object sender, EventArgs e)
        {
            cfg.LocalPath = txtFilePath.Text;
            cfg.NameFile = txtFileName.Text;
            cfg.Session = txtNameSession.Text;
            cfg.Key = txtNameKey.Text;
            cfg.Value = txtValue.Text;
        }

        private void btnReadPropersty_Click(object sender, EventArgs e)
        {
            txtFilePath.Text = cfg.LocalPath;
            txtFileName.Text = cfg.NameFile;
            txtNameSession.Text = cfg.Session;
            txtNameKey.Text = cfg.Key;
            txtValue.Text = cfg.Value;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtValue.Text = cfg.Read();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            cfg.Write();
        }
    }
}
