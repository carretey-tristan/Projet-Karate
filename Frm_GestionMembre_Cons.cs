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
    public partial class Frm_GestionMembre_Cons : Form
    {
        public Frm_GestionMembre_Cons()
        {
            InitializeComponent();
            comboBoxClub.SelectedIndex = 0;
            Triebox.SelectedIndex = 0;
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

        private void Frm_GestionMembre_Cons_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();
            string sql = $"SELECT * FROM membre";
            string selectedText = comboBoxClub.SelectedItem.ToString();
            if (selectedText != "Aucun club")
            {
                string numClub = selectedText.Split('|')[1].Trim();

                sql = $"SELECT * FROM membre WHERE NUM_CLUB = {numClub}";
            }

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();


            dataGridView1.Rows.Clear();


            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["NUM_LICENCE"].ToString(),
                    reader["NOM_MEMBRE"].ToString(),
                    reader["PRENOM_MEMBRE"].ToString(),
                    Convert.ToDateTime(reader["DATE_NAISSANCE"]).ToString("yyyy-MM-dd"),
                    reader["ADR_RUE_MEMBRE"].ToString(),
                    reader["CODE_POST_MEMBRE"].ToString(),
                    reader["ADR_VILLE_MEMBRE"].ToString());
            }
            conn.Close();
            LoadData();
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Triebox_SelectedIndexChanged(object sender, EventArgs e)
        {

            LoadData();
        }

        private void LoadData()
        {
            MySqlConnection conn = BddConnexion.ConnectBD();
            conn.Open();
            string sql = "SELECT * FROM membre";
            string selectedText = comboBoxClub.SelectedItem?.ToString();
            if (selectedText != null && selectedText != "Aucun club")
            {
                string numClub = selectedText.Split('|')[1].Trim();
                sql = $"SELECT * FROM membre WHERE NUM_CLUB = {numClub}";
            }
            
            switch (Triebox.SelectedItem?.ToString())
            {
                case "Trie par ordre alphabétique A-Z":
                    sql += " ORDER BY NOM_MEMBRE ASC";
                    break;
                case "Trie par ordre alphabétique inversé Z-A":
                    sql += " ORDER BY NOM_MEMBRE DESC";
                    break;
                case "Trie par ordre croissant des dates de naissance":
                    sql += " ORDER BY DATE_NAISSANCE ASC";
                    break;
                case "Trie par ordre décroissant des dates de naissance":
                    sql += " ORDER BY DATE_NAISSANCE DESC";
                    break;
                case "Trie par ordre croissant des départements":
                    sql += " ORDER BY CODE_POST_MEMBRE ASC"; 
                    break;
                case "Trie par ordre décroissant des départements":
                    sql += " ORDER BY CODE_POST_MEMBRE DESC";
                    break;
                case "Trie par ordre croissant des numéros de licences":
                    sql += " ORDER BY NUM_LICENCE ASC";
                    break;
                case "Trie par ordre décroissant des numéros de licences":
                    sql += " ORDER BY NUM_LICENCE DESC";
                    break;
            }

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                dataGridView1.Rows.Add(
                    reader["NUM_LICENCE"].ToString(),
                    reader["NOM_MEMBRE"].ToString(),
                    reader["PRENOM_MEMBRE"].ToString(),
                    Convert.ToDateTime(reader["DATE_NAISSANCE"]).ToString("yyyy-MM-dd"),
                    reader["ADR_RUE_MEMBRE"].ToString(),
                    reader["CODE_POST_MEMBRE"].ToString(),
                    reader["ADR_VILLE_MEMBRE"].ToString());
            }
            conn.Close();
        }

    }
}
