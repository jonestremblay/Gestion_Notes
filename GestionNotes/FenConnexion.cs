using GestionNotes.entites;
using GestionNotes.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionNotes
{
    public partial class FenConnexion : Form
    {
        public FenConnexion()
        {
            InitializeComponent();
            EmailField.Text = Properties.Settings.Default.RememberedEmail;
            RememberEmailChkBox.Checked = Properties.Settings.Default.RememberedEmailCheckBox;
        }

        private void BtnConnexion_Click(object sender, EventArgs e)
        {
            ConnexionCompte();
        }

        private void ConnexionCompte()
        {
            if (!EmailField.Text.Equals("") && !PassField.Text.Equals(""))
            {
                /* Vérifier dans la base de données le user input*/
                Enseignant prof = EnseignantServices.GetEnseignantParEmail(EmailField.Text);
                 if(EmailField.Text.Equals(prof.Email) && PassField.Text.Equals(prof.Passwd)) {
                       
                       /* Loader la prochaine fenetre */


                       /* Enregistre le email saisi dans la fenetre si user coche checkbox. */
                       if (RememberEmailChkBox.Checked){
                        Properties.Settings.Default.RememberedEmail = prof.Email;
                        Properties.Settings.Default.RememberedEmailCheckBox = true;
                        Properties.Settings.Default.Save();
                       } else {  
                        Properties.Settings.Default.RememberedEmail = "";
                        Properties.Settings.Default.RememberedEmailCheckBox = false;
                        Properties.Settings.Default.Save();
                    }
                    MessageBox.Show("Connecté ! On peut donc ouvrir l'appli maintenant.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else { 
                     MessageBox.Show("Votre saisie ne correspond pas à nos archives.",
                    "Données invalides");
                 }
            }
            else
            {
                MessageBox.Show("Veuillez inscrire votre email et votre mot de passe",
                    "Données manquantes");
            }
        }

        private void LabelCreerCompte_Click(object sender, EventArgs e)
        {
            FenInscription fenInscription = new FenInscription();
            Hide();
            fenInscription.ShowDialog();

        }

        private void VoirPassChkBox_Click(object sender, EventArgs e)
        {    
                if (voirPassChkBox.Checked)
                {
                    PassField.PasswordChar = '\0';  
                }
                else
                {
                    PassField.PasswordChar = '*';    
                }
        }
    }
}
