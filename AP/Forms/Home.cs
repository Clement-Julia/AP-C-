using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AP.Model;

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

        private Utilisateur _utilisateur;
        public Utilisateur Utilisateur { get { return _utilisateur; } set { _utilisateur = value ;} }

        private Form activeForm = null;

        public Home(Utilisateur utilisateur)
        {
            InitializeComponent();
            this.Utilisateur = utilisateur;
            // On masque les sous menus
            panelFiscaliteSubmenu.Visible = false;
            panelHebergementSubmenu.Visible = false;
            // Fonction pour arrondir les bords du Form principal
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            // PnlNav = Bordure blanche indiquant la sélection d'un bouton
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            BtnAccueil.BackColor = Color.FromArgb(32, 178, 170);

            LabelUserName.Text = Utilisateur.Nom + " " + Utilisateur.Prenom;
            LabelMembreDepuis.Text = "Membre depuis " + Utilisateur.DateAcceptRGPD.ToShortDateString();

            openChildForm(new FormAccueil(utilisateur));
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

        // ACCUEIL
        private void Accueil_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            PnlNav.Height = BtnAccueil.Height;
            PnlNav.Top = BtnAccueil.Top;
            PnlNav.Left = BtnAccueil.Left;
            openChildForm(new FormAccueil(Utilisateur));
        }

        // HEBERGEMENT
        private void OpenHebergementSubMenu(object sender, EventArgs e)
        {
            ShowSubmenu(panelHebergementSubmenu);
            PnlNav.Height = BtnHebergements.Height;
            PnlNav.Top = BtnHebergements.Top;
        }
        private void AjoutHebergement_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHebergements.Height;
            PnlNav.Top = BtnHebergements.Top;
            openChildForm(new AjoutHebergement(Utilisateur));
        }

        private void VoirHebergements_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnHebergements.Height;
            PnlNav.Top = BtnHebergements.Top;
            openChildForm(new FormHebergements(Utilisateur));
        }

        // FISCALITE
        private void OpenFiscaliteSubMenu(object sender, EventArgs e)
        {
            ShowSubmenu(panelFiscaliteSubmenu);
            PnlNav.Height = BtnFiscalite.Height;
            PnlNav.Top = BtnFiscalite.Top;
            PnlNav.BringToFront();
        }

        private void Justificatif_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnFiscalite.Height;
            PnlNav.Top = BtnFiscalite.Top;
            openChildForm(new Justificatif(Utilisateur));
        }
        private void Conseils_Click(object sender, EventArgs e)
        {
            PnlNav.Height = BtnFiscalite.Height;
            PnlNav.Top = BtnFiscalite.Top;
            openChildForm(new Conseils());
        }

        // OPTIONS / PARAMETRES
        private void Options_Click(object sender, EventArgs e)
        {
            HideSubmenu();
            PnlNav.Height = BtnOptions.Height;
            PnlNav.Top = BtnOptions.Top;
            openChildForm(new Options(Utilisateur, this));
        }

        // FONCTIONS AUTRES
        private void HideSubmenu()
        {
            if (panelFiscaliteSubmenu.Visible == true)
                panelFiscaliteSubmenu.Visible = false;
            if (panelHebergementSubmenu.Visible == true)
                panelHebergementSubmenu.Visible = false;
        }

        private void ShowSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

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

    }
}

