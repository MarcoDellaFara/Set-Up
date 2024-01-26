using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
namespace SetUp
{
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        Label[,] lblPixel = new Label[32, 24];
        Bitmap my_bitmap;

        private void frmEditor_Load(object sender, EventArgs e)
        {
            for (int Y = 0; Y < 24; Y++)
            {
                for (int X = 0; X < 32; X++)
                {
                    lblPixel[X, Y] = new Label();
                    //lblPixel[X, Y].BackColor = Color.Black;
                    //lblPixel[X,Y].AutoSize = true;
                    lblPixel[X, Y].Location = new Point((X * 18) + 18, (Y * 18) + 18);
                    //lblPixel[X, Y].Name = "Pixel-" + X.ToString() + "-" + Y.ToString();
                    lblPixel[X, Y].Size = new System.Drawing.Size(10, 10);
                    lblPixel[X, Y].Text = " ";
                    panel1.Controls.Add(lblPixel[X, Y]);
                }
            }
        }

        private void importJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";
            byte[] pack = new byte[768 * 2];

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

            my_bitmap = new Bitmap(filepath);

            for (int Y = 0; Y < 24; Y++)
            {
                for (int X = 0; X < 32; X++)
                {
                    lblPixel[X, Y].BackColor = my_bitmap.GetPixel(X, Y);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "";
            byte[] pack = new byte[768 * 2];

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

                pack = File.ReadAllBytes(filepath);

                int i = 0;
                for (int Y = 0; Y < 24; Y++)
                {
                    for (int X = 0; X < 32; X++)
                    {

                        ushort s_pack = (ushort)((pack[i]) + (pack[i + 1] * 0x100));

                        char r = (char)((s_pack >> 11) * 8.24);
                        char g = (char)(((s_pack >> 5) & 0b111111) * 4.05);
                        char b = (char)((s_pack & 0b11111) * 8.24);

                        lblPixel[X, Y].BackColor = Color.FromArgb(r, g, b);

                        i += 2;
                    }
                }
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string filepath = "";
            byte[] pack = new byte[768 * 2];

            using (SaveFileDialog ofile = new SaveFileDialog())
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

            UInt16[] s_pack = new UInt16[32 * 24];

            int i = 0;
            for (int Y = 0; Y < 24; Y++)
            {
                for (int X = 0; X < 32; X++)
                {
                    Color cpx = my_bitmap.GetPixel(X, Y);

                    char red = (char)cpx.R;
                    char green = (char)cpx.G;
                    char blue = (char)cpx.B;

                    //blue = (char)0;
                    //red = (char)0;
                    //green = (char)0xFF;

                    UInt16 b = (char)((blue >> 3) & 0x1f);
                    UInt16 g = (char)(((green >> 2) & 0x3f) << 5);
                    UInt16 r = (char)(((red >> 3) & 0x1f) << 11);

                    s_pack[i] = (UInt16)(r | g | b);

                    i++;
                }
            }

            Buffer.BlockCopy(s_pack, 0, pack, 0, 32 * 24 * 2);

            File.WriteAllBytes(filepath, pack);
        }
        private void frmEditor_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            panel1.Visible = true;
        }
    }
}
