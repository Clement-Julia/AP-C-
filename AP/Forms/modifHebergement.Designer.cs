
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.sup = new System.Windows.Forms.Button();
            this.nom = new System.Windows.Forms.Label();
            this.ville = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
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
            this.retour = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tab_all.SuspendLayout();
            this.tab_généraux.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tab_all.Location = new System.Drawing.Point(177, 40);
            this.tab_all.Name = "tab_all";
            this.tab_all.SelectedIndex = 0;
            this.tab_all.Size = new System.Drawing.Size(639, 590);
            this.tab_all.TabIndex = 17;
            // 
            // tab_généraux
            // 
            this.tab_généraux.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_généraux.Controls.Add(this.panel1);
            this.tab_généraux.Location = new System.Drawing.Point(4, 25);
            this.tab_généraux.Name = "tab_généraux";
            this.tab_généraux.Padding = new System.Windows.Forms.Padding(3);
            this.tab_généraux.Size = new System.Drawing.Size(631, 561);
            this.tab_généraux.TabIndex = 0;
            this.tab_généraux.Text = "Généraux";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.sup);
            this.panel1.Controls.Add(this.nom);
            this.panel1.Controls.Add(this.ville);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.appartenance);
            this.panel1.Controls.Add(this.modif);
            this.panel1.Controls.Add(this.labeldesc);
            this.panel1.Controls.Add(this.longitude);
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.latitude);
            this.panel1.Controls.Add(this.labellat);
            this.panel1.Controls.Add(this.prix);
            this.panel1.Controls.Add(this.labellong);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 549);
            this.panel1.TabIndex = 0;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.Location = new System.Drawing.Point(131, 178);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(360, 92);
            this.description.TabIndex = 23;
            // 
            // sup
            // 
            this.sup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sup.BackColor = System.Drawing.Color.Salmon;
            this.sup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sup.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.sup.ForeColor = System.Drawing.Color.White;
            this.sup.Location = new System.Drawing.Point(341, 491);
            this.sup.Name = "sup";
            this.sup.Size = new System.Drawing.Size(150, 42);
            this.sup.TabIndex = 29;
            this.sup.Text = "Supprimer";
            this.sup.UseVisualStyleBackColor = false;
            this.sup.Click += new System.EventHandler(this.sup_Click_1);
            // 
            // nom
            // 
            this.nom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.nom.Location = new System.Drawing.Point(126, 16);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(73, 28);
            this.nom.TabIndex = 16;
            this.nom.Text = "Nom :";
            // 
            // ville
            // 
            this.ville.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ville.FormattingEnabled = true;
            this.ville.Location = new System.Drawing.Point(131, 112);
            this.ville.Name = "ville";
            this.ville.Size = new System.Drawing.Size(360, 24);
            this.ville.TabIndex = 28;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(131, 47);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(360, 22);
            this.name.TabIndex = 17;
            // 
            // appartenance
            // 
            this.appartenance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appartenance.AutoSize = true;
            this.appartenance.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.appartenance.Location = new System.Drawing.Point(127, 85);
            this.appartenance.Name = "appartenance";
            this.appartenance.Size = new System.Drawing.Size(163, 28);
            this.appartenance.TabIndex = 18;
            this.appartenance.Text = "Appartenance :";
            // 
            // modif
            // 
            this.modif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modif.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modif.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.modif.ForeColor = System.Drawing.Color.White;
            this.modif.Location = new System.Drawing.Point(131, 491);
            this.modif.Name = "modif";
            this.modif.Size = new System.Drawing.Size(150, 42);
            this.modif.TabIndex = 27;
            this.modif.Text = "Modifier";
            this.modif.UseVisualStyleBackColor = false;
            this.modif.Click += new System.EventHandler(this.modif_Click);
            // 
            // labeldesc
            // 
            this.labeldesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.labeldesc.Location = new System.Drawing.Point(128, 151);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(139, 28);
            this.labeldesc.TabIndex = 19;
            this.labeldesc.Text = "Description :";
            // 
            // longitude
            // 
            this.longitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.longitude.Location = new System.Drawing.Point(131, 439);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(360, 22);
            this.longitude.TabIndex = 26;
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.price.Location = new System.Drawing.Point(132, 280);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(67, 28);
            this.price.TabIndex = 20;
            this.price.Text = "Prix :";
            // 
            // latitude
            // 
            this.latitude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.latitude.Location = new System.Drawing.Point(132, 374);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(360, 22);
            this.latitude.TabIndex = 25;
            // 
            // labellat
            // 
            this.labellat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellat.AutoSize = true;
            this.labellat.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.labellat.Location = new System.Drawing.Point(129, 347);
            this.labellat.Name = "labellat";
            this.labellat.Size = new System.Drawing.Size(109, 28);
            this.labellat.TabIndex = 21;
            this.labellat.Text = "Latitude :";
            // 
            // prix
            // 
            this.prix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prix.Location = new System.Drawing.Point(131, 311);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(360, 22);
            this.prix.TabIndex = 24;
            // 
            // labellong
            // 
            this.labellong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labellong.AutoSize = true;
            this.labellong.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.labellong.Location = new System.Drawing.Point(128, 412);
            this.labellong.Name = "labellong";
            this.labellong.Size = new System.Drawing.Size(126, 28);
            this.labellong.TabIndex = 22;
            this.labellong.Text = "Longitude :";
            // 
            // tab_options
            // 
            this.tab_options.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_options.Controls.Add(this.modif2);
            this.tab_options.Controls.Add(this.float_options);
            this.tab_options.Location = new System.Drawing.Point(4, 25);
            this.tab_options.Name = "tab_options";
            this.tab_options.Padding = new System.Windows.Forms.Padding(3);
            this.tab_options.Size = new System.Drawing.Size(631, 561);
            this.tab_options.TabIndex = 1;
            this.tab_options.Text = "Options";
            // 
            // modif2
            // 
            this.modif2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.modif2.FlatAppearance.BorderSize = 0;
            this.modif2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modif2.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.modif2.ForeColor = System.Drawing.Color.White;
            this.modif2.Location = new System.Drawing.Point(254, 507);
            this.modif2.Name = "modif2";
            this.modif2.Size = new System.Drawing.Size(154, 46);
            this.modif2.TabIndex = 0;
            this.modif2.Text = "Modifier";
            this.modif2.UseVisualStyleBackColor = false;
            this.modif2.Click += new System.EventHandler(this.modif2_Click_1);
            // 
            // float_options
            // 
            this.float_options.BackColor = System.Drawing.Color.WhiteSmoke;
            this.float_options.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.float_options.Location = new System.Drawing.Point(6, 6);
            this.float_options.Name = "float_options";
            this.float_options.Size = new System.Drawing.Size(619, 495);
            this.float_options.TabIndex = 17;
            // 
            // tab_avis
            // 
            this.tab_avis.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tab_avis.Controls.Add(this.flow_avis);
            this.tab_avis.Location = new System.Drawing.Point(4, 25);
            this.tab_avis.Name = "tab_avis";
            this.tab_avis.Padding = new System.Windows.Forms.Padding(3);
            this.tab_avis.Size = new System.Drawing.Size(631, 561);
            this.tab_avis.TabIndex = 2;
            this.tab_avis.Text = "Avis";
            // 
            // flow_avis
            // 
            this.flow_avis.AutoScroll = true;
            this.flow_avis.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flow_avis.Location = new System.Drawing.Point(6, 6);
            this.flow_avis.Name = "flow_avis";
            this.flow_avis.Size = new System.Drawing.Size(619, 328);
            this.flow_avis.TabIndex = 18;
            // 
            // tab_images
            // 
            this.tab_images.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tab_images.Location = new System.Drawing.Point(4, 25);
            this.tab_images.Name = "tab_images";
            this.tab_images.Padding = new System.Windows.Forms.Padding(3);
            this.tab_images.Size = new System.Drawing.Size(631, 561);
            this.tab_images.TabIndex = 3;
            this.tab_images.Text = "Images";
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.LightSeaGreen;
            this.retour.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.retour.FlatAppearance.BorderSize = 0;
            this.retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.retour.Font = new System.Drawing.Font("Bodoni MT", 14F, System.Drawing.FontStyle.Bold);
            this.retour.ForeColor = System.Drawing.Color.White;
            this.retour.Location = new System.Drawing.Point(25, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(146, 42);
            this.retour.TabIndex = 13;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // modifHebergement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 663);
            this.Controls.Add(this.tab_all);
            this.Controls.Add(this.retour);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifHebergement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'un hébergement";
            this.tab_all.ResumeLayout(false);
            this.tab_généraux.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tab_options.ResumeLayout(false);
            this.tab_avis.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_all;
        private System.Windows.Forms.TabPage tab_généraux;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.TabPage tab_options;
        private System.Windows.Forms.Button modif2;
        private System.Windows.Forms.FlowLayoutPanel float_options;
        public System.Windows.Forms.TabPage tab_avis;
        public System.Windows.Forms.FlowLayoutPanel flow_avis;
        private System.Windows.Forms.TabPage tab_images;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button sup;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.ComboBox ville;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label appartenance;
        private System.Windows.Forms.Button modif;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.Label labellat;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.Label labellong;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

