using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin;

namespace VokabelTrainer
{
    public partial class Menu : MaterialForm
    {
        List<Topic> list = new List<Topic>();
        Vok currentVok;
        public Menu()
        {
            InitializeComponent();
            InitializeSkin();
        }
        public void InitializeSkin()
        {
            var skinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            TabPage t = materialTabControl1.TabPages[1];
            materialTabControl1.SelectTab(t); //go to tab
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            TabPage t = materialTabControl1.TabPages[2];
            materialTabControl1.SelectTab(t); //go to tab
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            TabPage t = materialTabControl1.TabPages[0];
            materialTabControl1.SelectTab(t); //go to tab
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            TabPage t = materialTabControl1.TabPages[1];
            materialTabControl1.SelectTab(t); //go to tab
        }

        private void rbtnLight_Click(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void rbtnDark_Click(object sender, EventArgs e)
        {
            SkinManager.Theme = MaterialSkinManager.Themes.DARK;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            starteSpiel();
        }
        public void starteSpiel()
        {
            //Lese Liste ein
            csv_Import game = new csv_Import(txtPfadCSV.Text);
            list = game.import();
            
            //Wenn ein Thema ausgewält ist, gehts los
            if (comboBoxThemen.SelectedIndex != -1)
            {
                //Falls das Richtige Thema gefunden wurde, wird die Randomfunktion ausgeführt
                foreach (Topic top in list)
                {
                    if (top.ThemenID == comboBoxThemen.SelectedIndex)
                    {
                        Vok rndVok = top.Zufall();
                        currentVok = rndVok;
                        txtLang1.Text = currentVok.Deutsch;
                    }
                }

                //Reset der Form
                btnNextGame.Visible = true;
                btnMatch.Visible = true;

                thumbs(pictureBoxThumbs, -1);

                txtLang2.Text = null;

            }
            else
            {
                TabPage t = materialTabControl1.TabPages[1];
                materialTabControl1.SelectTab(t); //go to tab
                comboBoxThemen.BackColor = Color.Red;
            }
        }

        private void btnVokOpen_Click(object sender, EventArgs e)
        {
            var fileToOpen = txtPfadCSV.Text;
            var process = new System.Diagnostics.Process();
            process.StartInfo = new System.Diagnostics.ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
            process.WaitForExit();
        }

        private void btnUserOpen_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxThemen_MouseClick(object sender, MouseEventArgs e)
        {
            csv_Import csv = new csv_Import(txtPfadCSV.Text);
            List<Topic> list = csv.import();
            comboBoxThemen.Items.Clear();
            foreach (Topic topic in list)
            {
                comboBoxThemen.Items.Add(topic.Name);
            }
            comboBoxThemen.BackColor = Color.White;
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            if (currentVok.Fremdsprache.Equals(txtLang2.Text))
            {
                thumbs(pictureBoxThumbs, 1);
                btnNextGame.Visible = true;
            }
            else
            {
                thumbs(pictureBoxThumbs, 0);
                btnCorrectAnswer.Visible = true;
                btnNextGame.Visible = true;
            }
        }
        private void thumbs(PictureBox p, int index)
        {
            string pfadthumbsUp = @"C:\Users\Felix\Documents\GitHub\Vokabeltrainer\VokabelTrainer\pictures\thumbsup.png";
            string pfadthumbsDown = @"C:\Users\Felix\Documents\GitHub\Vokabeltrainer\VokabelTrainer\pictures\thumbsdown.png";
            //pictureBoxThumbs.SizeMode = PictureBoxSizeMode.StretchImage;
            switch (index)
            {
                case 1:
                    p.Image = Image.FromFile(pfadthumbsUp);
                    break;
                case 0:
                    p.Image = Image.FromFile(pfadthumbsDown);
                    break;
                case -1:
                    p.Image = null;
                    break;
            }
        }

        private void btnCorrectAnswer_Click(object sender, EventArgs e)
        {
            txtLang2.Text = currentVok.Fremdsprache;
        }

        private void btnNextGame_Click(object sender, EventArgs e)
        {
            btnCorrectAnswer.Visible = false;
            btnNextGame.Visible = false;
            starteSpiel();
        }
    }
}
