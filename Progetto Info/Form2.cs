using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Classi;
using Newtonsoft.Json;
using System.IO;
using System.Security.Principal;

namespace Progetto_Info
{
    public partial class Form2 : Form
    {
        private Form1 form1;
       public Account utenteAttuale => form1.utenteAttuale;
        public Form2(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(form1.nomeFile));

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Email == utenteAttuale.Email)
                {
                    for(int j = 0; j < form1.utenteAttuale.Corsi.Count; j++)
                    {
                        GroupBox corso = new GroupBox();
                        corso.Text = utenteAttuale.Corsi[j];
                        corso.Width = 250;
                        corso.Height = 150;
                        flowLayoutPanelCorsi.Controls.Add(corso);
                        corso.Click += (s, eArgs) =>
                        {
                            
                            Form3 form3 = new Form3(this);
                            form3.Show();
                            this.Hide();
                        };
                    }
                    break;
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }

        private void temp_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox1.BringToFront();
        }

        private void buttonCreaCorso_Click(object sender, EventArgs e)
        {
            string corsoNome = nomeCorso.Text;

            if (!string.IsNullOrEmpty(corsoNome))
            {
                GroupBox corso = new GroupBox();
                corso.Text = corsoNome;
                corso.Width = 250;
                corso.Height = 150;
                flowLayoutPanelCorsi.Controls.Add(corso);
                groupBox1.Hide();
                flowLayoutPanelCorsi.BringToFront();

                utenteAttuale.Corsi.Add(corsoNome);
                SalvaDatiCorso(utenteAttuale);

                corso.Click += (s, eArgs) =>
                {
                    
                    Form3 form3 = new Form3(this);
                    form3.Show();
                    this.Hide();
                };
            }
            else
            {
                MessageBox.Show("Inserisci il nome del corso.");
            }
        }

        private void SalvaDatiCorso(Account account)
        {
            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(form1.nomeFile));

            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].Email == account.Email)
                {
                    lista[i] = account;
                    break;
                }
            }

            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(form1.nomeFile, json);
        }
    }
}
