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
            this.BtnReponse = new System.Windows.Forms.Button();
            this.panelNonRepondu = new System.Windows.Forms.Panel();
            this.pictureBoxNonRepondu = new System.Windows.Forms.PictureBox();
            this.labelNonRepondu = new System.Windows.Forms.Label();
            this.panelRepondu = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelRepondu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.commentaire = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rating = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelNonRepondu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNonRepondu)).BeginInit();
            this.panelRepondu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.BtnReponse);
            this.panel1.Controls.Add(this.panelNonRepondu);
            this.panel1.Controls.Add(this.panelRepondu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rating);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 154);
            this.panel1.TabIndex = 22;
            // 
            // BtnReponse
            // 
            this.BtnReponse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnReponse.FlatAppearance.BorderSize = 0;
            this.BtnReponse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReponse.Location = new System.Drawing.Point(381, 123);
            this.BtnReponse.Margin = new System.Windows.Forms.Padding(0);
            this.BtnReponse.Name = "BtnReponse";
            this.BtnReponse.Size = new System.Drawing.Size(179, 28);
            this.BtnReponse.TabIndex = 28;
            this.BtnReponse.Text = "Voir réponse";
            this.BtnReponse.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnReponse.UseVisualStyleBackColor = false;
            this.BtnReponse.Click += new System.EventHandler(this.BtnReponse_Click);
            // 
            // panelNonRepondu
            // 
            this.panelNonRepondu.Controls.Add(this.pictureBoxNonRepondu);
            this.panelNonRepondu.Controls.Add(this.labelNonRepondu);
            this.panelNonRepondu.Location = new System.Drawing.Point(427, 0);
            this.panelNonRepondu.Margin = new System.Windows.Forms.Padding(4);
            this.panelNonRepondu.Name = "panelNonRepondu";
            this.panelNonRepondu.Size = new System.Drawing.Size(133, 27);
            this.panelNonRepondu.TabIndex = 27;
            // 
            // pictureBoxNonRepondu
            // 
            this.pictureBoxNonRepondu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNonRepondu.Image")));
            this.pictureBoxNonRepondu.Location = new System.Drawing.Point(4, 2);
            this.pictureBoxNonRepondu.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxNonRepondu.Name = "pictureBoxNonRepondu";
            this.pictureBoxNonRepondu.Size = new System.Drawing.Size(27, 25);
            this.pictureBoxNonRepondu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNonRepondu.TabIndex = 1;
            this.pictureBoxNonRepondu.TabStop = false;
            // 
            // labelNonRepondu
            // 
            this.labelNonRepondu.AutoSize = true;
            this.labelNonRepondu.Location = new System.Drawing.Point(39, 6);
            this.labelNonRepondu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNonRepondu.Name = "labelNonRepondu";
            this.labelNonRepondu.Size = new System.Drawing.Size(91, 17);
            this.labelNonRepondu.TabIndex = 0;
            this.labelNonRepondu.Text = "Non répondu";
            // 
            // panelRepondu
            // 
            this.panelRepondu.Controls.Add(this.pictureBox2);
            this.panelRepondu.Controls.Add(this.labelRepondu);
            this.panelRepondu.Location = new System.Drawing.Point(448, 0);
            this.panelRepondu.Margin = new System.Windows.Forms.Padding(4);
            this.panelRepondu.Name = "panelRepondu";
            this.panelRepondu.Size = new System.Drawing.Size(112, 27);
            this.panelRepondu.TabIndex = 26;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(83, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // labelRepondu
            // 
            this.labelRepondu.AutoSize = true;
            this.labelRepondu.Location = new System.Drawing.Point(4, 7);
            this.labelRepondu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRepondu.Name = "labelRepondu";
            this.labelRepondu.Size = new System.Drawing.Size(66, 17);
            this.labelRepondu.TabIndex = 0;
            this.labelRepondu.Text = "Répondu";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(7, 38);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 81);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.commentaire);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 76);
            this.panel3.TabIndex = 0;
            // 
            // commentaire
            // 
            this.commentaire.AutoSize = true;
            this.commentaire.BackColor = System.Drawing.Color.White;
            this.commentaire.Location = new System.Drawing.Point(3, 2);
            this.commentaire.MaximumSize = new System.Drawing.Size(520, 0);
            this.commentaire.Name = "commentaire";
            this.commentaire.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.commentaire.Size = new System.Drawing.Size(100, 25);
            this.commentaire.TabIndex = 20;
            this.commentaire.Text = "Contenu avis";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(241, 2);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 20);
            this.labelDate.TabIndex = 24;
            this.labelDate.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // rating
            // 
            this.rating.AutoSize = true;
            this.rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rating.Location = new System.Drawing.Point(189, 2);
            this.rating.Name = "rating";
            this.rating.Size = new System.Drawing.Size(20, 20);
            this.rating.TabIndex = 21;
            this.rating.Text = "X";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(3, 2);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(126, 20);
            this.nom.TabIndex = 20;
            this.nom.Text = "Nom et Prénom";
            // 
            // AvisHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AvisHebergement";
            this.Size = new System.Drawing.Size(588, 159);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNonRepondu.ResumeLayout(false);
            this.panelNonRepondu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNonRepondu)).EndInit();
            this.panelRepondu.ResumeLayout(false);
            this.panelRepondu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label commentaire;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label rating;
        public System.Windows.Forms.Label nom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelNonRepondu;
        private System.Windows.Forms.PictureBox pictureBoxNonRepondu;
        private System.Windows.Forms.Label labelNonRepondu;
        private System.Windows.Forms.Panel panelRepondu;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelRepondu;
        private System.Windows.Forms.Button BtnReponse;
        private System.Windows.Forms.Panel panel3;
    }
}
