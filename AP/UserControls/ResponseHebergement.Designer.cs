
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.reponse = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.nom);
            this.panel2.Location = new System.Drawing.Point(71, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 109);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 79);
            this.panel1.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.reponse);
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 74);
            this.panel3.TabIndex = 0;
            // 
            // reponse
            // 
            this.reponse.AutoSize = true;
            this.reponse.Location = new System.Drawing.Point(2, 2);
            this.reponse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reponse.MaximumSize = new System.Drawing.Size(360, 0);
            this.reponse.Name = "reponse";
            this.reponse.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.reponse.Size = new System.Drawing.Size(126, 19);
            this.reponse.TabIndex = 20;
            this.reponse.Text = "Contenu de la réponse";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(258, 7);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(94, 17);
            this.labelDate.TabIndex = 21;
            this.labelDate.Text = "Date réponse";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(9, 7);
            this.nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(106, 17);
            this.nom.TabIndex = 20;
            this.nom.Text = "Nom du proprio";
            // 
            // ResponseHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResponseHebergement";
            this.Size = new System.Drawing.Size(452, 113);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label reponse;
        public System.Windows.Forms.Label nom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label labelDate;
    }
}
