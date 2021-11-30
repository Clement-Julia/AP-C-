
namespace AP.Forms
{
    partial class AjouterResponse
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
            this.ajout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ajout
            // 
            this.ajout.Location = new System.Drawing.Point(76, 0);
            this.ajout.Name = "ajout";
            this.ajout.Size = new System.Drawing.Size(93, 29);
            this.ajout.TabIndex = 0;
            this.ajout.Text = "Publier";
            this.ajout.UseVisualStyleBackColor = true;
            this.ajout.Click += new System.EventHandler(this.ajout_Click);
            // 
            // AjouterResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ajout);
            this.Name = "AjouterResponse";
            this.Size = new System.Drawing.Size(170, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ajout;
    }
}
