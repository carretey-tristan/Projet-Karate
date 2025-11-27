using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Projet_Karaté_mission1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace karaté_mission_1
{
    public partial class Frm_GestionMembres_MS : Form
    {
        private string nom;
        private string prenom;
        private string dateNaissance;
        private string ville;
        private string numRue;
        private string cp;
        private string numClub;

        public Frm_GestionMembres_MS()
        {
            InitializeComponent();

            RendreBoutonTransparent(Rst_All);
            RendreBoutonTransparent(Rst_nom);
            RendreBoutonTransparent(Rst_prenom);
            RendreBoutonTransparent(Rst_date);
            RendreBoutonTransparent(Rst_adr);
            RendreBoutonTransparent(Rst_cp);
            RendreBoutonTransparent(Rst_ville);
            RendreBoutonTransparent(Rst_club);
            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();
            string sql = "SELECT NUM_LICENCE, NOM_MEMBRE, PRENOM_MEMBRE from membre";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string licence = reader["NUM_LICENCE"].ToString();
                nom = reader["NOM_MEMBRE"].ToString();
                prenom = reader["PRENOM_MEMBRE"].ToString();
                comboBoxLicences.Items.Add($"{licence} | {nom} {prenom}");
            }
            conn.Close();

            conn.Open();
            string req = "SELECT NOM_CLUB, NUM_CLUB from club";
            MySqlCommand stmt = new MySqlCommand(req, conn);
            MySqlDataReader rdr = stmt.ExecuteReader();
            while (rdr.Read())
            {
                string nomClub = rdr["NOM_CLUB"].ToString();
                string numClub = rdr["NUM_CLUB"].ToString();
                comboBoxClub.Items.Add($"{nomClub} | {numClub}");
            }
            conn.Close();
        }
        private void Frm_GestionMembres_MS_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void RendreBoutonTransparent(System.Windows.Forms.Button bouton)
        {
            bouton.FlatStyle = FlatStyle.Flat;
            bouton.FlatAppearance.BorderSize = 0;
            bouton.BackColor = Color.Transparent;
            bouton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bouton.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        private void comboBoxLicences_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();

            string selectedText = comboBoxLicences.SelectedItem.ToString();
            string numLicence = selectedText.Split('|')[0].Trim();

            string sql = "SELECT * from membre where NUM_LICENCE = @Licence";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Licence", numLicence);
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                nom = reader["NOM_MEMBRE"].ToString();
                textBoxNom.Text = nom;

                prenom = reader["PRENOM_MEMBRE"].ToString();
                textBoxPrenom.Text = prenom;

                DateTime dateNaissanceValue = Convert.ToDateTime(reader["DATE_NAISSANCE"]);
                dateNaissance = dateNaissanceValue.ToString("yyyy-MM-dd");
                textBoxDateNaissance.Text = dateNaissance;

                ville = reader["ADR_VILLE_MEMBRE"].ToString();
                textBoxVille.Text = ville;

                numRue = reader["ADR_RUE_MEMBRE"].ToString();
                textBoxNumRue.Text = numRue;

                cp = reader["CODE_POST_MEMBRE"].ToString();
                textBoxCp.Text = cp;

                numClub = reader["NUM_CLUB"].ToString();

                foreach (var item in comboBoxClub.Items)
                {
                    if (item.ToString().Split('|')[1].Trim() == numClub)
                    {
                        comboBoxClub.SelectedItem = item;
                        break;
                    }
                }
            }

            conn.Close();
        }

        private void Cmd_Dlt_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce membre ?", "Confirmation de suppression", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                MySqlConnection conn = BddConnexion.ConnectBD();
                conn.Open();
                string sql = "DELETE from membre where NUM_LICENCE = @Licence";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Licence", comboBoxLicences.SelectedItem.ToString().Split('|')[0].Trim());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Membre n°" + comboBoxLicences.SelectedItem.ToString() + " a bien été supprimé");
                comboBoxLicences.Items.Remove(comboBoxLicences.SelectedItem);
                textBoxNom.Text = "";
                textBoxPrenom.Text = "";
                textBoxDateNaissance.Text = "";
                textBoxVille.Text = "";
                textBoxNumRue.Text = "";
                textBoxCp.Text = "";
            }
        }

        private void Cmd_Mdf_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir modifier ce membre ?", "Confirmation de modification", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string selectedText = comboBoxLicences.SelectedItem.ToString();
                string numLicence = selectedText.Split('|')[0].Trim();

                string selectedClubText = comboBoxClub.SelectedItem.ToString();
                string numClub = selectedClubText.Split('|')[1].Trim();

                string nomMembre = textBoxNom.Text;
                string prenomMembre = textBoxPrenom.Text;
                string dateNaissance = textBoxDateNaissance.Text;
                string adrRueMembre = textBoxNumRue.Text;
                string codePostMembre = textBoxCp.Text;
                string adrVilleMembre = textBoxVille.Text;

                MySqlConnection conn = BddConnexion.ConnectBD();
                conn.Open();

                string sql = "UPDATE `membre` SET `NUM_LICENCE`=@numLicence, `NUM_CLUB`=@numClub, `NOM_MEMBRE`=@nomMembre, `PRENOM_MEMBRE`=@prenomMembre, `DATE_NAISSANCE`=@dateNaissance, `ADR_RUE_MEMBRE`=@adrRueMembre, `CODE_POST_MEMBRE`=@codePostMembre, `ADR_VILLE_MEMBRE`=@adrVilleMembre WHERE `NUM_LICENCE`=@numLicence";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@numLicence", numLicence);
                cmd.Parameters.AddWithValue("@numClub", numClub);
                cmd.Parameters.AddWithValue("@nomMembre", nomMembre);
                cmd.Parameters.AddWithValue("@prenomMembre", prenomMembre);
                cmd.Parameters.AddWithValue("@dateNaissance", dateNaissance);
                cmd.Parameters.AddWithValue("@adrRueMembre", adrRueMembre);
                cmd.Parameters.AddWithValue("@codePostMembre", codePostMembre);
                cmd.Parameters.AddWithValue("@adrVilleMembre", adrVilleMembre);

                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Membre n°" + numLicence + " a bien été modifié");
            }
        }

        private void textBoxDateNaissance_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVille_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rst_nom_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = nom;
        }

        private void Rst_prenom_Click_1(object sender, EventArgs e)
        {
            textBoxPrenom.Text = prenom;
        }

        private void Rst_date_Click_1(object sender, EventArgs e)
        {
            textBoxDateNaissance.Text = dateNaissance;
        }

        private void Rst_adr_Click_1(object sender, EventArgs e)
        {
            textBoxNumRue.Text = numRue;
        }

        private void Rst_cp_Click_1(object sender, EventArgs e)
        {
            textBoxCp.Text = cp;
        }

        private void Rst_ville_Click_1(object sender, EventArgs e)
        {
            textBoxVille.Text = ville;
        }

        private void Rst_club_Click_1(object sender, EventArgs e)
        {
            foreach (var item in comboBoxClub.Items)
            {
                if (item.ToString().Split('|')[1].Trim() == numClub)
                {
                    comboBoxClub.SelectedItem = item;
                    break;
                }
            }
        }

        private void Rst_All_Click(object sender, EventArgs e)
        {
            textBoxNom.Text = nom;
            textBoxPrenom.Text = prenom;
            textBoxDateNaissance.Text = dateNaissance;
            textBoxNumRue.Text = numRue;
            textBoxCp.Text = cp;
            textBoxVille.Text = ville;
            foreach (var item in comboBoxClub.Items)
            {
                if (item.ToString().Split('|')[1].Trim() == numClub)
                {
                    comboBoxClub.SelectedItem = item;
                    break;
                }
            }
        }

        private void Frm_GestionMembres_MS_Load(object sender, EventArgs e)
        {

        }
    }
}