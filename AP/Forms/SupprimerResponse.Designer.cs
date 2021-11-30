
namespace AP.Forms
{
    partial class SupprimerResponse
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
            this.supResponse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // supResponse
            // 
            this.supResponse.Location = new System.Drawing.Point(0, 0);
            this.supResponse.Name = "supResponse";
            this.supResponse.Size = new System.Drawing.Size(95, 27);
            this.supResponse.TabIndex = 0;
            this.supResponse.Text = "Supprimer";
            this.supResponse.UseVisualStyleBackColor = true;
            // 
            // SupprimerResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supResponse);
            this.Name = "SupprimerResponse";
            this.Size = new System.Drawing.Size(98, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button supResponse;
    }
}
