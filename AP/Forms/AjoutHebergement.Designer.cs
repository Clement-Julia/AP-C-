
namespace AP.Forms
{
    partial class AjoutHebergement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutHebergement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelErreurSubmit = new System.Windows.Forms.Label();
            this.BtnValidAjoutHebergement = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.richTextBoxPrix = new System.Windows.Forms.RichTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelGeoloc = new System.Windows.Forms.Panel();
            this.panelChoixVille = new System.Windows.Forms.Panel();
            this.labelChoixVille = new System.Windows.Forms.Label();
            this.BtnRetour2 = new System.Windows.Forms.Button();
            this.BtnValiderVille = new System.Windows.Forms.Button();
            this.flowLayoutPanelChoixVille = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnRechercherCoordonnees = new System.Windows.Forms.Button();
            this.panelChoixAdresse = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnValiderAdresse = new System.Windows.Forms.Button();
            this.flowLayoutPanelChoixAdresse = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBoxAdresse = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxLongitude = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxLatitude = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCommune = new System.Windows.Forms.RichTextBox();
            this.comboBoxCommune = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxNomHebergement = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGeoloc.SuspendLayout();
            this.panelChoixVille.SuspendLayout();
            this.panelChoixAdresse.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelErreurSubmit);
            this.panel1.Controls.Add(this.BtnValidAjoutHebergement);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 657);
            this.panel1.TabIndex = 0;
            // 
            // labelErreurSubmit
            // 
            this.labelErreurSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelErreurSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErreurSubmit.Location = new System.Drawing.Point(10, 575);
            this.labelErreurSubmit.Name = "labelErreurSubmit";
            this.labelErreurSubmit.Size = new System.Drawing.Size(705, 31);
            this.labelErreurSubmit.TabIndex = 3;
            this.labelErreurSubmit.Text = "La demande d\'ajout de l\'hébergement n\'a pas pu aboutir. Veuillez vérifier les inf" +
    "ormations.";
            this.labelErreurSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnValidAjoutHebergement
            // 
            this.BtnValidAjoutHebergement.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnValidAjoutHebergement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValidAjoutHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidAjoutHebergement.ForeColor = System.Drawing.Color.White;
            this.BtnValidAjoutHebergement.Location = new System.Drawing.Point(10, 609);
            this.BtnValidAjoutHebergement.Name = "BtnValidAjoutHebergement";
            this.BtnValidAjoutHebergement.Size = new System.Drawing.Size(705, 40);
            this.BtnValidAjoutHebergement.TabIndex = 9;
            this.BtnValidAjoutHebergement.Text = "Soumettre l\'hébergement à l\'admin";
            this.BtnValidAjoutHebergement.UseVisualStyleBackColor = false;
            this.BtnValidAjoutHebergement.Click += new System.EventHandler(this.BtnValidHebergement_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 40);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ajout d\'un hébergement";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(355, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 512);
            this.panel3.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Location = new System.Drawing.Point(10, 382);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(340, 108);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.richTextBoxPrix);
            this.panel7.Location = new System.Drawing.Point(10, 276);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(340, 100);
            this.panel7.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(295, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 38);
            this.label10.TabIndex = 3;
            this.label10.Text = "€";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(320, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Prix par nuit";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxPrix
            // 
            this.richTextBoxPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxPrix.Location = new System.Drawing.Point(10, 45);
            this.richTextBoxPrix.Name = "richTextBoxPrix";
            this.richTextBoxPrix.Size = new System.Drawing.Size(279, 38);
            this.richTextBoxPrix.TabIndex = 1;
            this.richTextBoxPrix.Text = "";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel6.Controls.Add(this.labelDescription);
            this.panel6.Controls.Add(this.richTextBoxDescription);
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(340, 260);
            this.panel6.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(10, 10);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(320, 25);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(10, 45);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(320, 206);
            this.richTextBoxDescription.TabIndex = 1;
            this.richTextBoxDescription.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.panelGeoloc);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(10, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 512);
            this.panel2.TabIndex = 4;
            // 
            // panelGeoloc
            // 
            this.panelGeoloc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panelGeoloc.Controls.Add(this.panelChoixVille);
            this.panelGeoloc.Controls.Add(this.BtnRechercherCoordonnees);
            this.panelGeoloc.Controls.Add(this.panelChoixAdresse);
            this.panelGeoloc.Controls.Add(this.richTextBoxAdresse);
            this.panelGeoloc.Controls.Add(this.label7);
            this.panelGeoloc.Controls.Add(this.label6);
            this.panelGeoloc.Controls.Add(this.richTextBoxLongitude);
            this.panelGeoloc.Controls.Add(this.label5);
            this.panelGeoloc.Controls.Add(this.richTextBoxLatitude);
            this.panelGeoloc.Location = new System.Drawing.Point(10, 276);
            this.panelGeoloc.Name = "panelGeoloc";
            this.panelGeoloc.Size = new System.Drawing.Size(325, 214);
            this.panelGeoloc.TabIndex = 6;
            // 
            // panelChoixVille
            // 
            this.panelChoixVille.Controls.Add(this.labelChoixVille);
            this.panelChoixVille.Controls.Add(this.BtnRetour2);
            this.panelChoixVille.Controls.Add(this.BtnValiderVille);
            this.panelChoixVille.Controls.Add(this.flowLayoutPanelChoixVille);
            this.panelChoixVille.Location = new System.Drawing.Point(0, 0);
            this.panelChoixVille.Name = "panelChoixVille";
            this.panelChoixVille.Size = new System.Drawing.Size(325, 214);
            this.panelChoixVille.TabIndex = 9;
            // 
            // labelChoixVille
            // 
            this.labelChoixVille.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelChoixVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChoixVille.Location = new System.Drawing.Point(0, 0);
            this.labelChoixVille.Name = "labelChoixVille";
            this.labelChoixVille.Size = new System.Drawing.Size(325, 43);
            this.labelChoixVille.TabIndex = 0;
            this.labelChoixVille.Text = "Plusieurs correspondances ont été trouvées, veuillez choisir la ville qui vous co" +
    "rrespond :";
            // 
            // BtnRetour2
            // 
            this.BtnRetour2.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnRetour2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour2.ForeColor = System.Drawing.Color.White;
            this.BtnRetour2.Location = new System.Drawing.Point(170, 186);
            this.BtnRetour2.Name = "BtnRetour2";
            this.BtnRetour2.Size = new System.Drawing.Size(155, 28);
            this.BtnRetour2.TabIndex = 8;
            this.BtnRetour2.Text = "Retour";
            this.BtnRetour2.UseVisualStyleBackColor = false;
            this.BtnRetour2.Click += new System.EventHandler(this.BtnRetour2_Click);
            // 
            // BtnValiderVille
            // 
            this.BtnValiderVille.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnValiderVille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValiderVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValiderVille.ForeColor = System.Drawing.Color.White;
            this.BtnValiderVille.Location = new System.Drawing.Point(0, 186);
            this.BtnValiderVille.Name = "BtnValiderVille";
            this.BtnValiderVille.Size = new System.Drawing.Size(170, 28);
            this.BtnValiderVille.TabIndex = 7;
            this.BtnValiderVille.Text = "Valider Ville";
            this.BtnValiderVille.UseVisualStyleBackColor = false;
            this.BtnValiderVille.Click += new System.EventHandler(this.BtnValiderVille_Click);
            // 
            // flowLayoutPanelChoixVille
            // 
            this.flowLayoutPanelChoixVille.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelChoixVille.AutoScroll = true;
            this.flowLayoutPanelChoixVille.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelChoixVille.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChoixVille.Location = new System.Drawing.Point(-3, 43);
            this.flowLayoutPanelChoixVille.MaximumSize = new System.Drawing.Size(340, 140);
            this.flowLayoutPanelChoixVille.Name = "flowLayoutPanelChoixVille";
            this.flowLayoutPanelChoixVille.Size = new System.Drawing.Size(328, 140);
            this.flowLayoutPanelChoixVille.TabIndex = 0;
            // 
            // BtnRechercherCoordonnees
            // 
            this.BtnRechercherCoordonnees.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnRechercherCoordonnees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRechercherCoordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRechercherCoordonnees.ForeColor = System.Drawing.Color.White;
            this.BtnRechercherCoordonnees.Location = new System.Drawing.Point(9, 82);
            this.BtnRechercherCoordonnees.Name = "BtnRechercherCoordonnees";
            this.BtnRechercherCoordonnees.Size = new System.Drawing.Size(306, 37);
            this.BtnRechercherCoordonnees.TabIndex = 6;
            this.BtnRechercherCoordonnees.Text = "Rechercher coordonnées";
            this.BtnRechercherCoordonnees.UseVisualStyleBackColor = false;
            this.BtnRechercherCoordonnees.Click += new System.EventHandler(this.BtnRechercherCoordonnees_Click);
            // 
            // panelChoixAdresse
            // 
            this.panelChoixAdresse.Controls.Add(this.label8);
            this.panelChoixAdresse.Controls.Add(this.BtnRetour);
            this.panelChoixAdresse.Controls.Add(this.BtnValiderAdresse);
            this.panelChoixAdresse.Controls.Add(this.flowLayoutPanelChoixAdresse);
            this.panelChoixAdresse.Location = new System.Drawing.Point(0, 0);
            this.panelChoixAdresse.Name = "panelChoixAdresse";
            this.panelChoixAdresse.Size = new System.Drawing.Size(325, 214);
            this.panelChoixAdresse.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(325, 43);
            this.label8.TabIndex = 0;
            this.label8.Text = "Plusieurs correspondances ont été trouvées, veuillez choisir celle qui vous corre" +
    "spond :";
            // 
            // BtnRetour
            // 
            this.BtnRetour.BackColor = System.Drawing.Color.BurlyWood;
            this.BtnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.ForeColor = System.Drawing.Color.White;
            this.BtnRetour.Location = new System.Drawing.Point(166, 186);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(159, 28);
            this.BtnRetour.TabIndex = 8;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = false;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click);
            // 
            // BtnValiderAdresse
            // 
            this.BtnValiderAdresse.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnValiderAdresse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnValiderAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValiderAdresse.ForeColor = System.Drawing.Color.White;
            this.BtnValiderAdresse.Location = new System.Drawing.Point(0, 186);
            this.BtnValiderAdresse.Name = "BtnValiderAdresse";
            this.BtnValiderAdresse.Size = new System.Drawing.Size(164, 28);
            this.BtnValiderAdresse.TabIndex = 7;
            this.BtnValiderAdresse.Text = "Valider adresse";
            this.BtnValiderAdresse.UseVisualStyleBackColor = false;
            this.BtnValiderAdresse.Click += new System.EventHandler(this.BtnValiderAdresse_Click);
            // 
            // flowLayoutPanelChoixAdresse
            // 
            this.flowLayoutPanelChoixAdresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanelChoixAdresse.AutoScroll = true;
            this.flowLayoutPanelChoixAdresse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelChoixAdresse.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelChoixAdresse.Location = new System.Drawing.Point(0, 43);
            this.flowLayoutPanelChoixAdresse.MaximumSize = new System.Drawing.Size(325, 140);
            this.flowLayoutPanelChoixAdresse.Name = "flowLayoutPanelChoixAdresse";
            this.flowLayoutPanelChoixAdresse.Size = new System.Drawing.Size(325, 140);
            this.flowLayoutPanelChoixAdresse.TabIndex = 0;
            // 
            // richTextBoxAdresse
            // 
            this.richTextBoxAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxAdresse.Location = new System.Drawing.Point(10, 38);
            this.richTextBoxAdresse.Name = "richTextBoxAdresse";
            this.richTextBoxAdresse.Size = new System.Drawing.Size(305, 38);
            this.richTextBoxAdresse.TabIndex = 5;
            this.richTextBoxAdresse.Text = "";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Longitude";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Latitude";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxLongitude
            // 
            this.richTextBoxLongitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLongitude.Location = new System.Drawing.Point(160, 171);
            this.richTextBoxLongitude.Name = "richTextBoxLongitude";
            this.richTextBoxLongitude.Size = new System.Drawing.Size(155, 35);
            this.richTextBoxLongitude.TabIndex = 3;
            this.richTextBoxLongitude.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Adresse";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxLatitude
            // 
            this.richTextBoxLatitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLatitude.Location = new System.Drawing.Point(9, 171);
            this.richTextBoxLatitude.Name = "richTextBoxLatitude";
            this.richTextBoxLatitude.Size = new System.Drawing.Size(142, 35);
            this.richTextBoxLatitude.TabIndex = 1;
            this.richTextBoxLatitude.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.inputCommune);
            this.panel5.Controls.Add(this.comboBoxCommune);
            this.panel5.Location = new System.Drawing.Point(10, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(325, 154);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Puis sélectionner :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entrez un nom de Ville ou Code Postal";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputCommune
            // 
            this.inputCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputCommune.Location = new System.Drawing.Point(10, 37);
            this.inputCommune.Name = "inputCommune";
            this.inputCommune.Size = new System.Drawing.Size(305, 38);
            this.inputCommune.TabIndex = 3;
            this.inputCommune.Text = "";
            this.inputCommune.TextChanged += new System.EventHandler(this.inputCommune_TextChanged);
            // 
            // comboBoxCommune
            // 
            this.comboBoxCommune.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCommune.FormattingEnabled = true;
            this.comboBoxCommune.Location = new System.Drawing.Point(10, 121);
            this.comboBoxCommune.Name = "comboBoxCommune";
            this.comboBoxCommune.Size = new System.Drawing.Size(305, 24);
            this.comboBoxCommune.TabIndex = 2;
            this.comboBoxCommune.SelectedIndexChanged += new System.EventHandler(this.comboBoxCommune_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(237)))), ((int)(((byte)(234)))));
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.richTextBoxNomHebergement);
            this.panel4.Location = new System.Drawing.Point(10, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(325, 100);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de l\'hébergement";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxNomHebergement
            // 
            this.richTextBoxNomHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxNomHebergement.Location = new System.Drawing.Point(10, 45);
            this.richTextBoxNomHebergement.Name = "richTextBoxNomHebergement";
            this.richTextBoxNomHebergement.Size = new System.Drawing.Size(305, 38);
            this.richTextBoxNomHebergement.TabIndex = 1;
            this.richTextBoxNomHebergement.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AjoutHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(725, 657);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AjoutHebergement";
            this.Text = "AjoutHebergement";
            this.Load += new System.EventHandler(this.AjoutHebergement_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelGeoloc.ResumeLayout(false);
            this.panelChoixVille.ResumeLayout(false);
            this.panelChoixAdresse.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox inputCommune;
        private System.Windows.Forms.ComboBox comboBoxCommune;
        private System.Windows.Forms.RichTextBox richTextBoxNomHebergement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGeoloc;
        private System.Windows.Forms.Button BtnRechercherCoordonnees;
        private System.Windows.Forms.RichTextBox richTextBoxAdresse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxLongitude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxLatitude;
        private System.Windows.Forms.Panel panelChoixAdresse;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChoixAdresse;
        private System.Windows.Forms.Button BtnValiderAdresse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Panel panelChoixVille;
        private System.Windows.Forms.Label labelChoixVille;
        private System.Windows.Forms.Button BtnRetour2;
        private System.Windows.Forms.Button BtnValiderVille;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChoixVille;
        private System.Windows.Forms.Button BtnValidAjoutHebergement;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxPrix;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelErreurSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}