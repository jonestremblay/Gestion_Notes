
namespace GestionNotes
{
    partial class FenInscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenInscription));
            this.PrenomField = new System.Windows.Forms.TextBox();
            this.NomField = new System.Windows.Forms.TextBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.ConfirmPassField = new System.Windows.Forms.TextBox();
            this.BtnCreerCompte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.epEmailField = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPrenomField = new System.Windows.Forms.ErrorProvider(this.components);
            this.epNomField = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPassField = new System.Windows.Forms.ErrorProvider(this.components);
            this.epConfirmPassField = new System.Windows.Forms.ErrorProvider(this.components);
            this.voirPassChkBox = new System.Windows.Forms.CheckBox();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmailField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenomField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNomField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassField)).BeginInit();
            this.SuspendLayout();
            // 
            // PrenomField
            // 
            this.PrenomField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrenomField.Location = new System.Drawing.Point(49, 152);
            this.PrenomField.Name = "PrenomField";
            this.PrenomField.Size = new System.Drawing.Size(179, 26);
            this.PrenomField.TabIndex = 1;
            this.PrenomField.Validating += new System.ComponentModel.CancelEventHandler(this.PrenomField_Validating);
            // 
            // NomField
            // 
            this.NomField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomField.Location = new System.Drawing.Point(49, 226);
            this.NomField.Name = "NomField";
            this.NomField.Size = new System.Drawing.Size(179, 26);
            this.NomField.TabIndex = 2;
            this.NomField.Validating += new System.ComponentModel.CancelEventHandler(this.NomField_Validating);
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.Location = new System.Drawing.Point(18, 78);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(246, 26);
            this.EmailField.TabIndex = 0;
            this.EmailField.Validating += new System.ComponentModel.CancelEventHandler(this.EmailField_Validating);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassField.Location = new System.Drawing.Point(49, 298);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(179, 26);
            this.PassField.TabIndex = 3;
            this.PassField.Validating += new System.ComponentModel.CancelEventHandler(this.PassField_Validating);
            // 
            // ConfirmPassField
            // 
            this.ConfirmPassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassField.Location = new System.Drawing.Point(49, 371);
            this.ConfirmPassField.Name = "ConfirmPassField";
            this.ConfirmPassField.PasswordChar = '*';
            this.ConfirmPassField.Size = new System.Drawing.Size(179, 26);
            this.ConfirmPassField.TabIndex = 4;
            this.ConfirmPassField.Validating += new System.ComponentModel.CancelEventHandler(this.ConfirmPassField_Validating);
            // 
            // BtnCreerCompte
            // 
            this.BtnCreerCompte.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnCreerCompte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCreerCompte.FlatAppearance.BorderSize = 0;
            this.BtnCreerCompte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnCreerCompte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreerCompte.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCreerCompte.Image = global::GestionNotes.Properties.Resources.btnCreer;
            this.BtnCreerCompte.Location = new System.Drawing.Point(73, 446);
            this.BtnCreerCompte.Name = "BtnCreerCompte";
            this.BtnCreerCompte.Size = new System.Drawing.Size(114, 53);
            this.BtnCreerCompte.TabIndex = 5;
            this.BtnCreerCompte.UseVisualStyleBackColor = false;
            this.BtnCreerCompte.Click += new System.EventHandler(this.BtnCreerCompte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GestionNotes.Properties.Resources.lblEmail;
            this.pictureBox1.Location = new System.Drawing.Point(93, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 36);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::GestionNotes.Properties.Resources.lblPrenom;
            this.pictureBox2.Location = new System.Drawing.Point(77, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 36);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::GestionNotes.Properties.Resources.lblNom;
            this.pictureBox3.Location = new System.Drawing.Point(106, 184);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(68, 36);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::GestionNotes.Properties.Resources.lblPass;
            this.pictureBox4.Location = new System.Drawing.Point(93, 258);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 34);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::GestionNotes.Properties.Resources.lblConfirmPass;
            this.pictureBox5.Location = new System.Drawing.Point(34, 330);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(213, 35);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // epEmailField
            // 
            this.epEmailField.BlinkRate = 500;
            this.epEmailField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epEmailField.ContainerControl = this;
            this.epEmailField.RightToLeft = true;
            // 
            // epPrenomField
            // 
            this.epPrenomField.BlinkRate = 500;
            this.epPrenomField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPrenomField.ContainerControl = this;
            this.epPrenomField.RightToLeft = true;
            // 
            // epNomField
            // 
            this.epNomField.BlinkRate = 500;
            this.epNomField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epNomField.ContainerControl = this;
            this.epNomField.RightToLeft = true;
            // 
            // epPassField
            // 
            this.epPassField.BlinkRate = 500;
            this.epPassField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epPassField.ContainerControl = this;
            this.epPassField.RightToLeft = true;
            // 
            // epConfirmPassField
            // 
            this.epConfirmPassField.BlinkRate = 500;
            this.epConfirmPassField.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epConfirmPassField.ContainerControl = this;
            this.epConfirmPassField.RightToLeft = true;
            // 
            // voirPassChkBox
            // 
            this.voirPassChkBox.AutoSize = true;
            this.voirPassChkBox.BackColor = System.Drawing.Color.Transparent;
            this.voirPassChkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voirPassChkBox.Image = global::GestionNotes.Properties.Resources.lblVoirMdp;
            this.voirPassChkBox.Location = new System.Drawing.Point(34, 400);
            this.voirPassChkBox.Name = "voirPassChkBox";
            this.voirPassChkBox.Size = new System.Drawing.Size(224, 40);
            this.voirPassChkBox.TabIndex = 11;
            this.voirPassChkBox.UseVisualStyleBackColor = false;
            this.voirPassChkBox.Click += new System.EventHandler(this.VoirPassChkBox_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetour.Image = global::GestionNotes.Properties.Resources.btnRetour;
            this.btnRetour.Location = new System.Drawing.Point(589, 446);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(133, 56);
            this.btnRetour.TabIndex = 12;
            this.btnRetour.UseVisualStyleBackColor = false;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // FenInscription
            // 
            this.AcceptButton = this.BtnCreerCompte;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::GestionNotes.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.voirPassChkBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnCreerCompte);
            this.Controls.Add(this.ConfirmPassField);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.NomField);
            this.Controls.Add(this.PrenomField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenInscription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Création d\'un compte enseignant";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmailField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPrenomField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epNomField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPassField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epConfirmPassField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PrenomField;
        private System.Windows.Forms.TextBox NomField;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.TextBox ConfirmPassField;
        private System.Windows.Forms.Button BtnCreerCompte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ErrorProvider epEmailField;
        private System.Windows.Forms.ErrorProvider epPrenomField;
        private System.Windows.Forms.ErrorProvider epNomField;
        private System.Windows.Forms.ErrorProvider epPassField;
        private System.Windows.Forms.ErrorProvider epConfirmPassField;
        private System.Windows.Forms.CheckBox voirPassChkBox;
        private System.Windows.Forms.Button btnRetour;
    }
}