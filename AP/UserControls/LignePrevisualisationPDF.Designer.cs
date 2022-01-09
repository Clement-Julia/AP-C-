
namespace AP.UserControls
{
    partial class LignePrevisualisationPDF
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
            this.labelIdReservation = new System.Windows.Forms.Label();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.labelVille = new System.Windows.Forms.Label();
            this.labelHebergement = new System.Windows.Forms.Label();
            this.labelGains = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelIdReservation
            // 
            this.labelIdReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdReservation.Location = new System.Drawing.Point(0, 0);
            this.labelIdReservation.Name = "labelIdReservation";
            this.labelIdReservation.Size = new System.Drawing.Size(90, 50);
            this.labelIdReservation.TabIndex = 0;
            this.labelIdReservation.Text = "Id";
            this.labelIdReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPeriode
            // 
            this.labelPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriode.Location = new System.Drawing.Point(90, 0);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(205, 50);
            this.labelPeriode.TabIndex = 1;
            this.labelPeriode.Text = "Du 01-01-2021 au 01-01-2021";
            this.labelPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVille
            // 
            this.labelVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVille.Location = new System.Drawing.Point(295, 0);
            this.labelVille.Name = "labelVille";
            this.labelVille.Size = new System.Drawing.Size(130, 50);
            this.labelVille.TabIndex = 2;
            this.labelVille.Text = "Ville";
            this.labelVille.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHebergement
            // 
            this.labelHebergement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHebergement.Location = new System.Drawing.Point(431, 0);
            this.labelHebergement.Name = "labelHebergement";
            this.labelHebergement.Size = new System.Drawing.Size(188, 50);
            this.labelHebergement.TabIndex = 3;
            this.labelHebergement.Text = "Hébergement";
            this.labelHebergement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGains
            // 
            this.labelGains.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGains.Location = new System.Drawing.Point(625, 0);
            this.labelGains.Name = "labelGains";
            this.labelGains.Size = new System.Drawing.Size(75, 50);
            this.labelGains.TabIndex = 4;
            this.labelGains.Text = "Gains";
            this.labelGains.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LignePrevisualisationPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelGains);
            this.Controls.Add(this.labelHebergement);
            this.Controls.Add(this.labelVille);
            this.Controls.Add(this.labelPeriode);
            this.Controls.Add(this.labelIdReservation);
            this.Name = "LignePrevisualisationPDF";
            this.Size = new System.Drawing.Size(700, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelIdReservation;
        private System.Windows.Forms.Label labelPeriode;
        private System.Windows.Forms.Label labelVille;
        private System.Windows.Forms.Label labelHebergement;
        private System.Windows.Forms.Label labelGains;
    }
}
