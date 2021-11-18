
namespace AP.Forms
{
    partial class FormHebergements
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
            this.PanelHebergements = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelHebergements
            // 
            this.PanelHebergements.AutoScroll = true;
            this.PanelHebergements.BackColor = System.Drawing.Color.White;
            this.PanelHebergements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHebergements.Location = new System.Drawing.Point(0, 0);
            this.PanelHebergements.Name = "PanelHebergements";
            this.PanelHebergements.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.PanelHebergements.Size = new System.Drawing.Size(750, 500);
            this.PanelHebergements.TabIndex = 0;
            // 
            // FormHebergements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.PanelHebergements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHebergements";
            this.Text = "Hebergements";
            this.Load += new System.EventHandler(this.FormHebergements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel PanelHebergements;
    }
}