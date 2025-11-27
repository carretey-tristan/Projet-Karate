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


namespace karaté_mission_1
{
    public partial class Frm_GestionMembres_AJ : Form
    {
        public Frm_GestionMembres_AJ()
        {
            InitializeComponent();
            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();
            string sql = "SELECT NOM_CLUB, NUM_CLUB from club";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nomClub = reader["NOM_CLUB"].ToString();
                string numClub = reader["NUM_CLUB"].ToString();
                comboBoxClub.Items.Add($"{nomClub} | {numClub}");
            }
            conn.Close();
        }

        private void Frm_GestionMembres_AJ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Txt_Nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Prenom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Date_Naissance_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Ville_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Adr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txt_Cp_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmd_Ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_NumLicence.Text) ||
                string.IsNullOrWhiteSpace(Txt_Nom.Text) ||
                string.IsNullOrWhiteSpace(Txt_Prenom.Text) ||
                string.IsNullOrWhiteSpace(Txt_Adr.Text) ||
                string.IsNullOrWhiteSpace(Txt_Cp.Text) ||
                string.IsNullOrWhiteSpace(Txt_Ville.Text) ||
                comboBoxClub.SelectedItem == null)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }
            MySqlConnection connex = BddConnexion.ConnectBD();
            connex.Open();
            string req = "SELECT COUNT(*) FROM membre WHERE NUM_LICENCE = @numLicence";
            MySqlCommand comd = new MySqlCommand(req, connex);
            comd.Parameters.AddWithValue("@numLicence", Txt_NumLicence.Text);
            int count = Convert.ToInt32(comd.ExecuteScalar());
            if (count > 0)
            {
                MessageBox.Show("Numéro de licence déjà existant");
                connex.Close();
                return;
            }
            connex.Close();

            string numLicence = Txt_NumLicence.Text;
            string selectedText = comboBoxClub.SelectedItem.ToString();
            string numClub = selectedText.Split('|')[1].Trim();
            string nomMembre = Txt_Nom.Text;
            string prenomMembre = Txt_Prenom.Text;
            string dateNaissance = Date_Naissance.Value.ToString("yyyy-MM-dd");
            string adrRueMembre = Txt_Adr.Text;
            string codePostMembre = Txt_Cp.Text;
            string adrVilleMembre = Txt_Ville.Text;

            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();

            string sql = "INSERT INTO `membre`(`NUM_LICENCE`, `NUM_CLUB`, `NOM_MEMBRE`, `PRENOM_MEMBRE`, `DATE_NAISSANCE`, `ADR_RUE_MEMBRE`, `CODE_POST_MEMBRE`, `ADR_VILLE_MEMBRE`) " +
                         "VALUES (@numLicence, @numClub, @nomMembre, @prenomMembre, @dateNaissance, @adrRueMembre, @codePostMembre, @adrVilleMembre)";
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
            MessageBox.Show("Membre n°" + numLicence + " ajouté");
            Txt_NumLicence.Clear();
            Txt_Nom.Clear();
            Txt_Prenom.Clear();
            Txt_Adr.Clear();
            Txt_Cp.Clear();
            Txt_Ville.Clear();

            conn.Close();
        }

        private void Cmd_Fermer_Click(object sender, EventArgs e)
        {

        }

        private void Txt_NumLicence_TextChanged(object sender, EventArgs e)
        {

        }

        /*private void ajoutDuneLicenceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Frm_GestionMembres_AJ formAjoutLicence = new Frm_GestionMembres_AJ();
            formAjoutLicence.Show();
            this.Hide();
        }

        private void modificationDUnMembreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestionMembres_MS formGestionMembres = new Frm_GestionMembres_MS();
            formGestionMembres.Show();
            this.Hide();
        }*/

        private void Frm_GestionMembres_AJ_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
