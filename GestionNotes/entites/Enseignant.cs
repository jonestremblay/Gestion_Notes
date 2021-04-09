using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionNotes.entites
{
    class Enseignant
    {
        int idProf;
        String nom, prenom;
        String email, passwd;

        public Enseignant()
        {
        }

        public Enseignant(string nom, string prenom, string email, string passwd)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.passwd = passwd;
        }

        public Enseignant(int idProf, string nom, string prenom, string email, string passwd)
        {
            this.idProf = idProf;
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.passwd = passwd;
        }

        public int IdProf
        {
            get { return idProf; }
            set { idProf = value; }
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

        public String Passwd
        {
            get { return passwd; }
            set { passwd = value; }
        }

        public override string ToString()
        {
            // return base.ToString();
            return "Enseignant [id,prenom,nom,email,pass]: "
                 + this.idProf + ", " + this.prenom + ", "
                 + this.nom + ", " + this.email + ", "
                 + this.passwd;
        }
    }
}
