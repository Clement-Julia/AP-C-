namespace AP.Forms
{
    partial class AvisHebergement
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvisHebergement));
            this.panel1 = new System.Windows.Forms.Panel();
            this.prénom = new System.Windows.Forms.Label();
            this.link_avis = new System.Windows.Forms.LinkLabel();
            this.commentaire = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rating = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.prénom);
            this.panel1.Controls.Add(this.link_avis);
            this.panel1.Controls.Add(this.commentaire);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 97);
            this.panel1.TabIndex = 22;
            // 
            // prénom
            // 
            this.prénom.AutoSize = true;
            this.prénom.Location = new System.Drawing.Point(90, 13);
            this.prénom.Name = "prénom";
            this.prénom.Size = new System.Drawing.Size(57, 17);
            this.prénom.TabIndex = 24;
            this.prénom.Text = "Prénom";
            // 
            // link_avis
            // 
            this.link_avis.AutoSize = true;
            this.link_avis.Location = new System.Drawing.Point(317, 13);
            this.link_avis.Name = "link_avis";
            this.link_avis.Size = new System.Drawing.Size(76, 17);
            this.link_avis.TabIndex = 23;
            this.link_avis.TabStop = true;
            this.link_avis.Text = "Discussion";
            this.link_avis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_avis_LinkClicked);
            // 
            // commentaire
            // 
            this.commentaire.AutoSize = true;
            this.commentaire.Location = new System.Drawing.Point(143, 61);
            this.commentaire.Name = "commentaire";
            this.commentaire.Size = new System.Drawing.Size(90, 17);
            this.commentaire.TabIndex = 20;
            this.commentaire.Text = "Contenu avis";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Location = new System.Drawing.Point(245, 13);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(44, 17);
            this.rating.TabIndex = 21;
            this.rating.Text = "rating";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(3, 13);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(37, 17);
            this.nom.TabIndex = 20;
            this.nom.Text = "Nom";
            // 
            // AvisHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AvisHebergement";
            this.Size = new System.Drawing.Size(401, 104);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.LinkLabel link_avis;
        public System.Windows.Forms.Label commentaire;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label rating;
        public System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prénom;
    }
}
