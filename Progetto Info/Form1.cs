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
        string nomeFile;
        public Form1()
        {
            InitializeComponent();
            textBox9.PasswordChar = '*';
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
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string json = "";
            Form2 form2 = new Form2(this);
            form2.Show();
            this.Hide();
            
            List<Account> account = new List<Account>();
            account.Nome = nomeRegistra.Text;
            account.Cognome = cognomeRegistra.Text;
            account.Email = emailRegistra.Text; 
            account.Password = passwordRegistra.Text;
            bool isChecked = radioButtonStudente.Checked;
            if(isChecked)
                account.Ruolo = radioButtonStudente.Text;
            else
                account.Ruolo = radioButtonProfessore.Text;

            if (!File.Exists(nomeFile))
            {
                json = JsonConvert.SerializeObject(account, Formatting.Indented);
                File.WriteAllText(nomeFile, json);
                return;
            }

            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText("file.json"));
            lista.Add(account);
            json = JsonConvert.SerializeObject(lista);
            File.WriteAllText(nomeFile, json);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mm = new MailMessage();
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                mm.From = new MailAddress(textBox8.Text);
                mm.To.Add(textBox10.Text);
                mm.Subject = textBox11.Text;
                mm.Body = textBox12.Text;
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential(textBox8.Text, textBox9.Text);
                sc.EnableSsl = true;
                sc.Send(mm);
                MessageBox.Show("Email has sent.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
