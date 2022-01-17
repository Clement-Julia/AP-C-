
namespace AP.Forms
{
    partial class Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.CheckBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(76, 656);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Créer un COMPTE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(35, 639);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vous n\'avez pas encore de compte";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BtnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConnexion.FlatAppearance.BorderSize = 0;
            this.BtnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConnexion.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnexion.ForeColor = System.Drawing.Color.White;
            this.BtnConnexion.Location = new System.Drawing.Point(26, 570);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(228, 35);
            this.BtnConnexion.TabIndex = 33;
            this.BtnConnexion.Text = "Connexion";
            this.BtnConnexion.UseVisualStyleBackColor = false;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // CheckBoxShowPassword
            // 
            this.CheckBoxShowPassword.AutoSize = true;
            this.CheckBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBoxShowPassword.Location = new System.Drawing.Point(205, 493);
            this.CheckBoxShowPassword.Name = "CheckBoxShowPassword";
            this.CheckBoxShowPassword.Size = new System.Drawing.Size(49, 21);
            this.CheckBoxShowPassword.TabIndex = 31;
            this.CheckBoxShowPassword.Text = "Voir";
            this.CheckBoxShowPassword.UseVisualStyleBackColor = true;
            this.CheckBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPassword.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TextBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPassword.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(26, 448);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '•';
            this.TextBoxPassword.Size = new System.Drawing.Size(228, 25);
            this.TextBoxPassword.TabIndex = 28;
            this.TextBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(22, 424);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Mot de passe";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxUsername.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxUsername.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(26, 385);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(228, 25);
            this.TextBoxUsername.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(22, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label7.Location = new System.Drawing.Point(59, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 37);
            this.label7.TabIndex = 24;
            this.label7.Text = "Connexion";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(285, 700);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.CheckBoxShowPassword);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.CheckBox CheckBoxShowPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}