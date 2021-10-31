
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
            this.BtnOptions = new System.Windows.Forms.Button();
            this.BtnFiscalite = new System.Windows.Forms.Button();
            this.BtnHebergements = new System.Windows.Forms.Button();
            this.BtnAccueil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.accueilCustomControl1 = new AP.Forms.AccueilCustomControl();
            this.hebergementsCustumControl1 = new AP.Forms.HebergementsCustumControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            // BtnOptions
            // 
            this.BtnOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnOptions.FlatAppearance.BorderSize = 0;
            this.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOptions.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnOptions.Image")));
            this.BtnOptions.Location = new System.Drawing.Point(0, 457);
            this.BtnOptions.Name = "BtnOptions";
            this.BtnOptions.Size = new System.Drawing.Size(200, 43);
            this.BtnOptions.TabIndex = 6;
            this.BtnOptions.Text = "Options";
            this.BtnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnOptions.UseVisualStyleBackColor = true;
            this.BtnOptions.Click += new System.EventHandler(this.BtnOptions_Click);
            this.BtnOptions.Leave += new System.EventHandler(this.BtnOptions_Leave);
            // 
            // BtnFiscalite
            // 
            this.BtnFiscalite.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFiscalite.FlatAppearance.BorderSize = 0;
            this.BtnFiscalite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFiscalite.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFiscalite.Image = ((System.Drawing.Image)(resources.GetObject("BtnFiscalite.Image")));
            this.BtnFiscalite.Location = new System.Drawing.Point(0, 218);
            this.BtnFiscalite.Name = "BtnFiscalite";
            this.BtnFiscalite.Size = new System.Drawing.Size(200, 45);
            this.BtnFiscalite.TabIndex = 4;
            this.BtnFiscalite.Text = "Fiscalité";
            this.BtnFiscalite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnFiscalite.UseVisualStyleBackColor = true;
            this.BtnFiscalite.Click += new System.EventHandler(this.BtnFiscalite_Click);
            this.BtnFiscalite.Leave += new System.EventHandler(this.BtnFiscalite_Leave);
            // 
            // BtnHebergements
            // 
            this.BtnHebergements.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnHebergements.FlatAppearance.BorderSize = 0;
            this.BtnHebergements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHebergements.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHebergements.Image = ((System.Drawing.Image)(resources.GetObject("BtnHebergements.Image")));
            this.BtnHebergements.Location = new System.Drawing.Point(0, 173);
            this.BtnHebergements.Name = "BtnHebergements";
            this.BtnHebergements.Size = new System.Drawing.Size(200, 45);
            this.BtnHebergements.TabIndex = 3;
            this.BtnHebergements.Text = "Hébergements";
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
            this.BtnAccueil.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccueil.Image")));
            this.BtnAccueil.Location = new System.Drawing.Point(0, 128);
            this.BtnAccueil.Name = "BtnAccueil";
            this.BtnAccueil.Size = new System.Drawing.Size(200, 45);
            this.BtnAccueil.TabIndex = 2;
            this.BtnAccueil.Text = "Accueil";
            this.BtnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAccueil.UseVisualStyleBackColor = true;
            this.BtnAccueil.Click += new System.EventHandler(this.BtnAccueil_Click);
            this.BtnAccueil.Leave += new System.EventHandler(this.BtnAccueil_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 128);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.SystemColors.Desktop;
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 7;
            // 
            // accueilCustomControl1
            // 
            this.accueilCustomControl1.Location = new System.Drawing.Point(200, 0);
            this.accueilCustomControl1.Name = "accueilCustomControl1";
            this.accueilCustomControl1.Size = new System.Drawing.Size(700, 500);
            this.accueilCustomControl1.TabIndex = 1;
            // 
            // hebergementsCustumControl1
            // 
            this.hebergementsCustumControl1.Location = new System.Drawing.Point(200, 0);
            this.hebergementsCustumControl1.Name = "hebergementsCustumControl1";
            this.hebergementsCustumControl1.Size = new System.Drawing.Size(700, 500);
            this.hebergementsCustumControl1.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.hebergementsCustumControl1);
            this.Controls.Add(this.accueilCustomControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
    }
}