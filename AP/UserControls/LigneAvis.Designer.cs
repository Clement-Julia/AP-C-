namespace AP.UserControls
{
    partial class LigneAvis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LigneAvis));
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.flowLayoutPanelEtoiles = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCommentaire = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(7, 72);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(124, 23);
            this.labelDate.TabIndex = 36;
            this.labelDate.Text = "Le 01-01-2021";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrenom
            // 
            this.labelPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenom.Location = new System.Drawing.Point(7, 45);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(124, 26);
            this.labelPrenom.TabIndex = 35;
            this.labelPrenom.Text = "Prenom";
            this.labelPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanelEtoiles
            // 
            this.flowLayoutPanelEtoiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelEtoiles.Location = new System.Drawing.Point(530, 35);
            this.flowLayoutPanelEtoiles.Name = "flowLayoutPanelEtoiles";
            this.flowLayoutPanelEtoiles.Padding = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.flowLayoutPanelEtoiles.Size = new System.Drawing.Size(190, 50);
            this.flowLayoutPanelEtoiles.TabIndex = 34;
            // 
            // labelCommentaire
            // 
            this.labelCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommentaire.Location = new System.Drawing.Point(137, 4);
            this.labelCommentaire.Name = "labelCommentaire";
            this.labelCommentaire.Size = new System.Drawing.Size(387, 110);
            this.labelCommentaire.TabIndex = 33;
            this.labelCommentaire.Text = resources.GetString("labelCommentaire.Text");
            this.labelCommentaire.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelNom
            // 
            this.labelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNom.Location = new System.Drawing.Point(7, 21);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(124, 24);
            this.labelNom.TabIndex = 32;
            this.labelNom.Text = "Nom";
            this.labelNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LigneAvis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.flowLayoutPanelEtoiles);
            this.Controls.Add(this.labelCommentaire);
            this.Controls.Add(this.labelNom);
            this.Name = "LigneAvis";
            this.Size = new System.Drawing.Size(723, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEtoiles;
        private System.Windows.Forms.Label labelCommentaire;
        private System.Windows.Forms.Label labelNom;
    }
}
