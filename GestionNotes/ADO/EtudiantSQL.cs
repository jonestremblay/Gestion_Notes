using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotes.DAO;
using GestionNotes.entites;
using MySql.Data.MySqlClient;

namespace GestionNotes.ADO.EtudiantSQL
{
    class EtudiantSQL : EtudiantDAO
    {

        /// <summary>
        /// Permet de creer un etudiant dans la base de donnne.
        /// </summary>
        /// <param name="etudiant"></param>
        /// <returns>True si l'etudiant a ete ajoute a la BD.</returns>
        public bool CreerEtudiant(Etudiant etudiant)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            String requete = "INSERT INTO etudiants (nom, prenom, email) "
                           + "VALUES ( @prenom, @nom, @email)";
            bool aEteCree = false;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("prenom", etudiant.Prenom));
                cmd.Parameters.Add(new MySqlParameter("nom", etudiant.Nom));
                cmd.Parameters.Add(new MySqlParameter("email", etudiant.Email));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    aEteCree = true;
                }
                else { cnx.Close(); aEteCree = false; }
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aEteCree;
        }

        /// <summary>
        /// Permet d'obtenir l'etudiant de la base de donnees selon le 
        /// email donnee en parametre.
        /// </summary>
        /// <param name="email"></param>
        /// <returns>Objet Etudiant vide si aucune correspondance avec la BD </returns>
        public Etudiant GetEtudiantParEmail(String email)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            DbDataReader dr = null;
            String requete = "SELECT * FROM etudiants WHERE email = @email";
            Etudiant etudiantTrouve = new Etudiant();
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
                    int numeroDA = Int32.Parse(dr["num_da"].ToString());
                    String nom = dr["nom"].ToString();
                    String prenom = dr["prenom"].ToString();
                    etudiantTrouve.NumeroDA = numeroDA;
                    etudiantTrouve.Nom = nom;
                    etudiantTrouve.Prenom = prenom;
                    etudiantTrouve.Email = email;
                }
                dr.Close();
                cnx.Close();
                return etudiantTrouve;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dr.Close();
            cnx.Close();
            return etudiantTrouve;
        }

        /// <summary>
        /// Permet d'obtenir l'etudiant de la base de donnees selon le 
        /// numeroDA donnee en parametre.
        /// </summary>
        /// <param name="numeroDA"></param>
        /// <returns>Objet Etudiant vide si aucune correspondance avec la BD </returns>
        public Etudiant GetEtudiantParNumDA(int numeroDA)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            DbDataReader dr = null;
            String requete = "SELECT * FROM etudiants WHERE num_da = @numeroDA";
            Etudiant etudiantTrouve = new Etudiant();
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("numeroDA", numeroDA));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String nom = dr["nom"].ToString();
                    String prenom = dr["prenom"].ToString();
                    String email = dr["email"].ToString();
                    etudiantTrouve.NumeroDA = numeroDA;
                    etudiantTrouve.Nom = nom;
                    etudiantTrouve.Prenom = prenom;
                    etudiantTrouve.Email = email;
                }
                dr.Close();
                cnx.Close();
                return etudiantTrouve;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            dr.Close();
            cnx.Close();
            return etudiantTrouve;
        }

        /// <summary>
        /// Permet d'obtenir la liste des étudiants inscris
        /// au cours donnee en parametre.
        /// </summary>
        /// <param name="id_cours"></param>
        /// <returns>Lste d'etudiants inscris au cours en param.</returns>
        public List<Etudiant> GetEtudiantsDuCours(int id_cours)
        {
            DbConnection cnx = null;
            DbCommand cmd = null;
            DbDataReader dr = null;
            String requete = "SELECT * FROM etudiant_cours ec "
                           + "JOIN etudiants e ON (ec.num_da=e.num_da) "
                           + "JOIN cours c ON (ec.id_cours=c.id_cours) "
                           + "WHERE c.id_cours= @idCours";
            List<Etudiant> listeEtudiant = new List<Etudiant>();
            Etudiant etudiant = null;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("idCours", id_cours));

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int numeroDA = Int32.Parse(dr["num_da"].ToString());
                    String nom = dr["nom"].ToString();
                    String prenom = dr["prenom"].ToString();
                    String email = dr["email"].ToString();
                    etudiant = new Etudiant(numeroDA, nom, prenom, email);
                    listeEtudiant.Add(etudiant);
                }
                dr.Close();
                cnx.Close();
                return listeEtudiant;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (cnx != null)
                {
                    cnx.Close();
                }
            }
            return listeEtudiant;
        }

        /// <summary>
        /// Permet de modifier un etudiant selon son numeroDA,
        /// avec l'objet etudiant donne en param
        /// </summary>
        /// <param name="numeroDA"></param>
        /// <param name="etudiantModifie"></param>
        /// <returns>True si etudiant a ete modifier dans la BD</returns>
        public bool ModifierEtudiant(int numeroDA, Etudiant etudiantModifie)
        {
            /* Seule methode qui doit etre fix, ne fonctionne pas */
            DbConnection cnx = null;
            DbCommand cmd = null;
            String requete = "UPDATE etudiants SET nom = @nom , prenom = @prenom , email = @email "
                           + "WHERE num_da = @numeroDA ";
            bool aEteModifie = false;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("nom", etudiantModifie.Nom));
                cmd.Parameters.Add(new MySqlParameter("prenom", etudiantModifie.Prenom));
                cmd.Parameters.Add(new MySqlParameter("email", etudiantModifie.Email));
                cmd.Parameters.Add(new MySqlParameter("numeroDA", etudiantModifie.NumeroDA));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    aEteModifie = true;
                }
                else { cnx.Close(); aEteModifie = false; }
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aEteModifie;
        }

        /// <summary>
        /// Permet de retirer un etudiant d'un cours.
        /// </summary>
        /// <param name="numeroDA"></param>
        /// <param name="id_cours"></param>
        /// <returns>True si etudiant a ete retirer du cours</returns>
        public bool RetirerEtudiantCours(int numeroDA, int id_cours)
        {
            /* Methode qui va probablement evolue : s'assurer que la suppression
             se fais dans toutes les tables necessaires (evaluations par exemple) */
            DbConnection cnx = null;
            DbCommand cmd = null;
            String requete = "DELETE FROM etudiant_cours WHERE num_da = @numeroDA "
                           + " AND id_cours = @idCours ";
            bool aEteRetirer = false;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("numeroDA", numeroDA));
                cmd.Parameters.Add(new MySqlParameter("idCours", id_cours));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    aEteRetirer = true;
                }
                else { cnx.Close(); aEteRetirer = false; }
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aEteRetirer;
        }


        /// <summary>
        /// Permet de supprimer definitivement un etudiant de la base de donnees.
        /// Supprime donc dans la table <etudiant_cours>, et ensuite <etudiants>.
        /// </summary>
        /// <param name="numeroDA"></param>
        /// <returns>True si etudiant a ete supprimer de la BD</returns>
        public bool SupprimerEtudiant(int numeroDA)
        {
            /* Methode qui va probablement evolue : s'assurer que la suppression
             se fais dans toutes les tables necessaires (evaluations par exemple)*/
            DbConnection cnx = null;
            DbCommand cmd = null;
            String requete = "DELETE FROM etudiant_cours WHERE num_da = @numeroDA ;"
                           + "DELETE FROM etudiants WHERE num_da = @numeroDA ";
            bool aEteSupprimer = false;
            try
            {
                cnx = Database.GetConnection();
                cmd = cnx.CreateCommand();
                cmd.CommandText = requete;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new MySqlParameter("numeroDA", numeroDA));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    aEteSupprimer = true;
                }
                else { cnx.Close(); aEteSupprimer = false; }
                cnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return aEteSupprimer;
        }
    }
}
