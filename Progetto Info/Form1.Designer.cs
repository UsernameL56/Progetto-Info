namespace Progetto_Info
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.emailLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.radioButtonProfessore = new System.Windows.Forms.RadioButton();
            this.radioButtonStudente = new System.Windows.Forms.RadioButton();
            this.confPasswordRegistra = new System.Windows.Forms.TextBox();
            this.passwordRegistra = new System.Windows.Forms.TextBox();
            this.emailRegistra = new System.Windows.Forms.TextBox();
            this.cognomeRegistra = new System.Windows.Forms.TextBox();
            this.nomeRegistra = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoginPanel = new System.Windows.Forms.Button();
            this.buttonRegisterPanel = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLogin.Controls.Add(this.passwordLogin);
            this.panelLogin.Controls.Add(this.emailLogin);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(5, 67);
            this.panelLogin.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(371, 354);
            this.panelLogin.TabIndex = 0;
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(145, 111);
            this.passwordLogin.Margin = new System.Windows.Forms.Padding(4);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(132, 22);
            this.passwordLogin.TabIndex = 4;
            this.passwordLogin.UseSystemPasswordChar = true;
            // 
            // emailLogin
            // 
            this.emailLogin.Location = new System.Drawing.Point(147, 59);
            this.emailLogin.Margin = new System.Windows.Forms.Padding(4);
            this.emailLogin.Name = "emailLogin";
            this.emailLogin.Size = new System.Drawing.Size(132, 22);
            this.emailLogin.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(85, 283);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(207, 43);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "email";
            // 
            // panelRegister
            // 
            this.panelRegister.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelRegister.Controls.Add(this.radioButtonProfessore);
            this.panelRegister.Controls.Add(this.radioButtonStudente);
            this.panelRegister.Controls.Add(this.confPasswordRegistra);
            this.panelRegister.Controls.Add(this.passwordRegistra);
            this.panelRegister.Controls.Add(this.emailRegistra);
            this.panelRegister.Controls.Add(this.cognomeRegistra);
            this.panelRegister.Controls.Add(this.nomeRegistra);
            this.panelRegister.Controls.Add(this.buttonRegister);
            this.panelRegister.Controls.Add(this.label7);
            this.panelRegister.Controls.Add(this.label6);
            this.panelRegister.Controls.Add(this.label5);
            this.panelRegister.Controls.Add(this.label4);
            this.panelRegister.Controls.Add(this.label3);
            this.panelRegister.Location = new System.Drawing.Point(3, 67);
            this.panelRegister.Margin = new System.Windows.Forms.Padding(4);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(371, 354);
            this.panelRegister.TabIndex = 1;
            // 
            // radioButtonProfessore
            // 
            this.radioButtonProfessore.AutoSize = true;
            this.radioButtonProfessore.Location = new System.Drawing.Point(189, 238);
            this.radioButtonProfessore.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonProfessore.Name = "radioButtonProfessore";
            this.radioButtonProfessore.Size = new System.Drawing.Size(94, 20);
            this.radioButtonProfessore.TabIndex = 15;
            this.radioButtonProfessore.TabStop = true;
            this.radioButtonProfessore.Text = "Professore";
            this.radioButtonProfessore.UseVisualStyleBackColor = true;
            // 
            // radioButtonStudente
            // 
            this.radioButtonStudente.AutoSize = true;
            this.radioButtonStudente.Location = new System.Drawing.Point(68, 238);
            this.radioButtonStudente.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonStudente.Name = "radioButtonStudente";
            this.radioButtonStudente.Size = new System.Drawing.Size(81, 20);
            this.radioButtonStudente.TabIndex = 14;
            this.radioButtonStudente.TabStop = true;
            this.radioButtonStudente.Text = "Studente";
            this.radioButtonStudente.UseVisualStyleBackColor = true;
            // 
            // confPasswordRegistra
            // 
            this.confPasswordRegistra.Location = new System.Drawing.Point(153, 188);
            this.confPasswordRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.confPasswordRegistra.Name = "confPasswordRegistra";
            this.confPasswordRegistra.Size = new System.Drawing.Size(132, 22);
            this.confPasswordRegistra.TabIndex = 13;
            this.confPasswordRegistra.UseSystemPasswordChar = true;
            // 
            // passwordRegistra
            // 
            this.passwordRegistra.Location = new System.Drawing.Point(153, 153);
            this.passwordRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.passwordRegistra.Name = "passwordRegistra";
            this.passwordRegistra.Size = new System.Drawing.Size(132, 22);
            this.passwordRegistra.TabIndex = 12;
            this.passwordRegistra.UseSystemPasswordChar = true;
            // 
            // emailRegistra
            // 
            this.emailRegistra.Location = new System.Drawing.Point(153, 111);
            this.emailRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.emailRegistra.Name = "emailRegistra";
            this.emailRegistra.Size = new System.Drawing.Size(132, 22);
            this.emailRegistra.TabIndex = 11;
            // 
            // cognomeRegistra
            // 
            this.cognomeRegistra.Location = new System.Drawing.Point(153, 73);
            this.cognomeRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.cognomeRegistra.Name = "cognomeRegistra";
            this.cognomeRegistra.Size = new System.Drawing.Size(132, 22);
            this.cognomeRegistra.TabIndex = 10;
            // 
            // nomeRegistra
            // 
            this.nomeRegistra.Location = new System.Drawing.Point(153, 27);
            this.nomeRegistra.Margin = new System.Windows.Forms.Padding(4);
            this.nomeRegistra.Name = "nomeRegistra";
            this.nomeRegistra.Size = new System.Drawing.Size(132, 22);
            this.nomeRegistra.TabIndex = 5;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(85, 294);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(207, 43);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // buttonLoginPanel
            // 
            this.buttonLoginPanel.Location = new System.Drawing.Point(3, 4);
            this.buttonLoginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoginPanel.Name = "buttonLoginPanel";
            this.buttonLoginPanel.Size = new System.Drawing.Size(181, 55);
            this.buttonLoginPanel.TabIndex = 2;
            this.buttonLoginPanel.Text = "Login";
            this.buttonLoginPanel.UseVisualStyleBackColor = true;
            this.buttonLoginPanel.Click += new System.EventHandler(this.buttonLoginPanel_Click);
            // 
            // buttonRegisterPanel
            // 
            this.buttonRegisterPanel.Location = new System.Drawing.Point(193, 4);
            this.buttonRegisterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegisterPanel.Name = "buttonRegisterPanel";
            this.buttonRegisterPanel.Size = new System.Drawing.Size(181, 55);
            this.buttonRegisterPanel.TabIndex = 3;
            this.buttonRegisterPanel.Text = "Register";
            this.buttonRegisterPanel.UseVisualStyleBackColor = true;
            this.buttonRegisterPanel.Click += new System.EventHandler(this.buttonRegisterPanel_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(377, 423);
            this.Controls.Add(this.buttonRegisterPanel);
            this.Controls.Add(this.buttonLoginPanel);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.TextBox emailLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confPasswordRegistra;
        private System.Windows.Forms.TextBox passwordRegistra;
        private System.Windows.Forms.TextBox emailRegistra;
        private System.Windows.Forms.TextBox cognomeRegistra;
        private System.Windows.Forms.TextBox nomeRegistra;
        private System.Windows.Forms.Button buttonLoginPanel;
        private System.Windows.Forms.Button buttonRegisterPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RadioButton radioButtonProfessore;
        private System.Windows.Forms.RadioButton radioButtonStudente;
    }
}

