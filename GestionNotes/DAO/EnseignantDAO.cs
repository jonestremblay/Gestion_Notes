using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionNotes.entites;

namespace GestionNotes.DAO
{
    interface EnseignantDAO
    {
        bool CreerEnseignant(Enseignant prof);
        Enseignant GetEnseignantParEmail(String email);
    }
}
