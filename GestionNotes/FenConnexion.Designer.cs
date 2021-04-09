
namespace GestionNotes
{
    partial class FenConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FenConnexion));
            this.RememberEmailChkBox = new System.Windows.Forms.CheckBox();
            this.EmailField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.LabelEmail = new System.Windows.Forms.PictureBox();
            this.LabelPass = new System.Windows.Forms.PictureBox();
            this.LabelCreerCompte = new System.Windows.Forms.PictureBox();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.voirPassChkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.LabelEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelCreerCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // RememberEmailChkBox
            // 
            this.RememberEmailChkBox.AutoSize = true;
            this.RememberEmailChkBox.BackColor = System.Drawing.Color.Transparent;
            this.RememberEmailChkBox.Image = ((System.Drawing.Image)(resources.GetObject("RememberEmailChkBox.Image")));
            this.RememberEmailChkBox.Location = new System.Drawing.Point(40, 391);
            this.RememberEmailChkBox.Name = "RememberEmailChkBox";
            this.RememberEmailChkBox.Size = new System.Drawing.Size(224, 40);
            this.RememberEmailChkBox.TabIndex = 0;
            this.RememberEmailChkBox.UseVisualStyleBackColor = false;
            // 
            // EmailField
            // 
            this.EmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailField.Location = new System.Drawing.Point(12, 138);
            this.EmailField.Name = "EmailField";
            this.EmailField.Size = new System.Drawing.Size(252, 26);
            this.EmailField.TabIndex = 1;
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassField.Location = new System.Drawing.Point(12, 248);
            this.PassField.Name = "PassField";
            this.PassField.PasswordChar = '*';
            this.PassField.Size = new System.Drawing.Size(252, 26);
            this.PassField.TabIndex = 2;
            // 
            // LabelEmail
            // 
            this.LabelEmail.BackColor = System.Drawing.Color.Transparent;
            this.LabelEmail.Image = global::GestionNotes.Properties.Resources.lblEmail;
            this.LabelEmail.Location = new System.Drawing.Point(94, 98);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(91, 34);
            this.LabelEmail.TabIndex = 3;
            this.LabelEmail.TabStop = false;
            // 
            // LabelPass
            // 
            this.LabelPass.BackColor = System.Drawing.Color.Transparent;
            this.LabelPass.Image = global::GestionNotes.Properties.Resources.lblPass;
            this.LabelPass.Location = new System.Drawing.Point(94, 208);
            this.LabelPass.Name = "LabelPass";
            this.LabelPass.Size = new System.Drawing.Size(80, 34);
            this.LabelPass.TabIndex = 4;
            this.LabelPass.TabStop = false;
            // 
            // LabelCreerCompte
            // 
            this.LabelCreerCompte.BackColor = System.Drawing.Color.Transparent;
            this.LabelCreerCompte.Image = ((System.Drawing.Image)(resources.GetObject("LabelCreerCompte.Image")));
            this.LabelCreerCompte.Location = new System.Drawing.Point(31, 447);
            this.LabelCreerCompte.Name = "LabelCreerCompte";
            this.LabelCreerCompte.Size = new System.Drawing.Size(207, 36);
            this.LabelCreerCompte.TabIndex = 5;
            this.LabelCreerCompte.TabStop = false;
            this.LabelCreerCompte.Click += new System.EventHandler(this.LabelCreerCompte_Click);
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.BackColor = System.Drawing.Color.CadetBlue;
            this.BtnConnexion.FlatAppearance.BorderSize = 0;
            this.BtnConnexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.BtnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConnexion.ForeColor = System.Drawing.Color.Transparent;
            this.BtnConnexion.Image = global::GestionNotes.Properties.Resources.btnConnexion;
            this.BtnConnexion.Location = new System.Drawing.Point(40, 338);
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.Size = new System.Drawing.Size(179, 47);
            this.BtnConnexion.TabIndex = 6;
            this.BtnConnexion.UseVisualStyleBackColor = false;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            // 
            // voirPassChkBox
            // 
            this.voirPassChkBox.AutoSize = true;
            this.voirPassChkBox.BackColor = System.Drawing.Color.Transparent;
            this.voirPassChkBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.voirPassChkBox.Image = global::GestionNotes.Properties.Resources.lblVoirMdpC;
            this.voirPassChkBox.Location = new System.Drawing.Point(40, 280);
            this.voirPassChkBox.Name = "voirPassChkBox";
            this.voirPassChkBox.Size = new System.Drawing.Size(224, 40);
            this.voirPassChkBox.TabIndex = 12;
            this.voirPassChkBox.UseVisualStyleBackColor = false;
            this.voirPassChkBox.Click += new System.EventHandler(this.VoirPassChkBox_Click);
            // 
            // FenConnexion
            // 
            this.AcceptButton = this.BtnConnexion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GestionNotes.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(734, 511);
            this.Controls.Add(this.voirPassChkBox);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.LabelCreerCompte);
            this.Controls.Add(this.LabelPass);
            this.Controls.Add(this.LabelEmail);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.EmailField);
            this.Controls.Add(this.RememberEmailChkBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FenConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de notes";
            ((System.ComponentModel.ISupportInitialize)(this.LabelEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelCreerCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox RememberEmailChkBox;
        private System.Windows.Forms.TextBox EmailField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox LabelEmail;
        private System.Windows.Forms.PictureBox LabelPass;
        private System.Windows.Forms.PictureBox LabelCreerCompte;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.CheckBox voirPassChkBox;
    }
}

