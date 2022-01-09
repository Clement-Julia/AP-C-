
namespace AP.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelFiscaliteSubmenu = new System.Windows.Forms.Panel();
            this.BtnConseils = new System.Windows.Forms.Button();
            this.BtnJustificatif = new System.Windows.Forms.Button();
            this.BtnFiscalite = new System.Windows.Forms.Button();
            this.panelHebergementSubmenu = new System.Windows.Forms.Panel();
            this.BtnAjoutHebergement = new System.Windows.Forms.Button();
            this.BtnVoirHebergement = new System.Windows.Forms.Button();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnHebergements = new System.Windows.Forms.Button();
            this.BtnAccueil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LabelMembreDepuis = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelAccueil = new System.Windows.Forms.Panel();
            this.hebergementsCustumControl1 = new AP.Forms.HebergementsCustumControl();
            this.accueilCustomControl1 = new AP.Forms.AccueilCustomControl();
            this.panel1.SuspendLayout();
            this.panelFiscaliteSubmenu.SuspendLayout();
            this.panelHebergementSubmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.panelFiscaliteSubmenu);
            this.panel1.Controls.Add(this.BtnFiscalite);
            this.panel1.Controls.Add(this.panelHebergementSubmenu);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnOptions);
            this.panel1.Controls.Add(this.BtnHebergements);
            this.panel1.Controls.Add(this.BtnAccueil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
            // 
            // panelFiscaliteSubmenu
            // 
            this.panelFiscaliteSubmenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelFiscaliteSubmenu.Controls.Add(this.BtnConseils);
            this.panelFiscaliteSubmenu.Controls.Add(this.BtnJustificatif);
            this.panelFiscaliteSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiscaliteSubmenu.Location = new System.Drawing.Point(0, 353);
            this.panelFiscaliteSubmenu.Name = "panelFiscaliteSubmenu";
            this.panelFiscaliteSubmenu.Size = new System.Drawing.Size(200, 90);
            this.panelFiscaliteSubmenu.TabIndex = 11;
            // 
            // BtnConseils
            // 
            this.BtnConseils.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BtnConseils.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConseils.FlatAppearance.BorderSize = 0;
            this.BtnConseils.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConseils.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConseils.ForeColor = System.Drawing.Color.White;
            this.BtnConseils.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConseils.Location = new System.Drawing.Point(0, 45);
            this.BtnConseils.Name = "BtnConseils";
            this.BtnConseils.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnConseils.Size = new System.Drawing.Size(200, 45);
            this.BtnConseils.TabIndex = 11;
            this.BtnConseils.Text = "Conseils";
            this.BtnConseils.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConseils.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnConseils.UseVisualStyleBackColor = false;
            this.BtnConseils.Click += new System.EventHandler(this.BtnConseils_Click);
            // 
            // BtnJustificatif
            // 
            this.BtnJustificatif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BtnJustificatif.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnJustificatif.FlatAppearance.BorderSize = 0;
            this.BtnJustificatif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnJustificatif.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnJustificatif.ForeColor = System.Drawing.Color.White;
            this.BtnJustificatif.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnJustificatif.Location = new System.Drawing.Point(0, 0);
            this.BtnJustificatif.Name = "BtnJustificatif";
            this.BtnJustificatif.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnJustificatif.Size = new System.Drawing.Size(200, 45);
            this.BtnJustificatif.TabIndex = 10;
            this.BtnJustificatif.Text = "Justificatif";
            this.BtnJustificatif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnJustificatif.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnJustificatif.UseVisualStyleBackColor = false;
            this.BtnJustificatif.Click += new System.EventHandler(this.BtnFiscalite_Click);
            // 
            // BtnFiscalite
            // 
            this.BtnFiscalite.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFiscalite.FlatAppearance.BorderSize = 0;
            this.BtnFiscalite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiscalite.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiscalite.ForeColor = System.Drawing.Color.White;
            this.BtnFiscalite.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiscalite.Image")));
            this.BtnFiscalite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiscalite.Location = new System.Drawing.Point(0, 308);
            this.BtnFiscalite.Name = "BtnFiscalite";
            this.BtnFiscalite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnFiscalite.Size = new System.Drawing.Size(200, 45);
            this.BtnFiscalite.TabIndex = 10;
            this.BtnFiscalite.Text = "Fiscalité";
            this.BtnFiscalite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFiscalite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFiscalite.UseVisualStyleBackColor = true;
            this.BtnFiscalite.Click += new System.EventHandler(this.BtnFiscalite_Click_1);
            this.BtnFiscalite.Leave += new System.EventHandler(this.BtnFiscalite_Leave);
            // 
            // panelHebergementSubmenu
            // 
            this.panelHebergementSubmenu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panelHebergementSubmenu.Controls.Add(this.BtnAjoutHebergement);
            this.panelHebergementSubmenu.Controls.Add(this.BtnVoirHebergement);
            this.panelHebergementSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHebergementSubmenu.Location = new System.Drawing.Point(0, 218);
            this.panelHebergementSubmenu.Name = "panelHebergementSubmenu";
            this.panelHebergementSubmenu.Size = new System.Drawing.Size(200, 90);
            this.panelHebergementSubmenu.TabIndex = 9;
            // 
            // BtnAjoutHebergement
            // 
            this.BtnAjoutHebergement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BtnAjoutHebergement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAjoutHebergement.FlatAppearance.BorderSize = 0;
            this.BtnAjoutHebergement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAjoutHebergement.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjoutHebergement.ForeColor = System.Drawing.Color.White;
            this.BtnAjoutHebergement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAjoutHebergement.Location = new System.Drawing.Point(0, 45);
            this.BtnAjoutHebergement.Name = "BtnAjoutHebergement";
            this.BtnAjoutHebergement.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnAjoutHebergement.Size = new System.Drawing.Size(200, 45);
            this.BtnAjoutHebergement.TabIndex = 9;
            this.BtnAjoutHebergement.Text = "Ajouter";
            this.BtnAjoutHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAjoutHebergement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAjoutHebergement.UseVisualStyleBackColor = false;
            this.BtnAjoutHebergement.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnVoirHebergement
            // 
            this.BtnVoirHebergement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BtnVoirHebergement.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVoirHebergement.FlatAppearance.BorderSize = 0;
            this.BtnVoirHebergement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVoirHebergement.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoirHebergement.ForeColor = System.Drawing.Color.White;
            this.BtnVoirHebergement.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnVoirHebergement.Location = new System.Drawing.Point(0, 0);
            this.BtnVoirHebergement.Name = "BtnVoirHebergement";
            this.BtnVoirHebergement.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.BtnVoirHebergement.Size = new System.Drawing.Size(200, 45);
            this.BtnVoirHebergement.TabIndex = 8;
            this.BtnVoirHebergement.Text = "Voir";
            this.BtnVoirHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVoirHebergement.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnVoirHebergement.UseVisualStyleBackColor = false;
            this.BtnVoirHebergement.Click += new System.EventHandler(this.BtnHebergements_Click);
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.White;
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 7;
            // 
            // BtnOptions
            // 
            this.BtnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnOptions.FlatAppearance.BorderSize = 0;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptions.ForeColor = System.Drawing.Color.White;
            this.BtnOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOptions.Image")));
            this.BtnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnOptions.Location = new System.Drawing.Point(0, 457);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnOptions.Size = new System.Drawing.Size(200, 43);
            this.BtnOptions.TabIndex = 6;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            this.BtnOptions.Leave += new System.EventHandler(this.BtnOptions_Leave);
            // 
            // BtnHebergements
            // 
            this.BtnHebergements.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHebergements.FlatAppearance.BorderSize = 0;
            this.BtnHebergements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHebergements.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHebergements.ForeColor = System.Drawing.Color.White;
            this.BtnHebergements.Image = ((System.Drawing.Image)(resources.GetObject("BtnHebergements.Image")));
            this.BtnHebergements.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnHebergements.Location = new System.Drawing.Point(0, 173);
            this.BtnHebergements.Name = "BtnHebergements";
            this.BtnHebergements.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnHebergements.Size = new System.Drawing.Size(200, 45);
            this.BtnHebergements.TabIndex = 3;
            this.BtnHebergements.Text = "Hébergements";
            this.BtnHebergements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnHebergements.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnHebergements.UseVisualStyleBackColor = true;
            this.BtnHebergements.Click += new System.EventHandler(this.BtnHebergements_Click_1);
            this.BtnHebergements.Leave += new System.EventHandler(this.BtnHebergements_Leave);
            // 
            // BtnAccueil
            // 
            this.BtnAccueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAccueil.FlatAppearance.BorderSize = 0;
            this.BtnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAccueil.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccueil.ForeColor = System.Drawing.Color.White;
            this.BtnAccueil.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccueil.Image")));
            this.BtnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAccueil.Location = new System.Drawing.Point(0, 128);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnAccueil.Size = new System.Drawing.Size(200, 45);
            this.BtnAccueil.TabIndex = 2;
            this.BtnAccueil.Text = "Accueil";
            this.BtnAccueil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAccueil.UseVisualStyleBackColor = true;
            this.BtnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            this.BtnAccueil.Leave += new System.EventHandler(this.BtnAccueil_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LabelMembreDepuis);
            this.panel2.Controls.Add(this.LabelUserName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 128);
            this.panel2.TabIndex = 1;
            // 
            // LabelMembreDepuis
            // 
            this.LabelMembreDepuis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMembreDepuis.AutoSize = true;
            this.LabelMembreDepuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMembreDepuis.Location = new System.Drawing.Point(0, 95);
            this.LabelMembreDepuis.MinimumSize = new System.Drawing.Size(200, 0);
            this.LabelMembreDepuis.Name = "LabelMembreDepuis";
            this.LabelMembreDepuis.Size = new System.Drawing.Size(200, 15);
            this.LabelMembreDepuis.TabIndex = 3;
            this.LabelMembreDepuis.Text = "Membre depuis le 12-02-2015";
            this.LabelMembreDepuis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelUserName
            // 
            this.LabelUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserName.Location = new System.Drawing.Point(0, 75);
            this.LabelUserName.MinimumSize = new System.Drawing.Size(200, 0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(200, 20);
            this.LabelUserName.TabIndex = 2;
            this.LabelUserName.Text = "Username";
            this.LabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelAccueil
            // 
            this.PanelAccueil.AutoScroll = true;
            this.PanelAccueil.BackColor = System.Drawing.Color.White;
            this.PanelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAccueil.Location = new System.Drawing.Point(200, 0);
            this.PanelAccueil.Name = "PanelAccueil";
            this.PanelAccueil.Size = new System.Drawing.Size(750, 500);
            this.PanelAccueil.TabIndex = 3;
            // 
            // hebergementsCustumControl1
            // 
            this.hebergementsCustumControl1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hebergementsCustumControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hebergementsCustumControl1.FormHeber = null;
            this.hebergementsCustumControl1.Hebergement = null;
            this.hebergementsCustumControl1.Location = new System.Drawing.Point(200, 0);
            this.hebergementsCustumControl1.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
            this.hebergementsCustumControl1.Name = "hebergementsCustumControl1";
            this.hebergementsCustumControl1.Padding = new System.Windows.Forms.Padding(5);
            this.hebergementsCustumControl1.Size = new System.Drawing.Size(700, 500);
            this.hebergementsCustumControl1.TabIndex = 2;
            // 
            // accueilCustomControl1
            // 
            this.accueilCustomControl1.Location = new System.Drawing.Point(200, 0);
            this.accueilCustomControl1.Name = "accueilCustomControl1";
            this.accueilCustomControl1.Size = new System.Drawing.Size(700, 500);
            this.accueilCustomControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.Controls.Add(this.PanelAccueil);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panelFiscaliteSubmenu.ResumeLayout(false);
            this.panelHebergementSubmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnHebergements;
        private System.Windows.Forms.Button BtnAccueil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnOptions;
        private System.Windows.Forms.Panel PnlNav;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AccueilCustomControl accueilCustomControl1;
        private HebergementsCustumControl hebergementsCustumControl1;
        private System.Windows.Forms.Panel PanelAccueil;
        private System.Windows.Forms.Label LabelMembreDepuis;
        public System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Button BtnVoirHebergement;
        private System.Windows.Forms.Button BtnFiscalite;
        private System.Windows.Forms.Panel panelHebergementSubmenu;
        private System.Windows.Forms.Button BtnAjoutHebergement;
        private System.Windows.Forms.Panel panelFiscaliteSubmenu;
        private System.Windows.Forms.Button BtnConseils;
        private System.Windows.Forms.Button BtnJustificatif;
    }
}