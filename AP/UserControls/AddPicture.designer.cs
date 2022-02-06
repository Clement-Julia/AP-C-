
namespace AP.UserControls
{
    partial class AddPicture
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
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnAdd = new System.Windows.Forms.Button();
            this.formPicture = new System.Windows.Forms.Button();
            this.addBan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "FileDialog";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(9, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 37);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ajouter image";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // formPicture
            // 
            this.formPicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.formPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.formPicture.FlatAppearance.BorderSize = 0;
            this.formPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.formPicture.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.formPicture.ForeColor = System.Drawing.Color.White;
            this.formPicture.Location = new System.Drawing.Point(351, 19);
            this.formPicture.Name = "formPicture";
            this.formPicture.Size = new System.Drawing.Size(99, 37);
            this.formPicture.TabIndex = 1;
            this.formPicture.Text = "Soumettre";
            this.formPicture.UseVisualStyleBackColor = false;
            this.formPicture.Click += new System.EventHandler(this.formPicture_Click);
            // 
            // addBan
            // 
            this.addBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.addBan.FlatAppearance.BorderSize = 0;
            this.addBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBan.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.addBan.ForeColor = System.Drawing.Color.White;
            this.addBan.Location = new System.Drawing.Point(145, 19);
            this.addBan.Name = "addBan";
            this.addBan.Size = new System.Drawing.Size(176, 37);
            this.addBan.TabIndex = 2;
            this.addBan.Text = "Ajouter bannière";
            this.addBan.UseVisualStyleBackColor = false;
            this.addBan.Click += new System.EventHandler(this.addBan_Click);
            // 
            // AddPicture
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.addBan);
            this.Controls.Add(this.formPicture);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddPicture";
            this.Size = new System.Drawing.Size(465, 80);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button formPicture;
        private System.Windows.Forms.Button addBan;
    }
}
