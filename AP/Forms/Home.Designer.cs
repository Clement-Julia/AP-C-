
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelAccueil = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CPBhebergements = new CircularProgressBar.CircularProgressBar();
            this.hebergementsCustumControl1 = new AP.Forms.HebergementsCustumControl();
            this.accueilCustomControl1 = new AP.Forms.AccueilCustomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelAccueil.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
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
            this.BtnFiscalite.Size = new System.Drawing.Size(200, 45);
            this.BtnFiscalite.TabIndex = 4;
            this.BtnFiscalite.Text = "Fiscalité";
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
            this.BtnAccueil.ForeColor = System.Drawing.Color.White;
            this.BtnAccueil.Image = ((System.Drawing.Image)(resources.GetObject("BtnAccueil.Image")));
            this.BtnAccueil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 128);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Membre depuis le 12-02-2015";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelAccueil
            // 
            this.PanelAccueil.BackColor = System.Drawing.Color.White;
            this.PanelAccueil.Controls.Add(this.panel10);
            this.PanelAccueil.Controls.Add(this.panel9);
            this.PanelAccueil.Controls.Add(this.panel8);
            this.PanelAccueil.Controls.Add(this.panel6);
            this.PanelAccueil.Controls.Add(this.panel4);
            this.PanelAccueil.Controls.Add(this.panel3);
            this.PanelAccueil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAccueil.Location = new System.Drawing.Point(200, 0);
            this.PanelAccueil.Name = "PanelAccueil";
            this.PanelAccueil.Size = new System.Drawing.Size(700, 500);
            this.PanelAccueil.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Location = new System.Drawing.Point(16, 252);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(672, 75);
            this.panel10.TabIndex = 5;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(139, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(336, 30);
            this.label9.TabIndex = 1;
            this.label9.Text = "Vous totalisez 253 réservations";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(232)))), ((int)(((byte)(113)))));
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(15, 15);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Size = new System.Drawing.Size(45, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label8);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Location = new System.Drawing.Point(16, 414);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(672, 75);
            this.panel9.TabIndex = 5;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(345, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Vous avez 5 réservations à venir";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(117)))), ((int)(((byte)(244)))));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(16, 333);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(672, 75);
            this.panel8.TabIndex = 4;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(139, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(362, 30);
            this.label7.TabIndex = 1;
            this.label7.Text = "Vous avez 5 réservations en cours";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(243)))), ((int)(((byte)(154)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(15, 15);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(222, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(466, 99);
            this.panel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "453 €";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(105, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gains prévisionels :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(20, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(0, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(466, 99);
            this.panel7.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(222, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(466, 99);
            this.panel4.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(332, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "3568 €";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LimeGreen;
            this.label3.Location = new System.Drawing.Point(102, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gains  :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.PaleGreen;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 101);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(466, 99);
            this.panel5.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.CPBhebergements);
            this.panel3.Location = new System.Drawing.Point(16, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 200);
            this.panel3.TabIndex = 0;
            // 
            // CPBhebergements
            // 
            this.CPBhebergements.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPBhebergements.AnimationSpeed = 500;
            this.CPBhebergements.BackColor = System.Drawing.Color.White;
            this.CPBhebergements.Dock = System.Windows.Forms.DockStyle.Top;
            this.CPBhebergements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.CPBhebergements.ForeColor = System.Drawing.Color.Black;
            this.CPBhebergements.InnerColor = System.Drawing.Color.White;
            this.CPBhebergements.InnerMargin = 2;
            this.CPBhebergements.InnerWidth = -1;
            this.CPBhebergements.Location = new System.Drawing.Point(0, 0);
            this.CPBhebergements.MarqueeAnimationSpeed = 2000;
            this.CPBhebergements.Name = "CPBhebergements";
            this.CPBhebergements.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.CPBhebergements.OuterMargin = -25;
            this.CPBhebergements.OuterWidth = 26;
            this.CPBhebergements.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.CPBhebergements.ProgressWidth = 25;
            this.CPBhebergements.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.CPBhebergements.Size = new System.Drawing.Size(200, 200);
            this.CPBhebergements.StartAngle = 270;
            this.CPBhebergements.SubscriptColor = System.Drawing.Color.White;
            this.CPBhebergements.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPBhebergements.SubscriptText = "";
            this.CPBhebergements.SuperscriptColor = System.Drawing.Color.White;
            this.CPBhebergements.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPBhebergements.SuperscriptText = "";
            this.CPBhebergements.TabIndex = 0;
            this.CPBhebergements.Text = "1 hébergement";
            this.CPBhebergements.TextMargin = new System.Windows.Forms.Padding(0);
            this.CPBhebergements.Value = 63;
            // 
            // hebergementsCustumControl1
            // 
            this.hebergementsCustumControl1.Location = new System.Drawing.Point(200, 0);
            this.hebergementsCustumControl1.Name = "hebergementsCustumControl1";
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
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.PanelAccueil);
            this.Controls.Add(this.hebergementsCustumControl1);
            this.Controls.Add(this.accueilCustomControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Shown += new System.EventHandler(this.Home_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelAccueil.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private CircularProgressBar.CircularProgressBar CPBhebergements;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}