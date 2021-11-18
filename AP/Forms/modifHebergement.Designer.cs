
namespace AP
{
    partial class modifHebergement
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifHebergement));
            this.tab_all = new System.Windows.Forms.TabControl();
            this.tab_généraux = new System.Windows.Forms.TabPage();
            this.description = new System.Windows.Forms.TextBox();
            this.sup = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.retour = new System.Windows.Forms.Button();
            this.appartenance = new System.Windows.Forms.Label();
            this.modif = new System.Windows.Forms.Button();
            this.labeldesc = new System.Windows.Forms.Label();
            this.longitude = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.labellat = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.labellong = new System.Windows.Forms.Label();
            this.tab_options = new System.Windows.Forms.TabPage();
            this.modif2 = new System.Windows.Forms.Button();
            this.float_options = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_avis = new System.Windows.Forms.TabPage();
            this.flow_avis = new System.Windows.Forms.FlowLayoutPanel();
            this.tab_images = new System.Windows.Forms.TabPage();
            this.tab_all.SuspendLayout();
            this.tab_généraux.SuspendLayout();
            this.tab_options.SuspendLayout();
            this.tab_avis.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_all
            // 
            this.tab_all.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tab_all.Controls.Add(this.tab_généraux);
            this.tab_all.Controls.Add(this.tab_options);
            this.tab_all.Controls.Add(this.tab_avis);
            this.tab_all.Controls.Add(this.tab_images);
            this.tab_all.Location = new System.Drawing.Point(6, 11);
            this.tab_all.Name = "tab_all";
            this.tab_all.SelectedIndex = 0;
            this.tab_all.Size = new System.Drawing.Size(447, 647);
            this.tab_all.TabIndex = 17;
            // 
            // tab_généraux
            // 
            this.tab_généraux.Controls.Add(this.description);
            this.tab_généraux.Controls.Add(this.sup);
            this.tab_généraux.Controls.Add(this.nom);
            this.tab_généraux.Controls.Add(this.ville);
            this.tab_généraux.Controls.Add(this.name);
            this.tab_généraux.Controls.Add(this.retour);
            this.tab_généraux.Controls.Add(this.appartenance);
            this.tab_généraux.Controls.Add(this.modif);
            this.tab_généraux.Controls.Add(this.labeldesc);
            this.tab_généraux.Controls.Add(this.longitude);
            this.tab_généraux.Controls.Add(this.price);
            this.tab_généraux.Controls.Add(this.latitude);
            this.tab_généraux.Controls.Add(this.labellat);
            this.tab_généraux.Controls.Add(this.prix);
            this.tab_généraux.Controls.Add(this.labellong);
            this.tab_généraux.Location = new System.Drawing.Point(4, 25);
            this.tab_généraux.Name = "tab_généraux";
            this.tab_généraux.Padding = new System.Windows.Forms.Padding(3);
            this.tab_généraux.Size = new System.Drawing.Size(439, 618);
            this.tab_généraux.TabIndex = 0;
            this.tab_généraux.Text = "Généraux";
            this.tab_généraux.UseVisualStyleBackColor = true;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.Location = new System.Drawing.Point(29, 182);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(360, 92);
            this.description.TabIndex = 8;
            // 
            // sup
            // 
            this.sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sup.BackColor = System.Drawing.Color.White;
            this.sup.Location = new System.Drawing.Point(239, 495);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(150, 42);
            this.sup.TabIndex = 15;
            this.sup.Text = "Supprimer";
            this.sup.UseVisualStyleBackColor = false;
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(26, 24);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(61, 24);
            this.nom.TabIndex = 0;
            this.nom.Text = "Nom :";
            // 
            // ville
            // 
            this.ville.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(29, 116);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(360, 24);
            this.ville.TabIndex = 14;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(29, 51);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(360, 22);
            this.name.TabIndex = 1;
            // 
            // retour
            // 
            this.retour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.retour.BackColor = System.Drawing.Color.White;
            this.retour.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.retour.Location = new System.Drawing.Point(137, 543);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(146, 42);
            this.retour.TabIndex = 13;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            // 
            // appartenance
            // 
            this.appartenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appartenance.AutoSize = true;
            this.appartenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appartenance.Location = new System.Drawing.Point(25, 89);
            this.appartenance.Name = "appartenance";
            this.appartenance.Size = new System.Drawing.Size(139, 24);
            this.appartenance.TabIndex = 2;
            this.appartenance.Text = "Appartenance :";
            // 
            // modif
            // 
            this.modif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modif.BackColor = System.Drawing.Color.White;
            this.modif.Location = new System.Drawing.Point(29, 495);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(150, 42);
            this.modif.TabIndex = 12;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = false;
            // 
            // labeldesc
            // 
            this.labeldesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldesc.Location = new System.Drawing.Point(26, 155);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(114, 24);
            this.labeldesc.TabIndex = 3;
            this.labeldesc.Text = "Description :";
            // 
            // longitude
            // 
            this.longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longitude.Location = new System.Drawing.Point(29, 443);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(360, 22);
            this.longitude.TabIndex = 11;
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(26, 288);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(52, 24);
            this.price.TabIndex = 4;
            this.price.Text = "Prix :";
            // 
            // latitude
            // 
            this.latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.latitude.Location = new System.Drawing.Point(30, 378);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(360, 22);
            this.latitude.TabIndex = 10;
            // 
            // labellat
            // 
            this.labellat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellat.AutoSize = true;
            this.labellat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellat.Location = new System.Drawing.Point(27, 351);
            this.labellat.Name = "labellat";
            this.labellat.Size = new System.Drawing.Size(85, 24);
            this.labellat.TabIndex = 5;
            this.labellat.Text = "Latitude :";
            // 
            // prix
            // 
            this.prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prix.Location = new System.Drawing.Point(29, 315);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(360, 22);
            this.prix.TabIndex = 9;
            // 
            // labellong
            // 
            this.labellong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellong.AutoSize = true;
            this.labellong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellong.Location = new System.Drawing.Point(26, 416);
            this.labellong.Name = "labellong";
            this.labellong.Size = new System.Drawing.Size(104, 24);
            this.labellong.TabIndex = 6;
            this.labellong.Text = "Longitude :";
            // 
            // tab_options
            // 
            this.tab_options.Controls.Add(this.modif2);
            this.tab_options.Controls.Add(this.float_options);
            this.tab_options.Location = new System.Drawing.Point(4, 25);
            this.tab_options.Name = "tab_options";
            this.tab_options.Padding = new System.Windows.Forms.Padding(3);
            this.tab_options.Size = new System.Drawing.Size(439, 618);
            this.tab_options.TabIndex = 1;
            this.tab_options.Text = "Options";
            this.tab_options.UseVisualStyleBackColor = true;
            // 
            // modif2
            // 
            this.modif2.Location = new System.Drawing.Point(148, 566);
            this.modif2.Name = "modif2";
            this.modif2.Size = new System.Drawing.Size(154, 46);
            this.modif2.TabIndex = 0;
            this.modif2.Text = "Modifier";
            this.modif2.UseVisualStyleBackColor = true;
            // 
            // float_options
            // 
            this.float_options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.float_options.Location = new System.Drawing.Point(3, 3);
            this.float_options.Name = "float_options";
            this.float_options.Size = new System.Drawing.Size(433, 557);
            this.float_options.TabIndex = 17;
            // 
            // tab_avis
            // 
            this.tab_avis.Controls.Add(this.flow_avis);
            this.tab_avis.Location = new System.Drawing.Point(4, 25);
            this.tab_avis.Name = "tab_avis";
            this.tab_avis.Padding = new System.Windows.Forms.Padding(3);
            this.tab_avis.Size = new System.Drawing.Size(439, 618);
            this.tab_avis.TabIndex = 2;
            this.tab_avis.Text = "Avis";
            this.tab_avis.UseVisualStyleBackColor = true;
            // 
            // flow_avis
            // 
            this.flow_avis.AutoScroll = true;
            this.flow_avis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_avis.Location = new System.Drawing.Point(3, 3);
            this.flow_avis.Name = "flow_avis";
            this.flow_avis.Size = new System.Drawing.Size(433, 612);
            this.flow_avis.TabIndex = 18;
            // 
            // tab_images
            // 
            this.tab_images.Location = new System.Drawing.Point(4, 25);
            this.tab_images.Name = "tab_images";
            this.tab_images.Padding = new System.Windows.Forms.Padding(3);
            this.tab_images.Size = new System.Drawing.Size(439, 618);
            this.tab_images.TabIndex = 3;
            this.tab_images.Text = "Images";
            this.tab_images.UseVisualStyleBackColor = true;
            // 
            // modifHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 668);
            this.Controls.Add(this.tab_all);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifHebergement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un hébergement";
            this.tab_all.ResumeLayout(false);
            this.tab_généraux.ResumeLayout(false);
            this.tab_généraux.PerformLayout();
            this.tab_options.ResumeLayout(false);
            this.tab_avis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_all;
        private System.Windows.Forms.TabPage tab_généraux;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.ComboBox ville;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Label appartenance;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label labellat;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Label labellong;
        private System.Windows.Forms.TabPage tab_options;
        private System.Windows.Forms.Button modif2;
        private System.Windows.Forms.FlowLayoutPanel float_options;
        private System.Windows.Forms.TabPage tab_avis;
        public System.Windows.Forms.FlowLayoutPanel flow_avis;
        private System.Windows.Forms.TabPage tab_images;
    }
}

