namespace karaté_mission_1
{
    partial class Frm_GestionMembres
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.gestionLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accueilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutDuneLicenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationDUnMembreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultationDesLicencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(954, 412);
            this.panelContainer.TabIndex = 0;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionLicencesToolStripMenuItem,
            this.consultationDesLicencesToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(954, 28);
            this.menuStrip2.TabIndex = 26;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // gestionLicencesToolStripMenuItem
            // 
            this.gestionLicencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accueilToolStripMenuItem,
            this.ajoutDuneLicenceToolStripMenuItem,
            this.modificationDUnMembreToolStripMenuItem});
            this.gestionLicencesToolStripMenuItem.Name = "gestionLicencesToolStripMenuItem";
            this.gestionLicencesToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.gestionLicencesToolStripMenuItem.Text = "Gestion Des Licences";
            this.gestionLicencesToolStripMenuItem.Click += new System.EventHandler(this.gestionLicencesToolStripMenuItem_Click);
            // 
            // accueilToolStripMenuItem
            // 
            this.accueilToolStripMenuItem.Name = "accueilToolStripMenuItem";
            this.accueilToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.accueilToolStripMenuItem.Text = "Accueil";
            this.accueilToolStripMenuItem.Click += new System.EventHandler(this.accueilToolStripMenuItem_Click);
            // 
            // ajoutDuneLicenceToolStripMenuItem
            // 
            this.ajoutDuneLicenceToolStripMenuItem.Name = "ajoutDuneLicenceToolStripMenuItem";
            this.ajoutDuneLicenceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.ajoutDuneLicenceToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.ajoutDuneLicenceToolStripMenuItem.Text = "Ajout d\'Un Membre";
            this.ajoutDuneLicenceToolStripMenuItem.Click += new System.EventHandler(this.ajoutDuneLicenceToolStripMenuItem_Click);
            // 
            // modificationDUnMembreToolStripMenuItem
            // 
            this.modificationDUnMembreToolStripMenuItem.Name = "modificationDUnMembreToolStripMenuItem";
            this.modificationDUnMembreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
            this.modificationDUnMembreToolStripMenuItem.Size = new System.Drawing.Size(338, 26);
            this.modificationDUnMembreToolStripMenuItem.Text = "Modification d\'Un Membre";
            this.modificationDUnMembreToolStripMenuItem.Click += new System.EventHandler(this.modificationDUnMembreToolStripMenuItem_Click);
            // 
            // consultationDesLicencesToolStripMenuItem
            // 
            this.consultationDesLicencesToolStripMenuItem.Name = "consultationDesLicencesToolStripMenuItem";
            this.consultationDesLicencesToolStripMenuItem.Size = new System.Drawing.Size(194, 24);
            this.consultationDesLicencesToolStripMenuItem.Text = "Consultation Des Licences";
            this.consultationDesLicencesToolStripMenuItem.Click += new System.EventHandler(this.consultationDesLicencesToolStripMenuItem_Click);
            // 
            // Frm_GestionMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 411);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.panelContainer);
            this.Name = "Frm_GestionMembres";
            this.Text = "GestioMembres";
            this.Load += new System.EventHandler(this.Frm_GestionMembres_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem gestionLicencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutDuneLicenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationDUnMembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accueilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultationDesLicencesToolStripMenuItem;
    }
}