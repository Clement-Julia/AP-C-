using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AP.Forms
{
    public partial class Home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Home()
        {
            InitializeComponent();
            // accueilCustomControl1.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            BtnAccueil.BackColor = Color.FromArgb(32, 178, 170);
        }

        

        private void Home_Load(object sender, EventArgs e)
        {
            CPBhebergements.Value = 0;
            CPBhebergements.Minimum = 0;
            
        }

        private void Home_Shown(object sender, EventArgs e)
        {
            int donnee = 3;
            CPBhebergements.Maximum = donnee + 2;
            for (int i = 0; i <= donnee; i++)
            {
                Thread.Sleep(5);
                CPBhebergements.Value = i;
                CPBhebergements.Update();
            }
            CPBhebergements.Text = donnee + " Hébergement";
            if (donnee > 1)
                CPBhebergements.Text += "s";
        }

        private void BtnAccueil_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            //BtnAccueil.BackColor = Color.FromArgb(235, 247, 249);
            //accueilCustomControl1.BringToFront();
        }

        private void BtnHebergements_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHebergements.Height;
            PnlNav.Top = BtnHebergements.Top;
            //BtnHebergements.BackColor = Color.FromArgb(235, 247, 249);
            //hebergementsCustumControl1.BringToFront();
        }

        private void BtnFiscalite_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnFiscalite.Height;
            PnlNav.Top = BtnFiscalite.Top;
            openChildForm(new Test1());
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnOptions.Height;
            PnlNav.Top = BtnOptions.Top;
            openChildForm(new test2());
        }

        private void BtnAccueil_Leave(object sender, EventArgs e)
        {
            BtnAccueil.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnHebergements_Leave(object sender, EventArgs e)
        {
            BtnHebergements.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnFiscalite_Leave(object sender, EventArgs e)
        {
            BtnFiscalite.BackColor = Color.FromArgb(32, 178, 170);
        }

        private void BtnOptions_Leave(object sender, EventArgs e)
        {
            BtnOptions.BackColor = Color.FromArgb(32, 178, 170);
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelAccueil.Controls.Add(childForm);
            PanelAccueil.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.LightSeaGreen, 15),
                            this.DisplayRectangle);
        }
    }
}
