using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projet_Karaté_mission1
{
    internal class BddConnexion
    {
        public static MySqlConnection ConnectBD()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=localhost; DATABASE=karate_db; UID=root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
    }
}
