using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace GestionNotes.DAO
{
    class Database
    {
        private static DbConnection cnx = null;
        //private static string ConnectionString = ConfigurationManager.ConnectionStrings["cnxStr"].ToString();
        /*
         La ligne précédente nécessite :
                1. de définir le nom cnxStr dans le fichier de configuration app.config
                2. d'inclure une référence à System.Configuration
                3. d'ajouter la clause : using System.Configuration;
         */
        //private static string connectionString = "Server=127.0.0.1;Uid=root;Pwd=;Database=gestion_notes";
        private static string connectionString = "Server=db.jonesdb.me;Uid=bdeb;Pwd=bdeb;Database=gestion_notes";
        public static DbConnection GetConnection()
        {
            if (cnx == null)
            {
                cnx = new MySqlConnection();
                cnx.ConnectionString = connectionString;
                cnx.Open();

            }
            else if (cnx.State == ConnectionState.Closed || cnx.State == ConnectionState.Broken)
            {
                cnx.Open();
            }
            return cnx;
        }
        public static void Close()
        {
            if (cnx != null)
            {
                cnx.Close();
            }

        }
    }
}
