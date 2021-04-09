using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNotes.entites;
using GestionNotes.services;

namespace GestionNotes
{
    public partial class FenInscription : Form
    {
        public static Regex LETTER_ONLY_RGX = new Regex(@"^[a-zA-Z]+$");
        public static Regex EMAIL_RGX = 
            new Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*@((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))\z");

        public FenInscription()
        {
            InitializeComponent();
            
        }


        private void CreerCompte()
        {
            String email = EmailField.Text;
            String prenom = PrenomField.Text;
            String nom = NomField.Text;
            String pass = PassField.Text;
            Enseignant prof = new Enseignant(nom, prenom, email, pass);
            if (EnseignantServices.AjouterEnseignant(prof))
            {
                MessageBox.Show("Votre compte a été créé.", "Bienvenue ! :) ");
                EffacerContenuTextBox();
                Hide();
                new FenConnexion().ShowDialog();
            } else
            {
                /* Puisque la validation de la saise a ete fait avant d'envoyer 
                   a la bd, la seule raison pour laquelle une exception pourrait arriver
                    est si le email est deja utilise */
                MessageBox.Show("Ce email a déjà été utilisé.", "Oups");
            }
        }

        private void BtnCreerCompte_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                CreerCompte();
            } else
            {
                MessageBox.Show("Veuillez valider toutes vos saisies avant.", "Erreur",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void EmailField_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(EmailField.Text.Trim()))
            {
                e.Cancel = true;
                epEmailField.SetError(EmailField, "Email obligatoire");
            } 
            else if (!EMAIL_RGX.IsMatch(EmailField.Text))
            {
                e.Cancel = true;
                epEmailField.SetError(EmailField, "Format du email invalide.");
            } 
            else
            {
                e.Cancel = false;
                epEmailField.SetError(EmailField, "");
            }
        }

        private void PrenomField_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PrenomField.Text.Trim()))
            {
                e.Cancel = true;
                epPrenomField.SetError(PrenomField, "Prénom obligatoire");
            } else if (!LETTER_ONLY_RGX.IsMatch(PrenomField.Text))
            {
                e.Cancel = true;
                epPrenomField.SetError(PrenomField, "Caractère(s) invalide(s)");
            }
            else
            {
                e.Cancel = false;
                epPrenomField.SetError(PrenomField, "");
            }
        }

        private void NomField_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NomField.Text.Trim()))
            {
                e.Cancel = true;
                epNomField.SetError(NomField, "Nom obligatoire");
            } else if (!LETTER_ONLY_RGX.IsMatch(NomField.Text))
            {
                e.Cancel = true;
                epNomField.SetError(NomField, "Caractère(s) invalide(s)");
            }
            else
            {
                e.Cancel = false;
                epNomField.SetError(NomField, "");
            }
        }

        private void PassField_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(PassField.Text.Trim()))
            {
                e.Cancel = true;
                epPassField.SetError(PassField, "Pass obligatoire");
            } else if (PassField.Text != ConfirmPassField.Text)
            {
                e.Cancel = true;
                epPassField.SetError(PassField, "Vos mots de passes doivent correspondre.");
                epConfirmPassField.SetError(ConfirmPassField, "Vos mots de passes doivent correspondre.");
            }
            else
            {
                e.Cancel = false;
                epPassField.SetError(PassField, "");
            }
        }

        private void ConfirmPassField_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPassField.Text.Trim()))
            {
                e.Cancel = true;
                epConfirmPassField.SetError(ConfirmPassField, "Confirmation du pass obligatoire");
            } else if (PassField.Text != ConfirmPassField.Text)
            {
                e.Cancel = true;
                epPassField.SetError(PassField, "Vos mots de passes doivent correspondre.");
                epConfirmPassField.SetError(ConfirmPassField, "Vos mots de passes doivent correspondre.");
            }
            else
            {
                e.Cancel = false;
                epConfirmPassField.SetError(ConfirmPassField, "");
            }
        }

        private void VoirPassChkBox_Click(object sender, EventArgs e)
        {
            if (voirPassChkBox.Checked)
            {
                PassField.PasswordChar = '\0';
                ConfirmPassField.PasswordChar = '\0';
            } 
            else
            {
                PassField.PasswordChar = '*';
                ConfirmPassField.PasswordChar = '*';
            }
        }

        private void EffacerContenuTextBox()
        {
            EmailField.Clear();  NomField.Clear();  PrenomField.Clear();
            PassField.Clear();  ConfirmPassField.Clear();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();
            new FenConnexion().ShowDialog();
        }
    }
    }


