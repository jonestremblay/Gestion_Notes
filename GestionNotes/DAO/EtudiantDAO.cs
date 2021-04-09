using GestionNotes.entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.DAO
{
    interface EtudiantDAO
    {
        bool CreerEtudiant(Etudiant etudiant);
        bool SupprimerEtudiant(int numeroDA);
        bool ModifierEtudiant(int numeroDA, Etudiant etudiantModifie);
        Etudiant GetEtudiantParNumDA(int numeroDA);
        Etudiant GetEtudiantParEmail(String email);
        List<Etudiant> GetEtudiantsDuCours(int id_cours);

        bool RetirerEtudiantCours(int numeroDA, int id_cours);
    }
}
