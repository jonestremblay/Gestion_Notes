using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotes.entites;
using GestionNotes.ADO;

namespace GestionNotes.services
{
    abstract class EnseignantServices
    {
        public static bool AjouterEnseignant(Enseignant prof)
        {
            return new EnseignantSQL().CreerEnseignant(prof);
        }

        public static Enseignant GetEnseignantParEmail(String email)
        {
            return new EnseignantSQL().GetEnseignantParEmail(email);
        }
    }
}
