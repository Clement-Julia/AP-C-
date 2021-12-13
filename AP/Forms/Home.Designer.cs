﻿
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
            this.PnlNav = new System.Windows.Forms.Panel();
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnFiscalite = new System.Windows.Forms.Button();
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
            this.BtnTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.BtnTest);
            this.panel1.Controls.Add(this.PnlNav);
            this.panel1.Controls.Add(this.BtnOptions);
            this.panel1.Controls.Add(this.BtnFiscalite);
            this.panel1.Controls.Add(this.BtnHebergements);
            this.panel1.Controls.Add(this.BtnAccueil);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 500);
            this.panel1.TabIndex = 0;
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
            // BtnFiscalite
            // 
            this.BtnFiscalite.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnFiscalite.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFiscalite.FlatAppearance.BorderSize = 0;
            this.BtnFiscalite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiscalite.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiscalite.ForeColor = System.Drawing.Color.White;
            this.BtnFiscalite.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiscalite.Image")));
            this.BtnFiscalite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnFiscalite.Location = new System.Drawing.Point(0, 218);
            this.BtnFiscalite.Name = "BtnFiscalite";
            this.BtnFiscalite.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnFiscalite.Size = new System.Drawing.Size(200, 45);
            this.BtnFiscalite.TabIndex = 4;
            this.BtnFiscalite.Text = "Fiscalité";
            this.BtnFiscalite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFiscalite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFiscalite.UseVisualStyleBackColor = false;
            this.BtnFiscalite.Click += new System.EventHandler(this.BtnFiscalite_Click);
            this.BtnFiscalite.Leave += new System.EventHandler(this.BtnFiscalite_Leave);
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
            this.BtnHebergements.Click += new System.EventHandler(this.BtnHebergements_Click);
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
            // BtnTest
            // 
            this.BtnTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnTest.FlatAppearance.BorderSize = 0;
            this.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTest.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTest.ForeColor = System.Drawing.Color.White;
            this.BtnTest.Image = ((System.Drawing.Image)(resources.GetObject("BtnTest.Image")));
            this.BtnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTest.Location = new System.Drawing.Point(0, 263);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnTest.Size = new System.Drawing.Size(200, 45);
            this.BtnTest.TabIndex = 8;
            this.BtnTest.Text = "+ Hébergement";
            this.BtnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTest.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
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
        private System.Windows.Forms.Button BtnFiscalite;
        private System.Windows.Forms.Panel PnlNav;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AccueilCustomControl accueilCustomControl1;
        private HebergementsCustumControl hebergementsCustumControl1;
        private System.Windows.Forms.Panel PanelAccueil;
        private System.Windows.Forms.Label LabelMembreDepuis;
        private System.Windows.Forms.Label LabelUserName;
        private System.Windows.Forms.Button BtnTest;
    }
}