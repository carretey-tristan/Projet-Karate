namespace karaté_mission_1
{
    partial class Frm_GestionMembres_MS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionMembres_MS));
            this.comboBoxLicences = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmd_Dlt = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxDateNaissance = new System.Windows.Forms.TextBox();
            this.textBoxNumRue = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.textBoxVille = new System.Windows.Forms.TextBox();
            this.Cmd_Mdf = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.Rst_All = new System.Windows.Forms.Button();
            this.Rst_nom = new System.Windows.Forms.Button();
            this.Rst_prenom = new System.Windows.Forms.Button();
            this.Rst_adr = new System.Windows.Forms.Button();
            this.Rst_date = new System.Windows.Forms.Button();
            this.Rst_ville = new System.Windows.Forms.Button();
            this.Rst_cp = new System.Windows.Forms.Button();
            this.Rst_club = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxLicences
            // 
            this.comboBoxLicences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLicences.FormattingEnabled = true;
            this.comboBoxLicences.Location = new System.Drawing.Point(18, 73);
            this.comboBoxLicences.Name = "comboBoxLicences";
            this.comboBoxLicences.Size = new System.Drawing.Size(249, 24);
            this.comboBoxLicences.TabIndex = 1;
            this.comboBoxLicences.SelectedIndexChanged += new System.EventHandler(this.comboBoxLicences_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date de Naissance : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numéro de Rue : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prénom :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(518, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Code Postale : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ville :";
            // 
            // Cmd_Dlt
            // 
            this.Cmd_Dlt.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Dlt.Location = new System.Drawing.Point(423, 47);
            this.Cmd_Dlt.Name = "Cmd_Dlt";
            this.Cmd_Dlt.Size = new System.Drawing.Size(208, 63);
            this.Cmd_Dlt.TabIndex = 7;
            this.Cmd_Dlt.Text = "Supprimer";
            this.Cmd_Dlt.UseVisualStyleBackColor = true;
            this.Cmd_Dlt.Click += new System.EventHandler(this.Cmd_Dlt_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.BackColor = System.Drawing.Color.White;
            this.textBoxNom.Location = new System.Drawing.Point(293, 164);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(169, 22);
            this.textBoxNom.TabIndex = 8;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.BackColor = System.Drawing.Color.White;
            this.textBoxPrenom.Location = new System.Drawing.Point(293, 213);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(169, 22);
            this.textBoxPrenom.TabIndex = 9;
            // 
            // textBoxDateNaissance
            // 
            this.textBoxDateNaissance.BackColor = System.Drawing.Color.White;
            this.textBoxDateNaissance.Location = new System.Drawing.Point(293, 263);
            this.textBoxDateNaissance.Name = "textBoxDateNaissance";
            this.textBoxDateNaissance.Size = new System.Drawing.Size(169, 22);
            this.textBoxDateNaissance.TabIndex = 10;
            this.textBoxDateNaissance.TextChanged += new System.EventHandler(this.textBoxDateNaissance_TextChanged);
            // 
            // textBoxNumRue
            // 
            this.textBoxNumRue.BackColor = System.Drawing.Color.White;
            this.textBoxNumRue.Location = new System.Drawing.Point(293, 313);
            this.textBoxNumRue.Name = "textBoxNumRue";
            this.textBoxNumRue.Size = new System.Drawing.Size(169, 22);
            this.textBoxNumRue.TabIndex = 11;
            // 
            // textBoxCp
            // 
            this.textBoxCp.BackColor = System.Drawing.Color.White;
            this.textBoxCp.Location = new System.Drawing.Point(713, 167);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(169, 22);
            this.textBoxCp.TabIndex = 12;
            // 
            // textBoxVille
            // 
            this.textBoxVille.BackColor = System.Drawing.Color.White;
            this.textBoxVille.Location = new System.Drawing.Point(713, 217);
            this.textBoxVille.Name = "textBoxVille";
            this.textBoxVille.Size = new System.Drawing.Size(169, 22);
            this.textBoxVille.TabIndex = 13;
            this.textBoxVille.TextChanged += new System.EventHandler(this.textBoxVille_TextChanged);
            // 
            // Cmd_Mdf
            // 
            this.Cmd_Mdf.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Mdf.Location = new System.Drawing.Point(637, 47);
            this.Cmd_Mdf.Name = "Cmd_Mdf";
            this.Cmd_Mdf.Size = new System.Drawing.Size(176, 63);
            this.Cmd_Mdf.TabIndex = 14;
            this.Cmd_Mdf.Text = "Modifier";
            this.Cmd_Mdf.UseVisualStyleBackColor = true;
            this.Cmd_Mdf.Click += new System.EventHandler(this.Cmd_Mdf_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(518, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Club :";
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(713, 268);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(169, 24);
            this.comboBoxClub.TabIndex = 16;
            this.comboBoxClub.UseWaitCursor = true;
            // 
            // Rst_All
            // 
            this.Rst_All.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_All.Image = ((System.Drawing.Image)(resources.GetObject("Rst_All.Image")));
            this.Rst_All.Location = new System.Drawing.Point(293, 68);
            this.Rst_All.Name = "Rst_All";
            this.Rst_All.Size = new System.Drawing.Size(51, 34);
            this.Rst_All.TabIndex = 17;
            this.Rst_All.UseVisualStyleBackColor = false;
            this.Rst_All.Click += new System.EventHandler(this.Rst_All_Click);
            // 
            // Rst_nom
            // 
            this.Rst_nom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_nom.Image = ((System.Drawing.Image)(resources.GetObject("Rst_nom.Image")));
            this.Rst_nom.Location = new System.Drawing.Point(468, 158);
            this.Rst_nom.Name = "Rst_nom";
            this.Rst_nom.Size = new System.Drawing.Size(51, 34);
            this.Rst_nom.TabIndex = 18;
            this.Rst_nom.UseVisualStyleBackColor = false;
            this.Rst_nom.Click += new System.EventHandler(this.Rst_nom_Click);
            // 
            // Rst_prenom
            // 
            this.Rst_prenom.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_prenom.Image = ((System.Drawing.Image)(resources.GetObject("Rst_prenom.Image")));
            this.Rst_prenom.Location = new System.Drawing.Point(468, 207);
            this.Rst_prenom.Name = "Rst_prenom";
            this.Rst_prenom.Size = new System.Drawing.Size(51, 34);
            this.Rst_prenom.TabIndex = 19;
            this.Rst_prenom.UseVisualStyleBackColor = false;
            this.Rst_prenom.Click += new System.EventHandler(this.Rst_prenom_Click_1);
            // 
            // Rst_adr
            // 
            this.Rst_adr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_adr.Image = ((System.Drawing.Image)(resources.GetObject("Rst_adr.Image")));
            this.Rst_adr.Location = new System.Drawing.Point(468, 307);
            this.Rst_adr.Name = "Rst_adr";
            this.Rst_adr.Size = new System.Drawing.Size(51, 34);
            this.Rst_adr.TabIndex = 21;
            this.Rst_adr.UseVisualStyleBackColor = false;
            this.Rst_adr.Click += new System.EventHandler(this.Rst_adr_Click_1);
            // 
            // Rst_date
            // 
            this.Rst_date.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_date.Image = ((System.Drawing.Image)(resources.GetObject("Rst_date.Image")));
            this.Rst_date.Location = new System.Drawing.Point(468, 255);
            this.Rst_date.Name = "Rst_date";
            this.Rst_date.Size = new System.Drawing.Size(51, 34);
            this.Rst_date.TabIndex = 20;
            this.Rst_date.UseVisualStyleBackColor = false;
            this.Rst_date.Click += new System.EventHandler(this.Rst_date_Click_1);
            // 
            // Rst_ville
            // 
            this.Rst_ville.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_ville.Image = ((System.Drawing.Image)(resources.GetObject("Rst_ville.Image")));
            this.Rst_ville.Location = new System.Drawing.Point(888, 210);
            this.Rst_ville.Name = "Rst_ville";
            this.Rst_ville.Size = new System.Drawing.Size(51, 34);
            this.Rst_ville.TabIndex = 23;
            this.Rst_ville.UseVisualStyleBackColor = false;
            this.Rst_ville.Click += new System.EventHandler(this.Rst_ville_Click_1);
            // 
            // Rst_cp
            // 
            this.Rst_cp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_cp.Image = ((System.Drawing.Image)(resources.GetObject("Rst_cp.Image")));
            this.Rst_cp.Location = new System.Drawing.Point(888, 161);
            this.Rst_cp.Name = "Rst_cp";
            this.Rst_cp.Size = new System.Drawing.Size(51, 34);
            this.Rst_cp.TabIndex = 22;
            this.Rst_cp.UseVisualStyleBackColor = false;
            this.Rst_cp.Click += new System.EventHandler(this.Rst_cp_Click_1);
            // 
            // Rst_club
            // 
            this.Rst_club.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rst_club.Image = ((System.Drawing.Image)(resources.GetObject("Rst_club.Image")));
            this.Rst_club.Location = new System.Drawing.Point(888, 263);
            this.Rst_club.Name = "Rst_club";
            this.Rst_club.Size = new System.Drawing.Size(51, 34);
            this.Rst_club.TabIndex = 24;
            this.Rst_club.UseVisualStyleBackColor = false;
            this.Rst_club.Click += new System.EventHandler(this.Rst_club_Click_1);
            // 
            // Frm_GestionMembres_MS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 411);
            this.Controls.Add(this.Rst_club);
            this.Controls.Add(this.Rst_ville);
            this.Controls.Add(this.Rst_cp);
            this.Controls.Add(this.Rst_adr);
            this.Controls.Add(this.Rst_date);
            this.Controls.Add(this.Rst_prenom);
            this.Controls.Add(this.Rst_nom);
            this.Controls.Add(this.Rst_All);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.Cmd_Mdf);
            this.Controls.Add(this.textBoxVille);
            this.Controls.Add(this.textBoxCp);
            this.Controls.Add(this.textBoxNumRue);
            this.Controls.Add(this.textBoxDateNaissance);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.Cmd_Dlt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxLicences);
            this.Name = "Frm_GestionMembres_MS";
            this.Text = "Modifier les membres";
            this.Load += new System.EventHandler(this.Frm_GestionMembres_MS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLicences;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cmd_Dlt;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxDateNaissance;
        private System.Windows.Forms.TextBox textBoxNumRue;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.TextBox textBoxVille;
        private System.Windows.Forms.Button Cmd_Mdf;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxClub;
        private System.Windows.Forms.Button Rst_All;
        private System.Windows.Forms.Button Rst_nom;
        private System.Windows.Forms.Button Rst_prenom;
        private System.Windows.Forms.Button Rst_adr;
        private System.Windows.Forms.Button Rst_date;
        private System.Windows.Forms.Button Rst_ville;
        private System.Windows.Forms.Button Rst_cp;
        private System.Windows.Forms.Button Rst_club;
    }
}