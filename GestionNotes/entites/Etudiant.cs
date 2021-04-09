using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.entites
{
    class Etudiant
    {
        int numeroDA;
        String nom, prenom, email;

        public Etudiant()
        {

        }

        public Etudiant(string nom, string prenom, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
        }

        public Etudiant(int numeroDA, string nom, string prenom, string email)
        {
            this.numeroDA = numeroDA;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
        }

        public int NumeroDA
        {
            get { return numeroDA; }
            set { numeroDA = value; }
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public override string ToString()
        {
            //return base.ToString();
            return "Etudiant [numDA,prenom,nom,email]: "
                 + this.numeroDA + ", " + this.prenom + ", "
                 + this.nom + ", " + this.email;
        }
    }
}
