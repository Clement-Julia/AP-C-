
namespace AP.UserControls
{
    partial class LigneReservationHebergement
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
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelCodeReservation = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPeriode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrix
            // 
            this.labelPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrix.Location = new System.Drawing.Point(598, 0);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(102, 40);
            this.labelPrix.TabIndex = 22;
            this.labelPrix.Text = "Prix";
            this.labelPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCodeReservation
            // 
            this.labelCodeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeReservation.Location = new System.Drawing.Point(461, 0);
            this.labelCodeReservation.Name = "labelCodeReservation";
            this.labelCodeReservation.Size = new System.Drawing.Size(131, 40);
            this.labelCodeReservation.TabIndex = 21;
            this.labelCodeReservation.Text = "Code Reserv";
            this.labelCodeReservation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUsername
            // 
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(234, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(221, 40);
            this.labelUsername.TabIndex = 20;
            this.labelUsername.Text = "Nom de l\'utilisateur";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPeriode
            // 
            this.labelPeriode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriode.Location = new System.Drawing.Point(-2, 0);
            this.labelPeriode.Name = "labelPeriode";
            this.labelPeriode.Size = new System.Drawing.Size(228, 40);
            this.labelPeriode.TabIndex = 19;
            this.labelPeriode.Text = "Du 01/01/2020 au 01/02/2020";
            this.labelPeriode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LigneReservationHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.labelCodeReservation);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelPeriode);
            this.Name = "LigneReservationHebergement";
            this.Size = new System.Drawing.Size(700, 40);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelCodeReservation;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPeriode;
    }
}
