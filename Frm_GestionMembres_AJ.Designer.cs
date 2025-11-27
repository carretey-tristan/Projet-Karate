namespace karaté_mission_1
{
    partial class Frm_GestionMembres_AJ
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
            this.Date_Naissance = new System.Windows.Forms.DateTimePicker();
            this.Cmd_Ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Ville = new System.Windows.Forms.TextBox();
            this.Txt_Prenom = new System.Windows.Forms.TextBox();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_Adr = new System.Windows.Forms.TextBox();
            this.Txt_Cp = new System.Windows.Forms.TextBox();
            this.Txt_NumLicence = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxClub = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Date_Naissance
            // 
            this.Date_Naissance.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Naissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Naissance.Location = new System.Drawing.Point(243, 186);
            this.Date_Naissance.Name = "Date_Naissance";
            this.Date_Naissance.Size = new System.Drawing.Size(282, 27);
            this.Date_Naissance.TabIndex = 23;
            this.Date_Naissance.Value = new System.DateTime(2025, 1, 15, 0, 0, 0, 0);
            this.Date_Naissance.ValueChanged += new System.EventHandler(this.Date_Naissance_ValueChanged);
            // 
            // Cmd_Ajouter
            // 
            this.Cmd_Ajouter.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmd_Ajouter.Location = new System.Drawing.Point(26, 343);
            this.Cmd_Ajouter.Name = "Cmd_Ajouter";
            this.Cmd_Ajouter.Size = new System.Drawing.Size(156, 56);
            this.Cmd_Ajouter.TabIndex = 21;
            this.Cmd_Ajouter.Text = "AJOUTER";
            this.Cmd_Ajouter.UseVisualStyleBackColor = true;
            this.Cmd_Ajouter.Click += new System.EventHandler(this.Cmd_Ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ville :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Date de naissance :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Prenom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nom :";
            // 
            // Txt_Ville
            // 
            this.Txt_Ville.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_Ville.Location = new System.Drawing.Point(673, 139);
            this.Txt_Ville.Name = "Txt_Ville";
            this.Txt_Ville.Size = new System.Drawing.Size(271, 23);
            this.Txt_Ville.TabIndex = 16;
            this.Txt_Ville.TextChanged += new System.EventHandler(this.Txt_Ville_TextChanged);
            // 
            // Txt_Prenom
            // 
            this.Txt_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_Prenom.Location = new System.Drawing.Point(243, 279);
            this.Txt_Prenom.Name = "Txt_Prenom";
            this.Txt_Prenom.Size = new System.Drawing.Size(282, 23);
            this.Txt_Prenom.TabIndex = 15;
            this.Txt_Prenom.TextChanged += new System.EventHandler(this.Txt_Prenom_TextChanged);
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_Nom.Location = new System.Drawing.Point(243, 238);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(282, 23);
            this.Txt_Nom.TabIndex = 14;
            this.Txt_Nom.TextChanged += new System.EventHandler(this.Txt_Nom_TextChanged);
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(26, 65);
            this.labelTitre.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(496, 36);
            this.labelTitre.TabIndex = 13;
            this.labelTitre.Text = "GESTION DES MEMBRE [AJOUTER]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 24;
            this.label5.Text = "Addresse :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(527, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Code Postal :";
            // 
            // Txt_Adr
            // 
            this.Txt_Adr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_Adr.Location = new System.Drawing.Point(673, 184);
            this.Txt_Adr.Name = "Txt_Adr";
            this.Txt_Adr.Size = new System.Drawing.Size(271, 23);
            this.Txt_Adr.TabIndex = 26;
            this.Txt_Adr.TextChanged += new System.EventHandler(this.Txt_Adr_TextChanged);
            // 
            // Txt_Cp
            // 
            this.Txt_Cp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_Cp.Location = new System.Drawing.Point(673, 228);
            this.Txt_Cp.Name = "Txt_Cp";
            this.Txt_Cp.Size = new System.Drawing.Size(271, 23);
            this.Txt_Cp.TabIndex = 27;
            this.Txt_Cp.TextChanged += new System.EventHandler(this.Txt_Cp_TextChanged);
            // 
            // Txt_NumLicence
            // 
            this.Txt_NumLicence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Txt_NumLicence.Location = new System.Drawing.Point(243, 143);
            this.Txt_NumLicence.Name = "Txt_NumLicence";
            this.Txt_NumLicence.Size = new System.Drawing.Size(282, 23);
            this.Txt_NumLicence.TabIndex = 28;
            this.Txt_NumLicence.TextChanged += new System.EventHandler(this.Txt_NumLicence_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 28);
            this.label7.TabIndex = 30;
            this.label7.Text = "Num Licence :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(527, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 32;
            this.label8.Text = "Club :";
            // 
            // comboBoxClub
            // 
            this.comboBoxClub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClub.FormattingEnabled = true;
            this.comboBoxClub.Location = new System.Drawing.Point(673, 276);
            this.comboBoxClub.Name = "comboBoxClub";
            this.comboBoxClub.Size = new System.Drawing.Size(271, 24);
            this.comboBoxClub.TabIndex = 34;
            this.comboBoxClub.SelectedIndexChanged += new System.EventHandler(this.comboBoxClub_SelectedIndexChanged);
            // 
            // Frm_GestionMembres_AJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(954, 411);
            this.Controls.Add(this.comboBoxClub);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_NumLicence);
            this.Controls.Add(this.Txt_Cp);
            this.Controls.Add(this.Txt_Adr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Date_Naissance);
            this.Controls.Add(this.Cmd_Ajouter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_Ville);
            this.Controls.Add(this.Txt_Prenom);
            this.Controls.Add(this.Txt_Nom);
            this.Controls.Add(this.labelTitre);
            this.Name = "Frm_GestionMembres_AJ";
            this.Text = "Ajout d\'un membre";
            this.Load += new System.EventHandler(this.Frm_GestionMembres_AJ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date_Naissance;
        private System.Windows.Forms.Button Cmd_Ajouter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Ville;
        private System.Windows.Forms.TextBox Txt_Prenom;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_Adr;
        private System.Windows.Forms.TextBox Txt_Cp;
        private System.Windows.Forms.TextBox Txt_NumLicence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxClub;
    }
}