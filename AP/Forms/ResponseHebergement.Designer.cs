
namespace AP.Forms
{
    partial class ResponseHebergement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.prenom = new System.Windows.Forms.Label();
            this.reponse = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.prenom);
            this.panel2.Controls.Add(this.reponse);
            this.panel2.Controls.Add(this.nom);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 97);
            this.panel2.TabIndex = 24;
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(132, 13);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(126, 17);
            this.prenom.TabIndex = 21;
            this.prenom.Text = "Prénom du proprio";
            // 
            // reponse
            // 
            this.reponse.AutoSize = true;
            this.reponse.Location = new System.Drawing.Point(85, 64);
            this.reponse.Name = "reponse";
            this.reponse.Size = new System.Drawing.Size(152, 17);
            this.reponse.TabIndex = 20;
            this.reponse.Text = "Contenu de la réponse";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(20, 13);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(106, 17);
            this.nom.TabIndex = 20;
            this.nom.Text = "Nom du proprio";
            // 
            // ResponseHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ResponseHebergement";
            this.Size = new System.Drawing.Size(337, 103);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label reponse;
        public System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label prenom;
    }
}
