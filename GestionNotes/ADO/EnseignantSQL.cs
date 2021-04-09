using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotes.entites;
using GestionNotes.DAO;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace GestionNotes.ADO
{
    class EnseignantSQL : EnseignantDAO
    {
        /// <summary>
        /// Ajoute un enseignant a la base de donnees
        /// </summary>
        /// <param name="prof"></param>
        /// <returns>True si a ete ajoute a la base de donnee</returns>
        public bool CreerEnseignant(Enseignant prof)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            String requete = "INSERT INTO enseignants (nom, prenom, email, passwd) "
                           + "VALUES ( @prenom, @nom, @email, @passwd )";
            bool aEteCree = false;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("prenom", prof.Prenom));
                cmd.Parameters.Add(new MySqlParameter("nom", prof.Nom));
                cmd.Parameters.Add(new MySqlParameter("email", prof.Email));
                cmd.Parameters.Add(new MySqlParameter("passwd", prof.Passwd));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    aEteCree = true;
                } else { cnx.Close(); aEteCree = false; }
                cnx.Close();
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aEteCree;
        }

        /// <summary>
        /// Obtient l'enseignant de la base de donnée, selon le
        /// email entre en parametre.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Objet Enseignant vide si aucune correspondance avec la BD </returns>
        public Enseignant GetEnseignantParEmail(String email)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            DbDataReader dr = null;
            String requete = "SELECT * FROM enseignants WHERE email = @email";
            Enseignant profTrouve = new Enseignant();
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("email", email));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int idProf = Int32.Parse(dr["id_prof"].ToString());
                    String nom = dr["nom"].ToString();
                    String prenom = dr["prenom"].ToString();
                    String pass = dr["passwd"].ToString();
                    profTrouve.IdProf = idProf;
                    profTrouve.Email = email;
                    profTrouve.Nom = nom;
                    profTrouve.Prenom = prenom;
                    profTrouve.Passwd = pass;
                }
                dr.Close();
                cnx.Close();
                return profTrouve;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dr.Close();
            cnx.Close();
            return profTrouve;
        }
    }
}
