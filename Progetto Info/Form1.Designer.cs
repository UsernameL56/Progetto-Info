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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonStudente = new System.Windows.Forms.RadioButton();
            this.radioButtonProfessore = new System.Windows.Forms.RadioButton();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelLogin.Controls.Add(this.textBox2);
            this.panelLogin.Controls.Add(this.textBox1);
            this.panelLogin.Controls.Add(this.buttonLogin);
            this.panelLogin.Controls.Add(this.label2);
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Location = new System.Drawing.Point(155, 82);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(278, 288);
            this.panelLogin.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 90);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(64, 230);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(155, 35);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
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
            this.panelRegister.Location = new System.Drawing.Point(154, 82);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(278, 288);
            this.panelRegister.TabIndex = 1;
            // 
            // confPasswordRegistra
            // 
            this.confPasswordRegistra.Location = new System.Drawing.Point(115, 153);
            this.confPasswordRegistra.Name = "confPasswordRegistra";
            this.confPasswordRegistra.Size = new System.Drawing.Size(100, 20);
            this.confPasswordRegistra.TabIndex = 13;
            // 
            // passwordRegistra
            // 
            this.passwordRegistra.Location = new System.Drawing.Point(115, 124);
            this.passwordRegistra.Name = "passwordRegistra";
            this.passwordRegistra.Size = new System.Drawing.Size(100, 20);
            this.passwordRegistra.TabIndex = 12;
            // 
            // emailRegistra
            // 
            this.emailRegistra.Location = new System.Drawing.Point(115, 90);
            this.emailRegistra.Name = "emailRegistra";
            this.emailRegistra.Size = new System.Drawing.Size(100, 20);
            this.emailRegistra.TabIndex = 11;
            // 
            // cognomeRegistra
            // 
            this.cognomeRegistra.Location = new System.Drawing.Point(115, 59);
            this.cognomeRegistra.Name = "cognomeRegistra";
            this.cognomeRegistra.Size = new System.Drawing.Size(100, 20);
            this.cognomeRegistra.TabIndex = 10;
            // 
            // nomeRegistra
            // 
            this.nomeRegistra.Location = new System.Drawing.Point(115, 22);
            this.nomeRegistra.Name = "nomeRegistra";
            this.nomeRegistra.Size = new System.Drawing.Size(100, 20);
            this.nomeRegistra.TabIndex = 5;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(64, 239);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(155, 35);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // buttonLoginPanel
            // 
            this.buttonLoginPanel.Location = new System.Drawing.Point(154, 31);
            this.buttonLoginPanel.Name = "buttonLoginPanel";
            this.buttonLoginPanel.Size = new System.Drawing.Size(136, 45);
            this.buttonLoginPanel.TabIndex = 2;
            this.buttonLoginPanel.Text = "Login";
            this.buttonLoginPanel.UseVisualStyleBackColor = true;
            this.buttonLoginPanel.Click += new System.EventHandler(this.buttonLoginPanel_Click);
            // 
            // buttonRegisterPanel
            // 
            this.buttonRegisterPanel.Location = new System.Drawing.Point(296, 31);
            this.buttonRegisterPanel.Name = "buttonRegisterPanel";
            this.buttonRegisterPanel.Size = new System.Drawing.Size(136, 45);
            this.buttonRegisterPanel.TabIndex = 3;
            this.buttonRegisterPanel.Text = "Register";
            this.buttonRegisterPanel.UseVisualStyleBackColor = true;
            this.buttonRegisterPanel.Click += new System.EventHandler(this.buttonRegisterPanel_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(500, 82);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(606, 82);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 6;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(500, 126);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 7;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(500, 166);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 8;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(528, 231);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(152, 73);
            this.textBox12.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(606, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 78);
            this.button1.TabIndex = 14;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonStudente
            // 
            this.radioButtonStudente.AutoSize = true;
            this.radioButtonStudente.Location = new System.Drawing.Point(51, 193);
            this.radioButtonStudente.Name = "radioButtonStudente";
            this.radioButtonStudente.Size = new System.Drawing.Size(68, 17);
            this.radioButtonStudente.TabIndex = 14;
            this.radioButtonStudente.TabStop = true;
            this.radioButtonStudente.Text = "Studente";
            this.radioButtonStudente.UseVisualStyleBackColor = true;
            // 
            // radioButtonProfessore
            // 
            this.radioButtonProfessore.AutoSize = true;
            this.radioButtonProfessore.Location = new System.Drawing.Point(142, 193);
            this.radioButtonProfessore.Name = "radioButtonProfessore";
            this.radioButtonProfessore.Size = new System.Drawing.Size(75, 17);
            this.radioButtonProfessore.TabIndex = 15;
            this.radioButtonProfessore.TabStop = true;
            this.radioButtonProfessore.Text = "Professore";
            this.radioButtonProfessore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 507);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.buttonRegisterPanel);
            this.Controls.Add(this.buttonLoginPanel);
            this.Controls.Add(this.panelRegister);
            this.Controls.Add(this.panelLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonProfessore;
        private System.Windows.Forms.RadioButton radioButtonStudente;
    }
}

