using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotes.DAO;
using GestionNotes.entites;
using GestionNotes.ADO.EtudiantSQL;

namespace GestionNotes.services
{
    abstract class EtudiantServices
    {
        public static bool CreerEtudiant(Etudiant etudiant)
        {
            return new EtudiantSQL().CreerEtudiant(etudiant);
        }

        public static bool SupprimerEtudiant(int numeroDA)
        {
            return new EtudiantSQL().SupprimerEtudiant(numeroDA);
        }

        public static bool ModifierEtudiant(int numeroDA, Etudiant etudiantModifie)
        {
            return new EtudiantSQL().ModifierEtudiant(numeroDA, etudiantModifie);
        }

        public static Etudiant GetEtudiantParNumDA(int numeroDA)
        {
            return new EtudiantSQL().GetEtudiantParNumDA(numeroDA);
        }

        public static Etudiant GetEtudiantParEmail(String email)
        {
            return new EtudiantSQL().GetEtudiantParEmail(email);
        }

        public static List<Etudiant> GetEtudiantsDuCours(int idCours)
        {
            return new EtudiantSQL().GetEtudiantsDuCours(idCours);
        }

        public static bool RetirerEtudiantCours(int numeroDA, int id_cours)
        {
            return new EtudiantSQL().RetirerEtudiantCours(numeroDA, id_cours);
        }
    }
}
