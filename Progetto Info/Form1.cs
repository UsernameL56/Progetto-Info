using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Classi;

namespace Progetto_Info
{
    public partial class Form1 : Form
    {
        public string nomeFile;
        public Account utenteAttuale { get; set; }
        public Form1()
        {
            InitializeComponent();
            nomeFile = "file.json";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonLoginPanel.PerformClick();
        }

        private void buttonLoginPanel_Click(object sender, EventArgs e)
        {
            panelLogin.BringToFront();
        }

        private void buttonRegisterPanel_Click(object sender, EventArgs e)
        {
            panelRegister.BringToFront();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
           

            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("file.json"));

            foreach(Account account in lista)
            {
                if(account.Email == emailLogin.Text && account.Password == passwordLogin.Text)
                {
                    utenteAttuale = account;
                    creazioneForm2();
                    PuliziaTextBox();
                    return;
                }

            }
            MessageBox.Show("Email o password errati");

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string json = "";

            if (!ControllaCampiCompilati())
            {
                MessageBox.Show("Tutti i campi devono essere compilati");
                return;
            }

            string email = emailRegistra.Text;

            if (!ControllaFormatoEmail(email))
            {
                MessageBox.Show("L'email deve essere nel formato @gmail.com");
                return;
            }

            List<Account> account = new List<Account>();
            Account nuovoAccount = new Account();
            nuovoAccount.Nome = nomeRegistra.Text;
            nuovoAccount.Cognome = cognomeRegistra.Text;
            nuovoAccount.Email = emailRegistra.Text; 
            nuovoAccount.Password = passwordRegistra.Text;

            if (passwordRegistra.Text != confPasswordRegistra.Text)
            {
                MessageBox.Show("Le due password non corrispondono");
                return;
            }
            
            bool isChecked = radioButtonStudente.Checked;
            if(isChecked)
                nuovoAccount.Ruolo = radioButtonStudente.Text;
            else
                nuovoAccount.Ruolo = radioButtonProfessore.Text;


            account.Add(nuovoAccount);
            if (!File.Exists(nomeFile))
            {
                json = JsonConvert.SerializeObject(account, Formatting.Indented);
                File.WriteAllText(nomeFile, json);
                utenteAttuale = nuovoAccount;
                creazioneForm2();
                PuliziaTextBox();
                return;
            }

            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("file.json"));

            foreach(Account controllo in lista)
            {
                if(controllo.Email == nuovoAccount.Email)
                {
                    MessageBox.Show("Email già in uso");
                    return;
                }
            }
            lista.AddRange(account);
            json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(nomeFile, json);

            utenteAttuale = nuovoAccount;
            creazioneForm2();
            PuliziaTextBox();
        }


        private bool ControllaCampiCompilati()
        {
            if (string.IsNullOrWhiteSpace(nomeRegistra.Text) ||
                string.IsNullOrWhiteSpace(cognomeRegistra.Text) ||
                string.IsNullOrWhiteSpace(emailRegistra.Text) ||
                string.IsNullOrWhiteSpace(passwordRegistra.Text) ||
                string.IsNullOrWhiteSpace(confPasswordRegistra.Text) ||
                (!radioButtonProfessore.Checked && !radioButtonStudente.Checked))
            {
                return false;
            }
            return true;
        }

        private bool ControllaFormatoEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Host.ToLower() == "gmail.com";
            }
            catch
            {
                return false;
            }
        }

        private void PuliziaTextBox()
        {
            emailLogin.Clear();
            passwordLogin.Clear();

            nomeRegistra.Clear();
            cognomeRegistra.Clear();
            emailRegistra.Clear();
            passwordRegistra.Clear();
            confPasswordRegistra.Clear();
            radioButtonProfessore.Checked = false;
            radioButtonStudente.Checked = false;
        }
        private void creazioneForm2()
        {
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }
    }
}
