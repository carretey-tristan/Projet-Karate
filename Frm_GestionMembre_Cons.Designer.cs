namespace karaté_mission_1
{
    partial class Frm_GestionMembre_Cons
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
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Licence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Villle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Triebox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Items.AddRange(new object[] {
            "Aucun club"});
            this.comboBoxClub.Location = new System.Drawing.Point(11, 49);
            this.comboBoxClub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(204, 21);
            this.comboBoxClub.TabIndex = 35;
            this.comboBoxClub.SelectedIndexChanged += new System.EventHandler(this.comboBoxClub_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Licence,
            this.nom,
            this.Prenom,
            this.Date,
            this.addresse,
            this.cp,
            this.Villle});
            this.dataGridView1.Location = new System.Drawing.Point(9, 83);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 241);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Licence
            // 
            this.Licence.HeaderText = "Licence";
            this.Licence.MinimumWidth = 6;
            this.Licence.Name = "Licence";
            this.Licence.ReadOnly = true;
            this.Licence.Width = 125;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.MinimumWidth = 6;
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            this.nom.Width = 125;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 6;
            this.Prenom.Name = "Prenom";
            this.Prenom.ReadOnly = true;
            this.Prenom.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date de naissance";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // addresse
            // 
            this.addresse.HeaderText = "Adresse";
            this.addresse.MinimumWidth = 6;
            this.addresse.Name = "addresse";
            this.addresse.ReadOnly = true;
            this.addresse.Width = 125;
            // 
            // cp
            // 
            this.cp.HeaderText = "Code Postal";
            this.cp.MinimumWidth = 6;
            this.cp.Name = "cp";
            this.cp.Width = 125;
            // 
            // Villle
            // 
            this.Villle.HeaderText = "Ville";
            this.Villle.MinimumWidth = 6;
            this.Villle.Name = "Villle";
            this.Villle.Width = 125;
            // 
            // Triebox
            // 
            this.Triebox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Triebox.FormattingEnabled = true;
            this.Triebox.Items.AddRange(new object[] {
            "Aucun Trie",
            "Trie par ordre alphabétique A-Z",
            "Trie par ordre alphabétique inversé Z-A",
            "Trie par ordre croissant des dates de naissance",
            "Trie par ordre décroissant des dates de naissance",
            "Trie par ordre croissant des départements",
            "Trie par ordre décroissant des départements",
            "Trie par ordre croissant des numéros de licences",
            "Trie par ordre décroissant des numéros de licences"});
            this.Triebox.Location = new System.Drawing.Point(251, 49);
            this.Triebox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Triebox.Name = "Triebox";
            this.Triebox.Size = new System.Drawing.Size(246, 21);
            this.Triebox.TabIndex = 37;
            this.Triebox.SelectedIndexChanged += new System.EventHandler(this.Triebox_SelectedIndexChanged);
            // 
            // Frm_GestionMembre_Cons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 334);
            this.Controls.Add(this.Triebox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxClub);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_GestionMembre_Cons";
            this.Text = "Frm_GestionMembre_Cons";
            this.Load += new System.EventHandler(this.Frm_GestionMembre_Cons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Licence;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn cp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Villle;
        private System.Windows.Forms.ComboBox Triebox;
    }
}