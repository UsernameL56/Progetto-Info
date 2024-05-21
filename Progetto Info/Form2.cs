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
        public string nomeFile;
        bool chiusuraForm;
       public Account utenteAttuale => form1.utenteAttuale;
        public Form2(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;
            nomeFile = form1.nomeFile;
            chiusuraForm = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(utenteAttuale.Ruolo == "Studente")
            {
                label4.Text = "Inserisci ID\n corso";
                label3.Hide();
                comboBox1.Hide();
                buttonCreaCorso.Text = "Unisciti al Corso";
            }

            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Email == utenteAttuale.Email)
                {
                    BackToButton.Text = utenteAttuale.Nome.Substring(0, 1);
                    foreach (Corso nuovoCorso in utenteAttuale.Corsi)
                    {
                        GroupBox corso = new GroupBox();
                        corso.Text = nuovoCorso.Nome;
                        corso.Width = 250;
                        corso.Height = 150;
                        flowLayoutPanelCorsi.Controls.Add(corso);
                        corso.Click += (s, eArgs) =>
                        {
                            this.Hide();
                            Form3 form3 = new Form3(this, nuovoCorso.Id);
                            form3.Show();
                        };
                    }
                    break;
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (chiusuraForm)
            {
                form1.Close();
            }
            else
            {
                chiusuraForm = true;
            }
            
        }

        private void temp_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            groupBox1.BringToFront();
        }

        private void buttonCreaCorso_Click(object sender, EventArgs e)
        {
            if(utenteAttuale.Ruolo == "Professore")
            {
                string corsoNome = nomeCorso.Text;

                if (!string.IsNullOrEmpty(corsoNome))
                {
                    Corso nuovoCorso = new Corso(corsoNome);
                    utenteAttuale.Corsi.Add(nuovoCorso);
                    SalvaDati(utenteAttuale);


                    displayCorso(corsoNome, nuovoCorso.Id);

                }
                else
                {
                    MessageBox.Show("Inserisci il nome del corso.");
                }
            }
            else
            {
                string corsoID = nomeCorso.Text;

                if (!string.IsNullOrEmpty(corsoID))
                {
                    List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));

                    for(int i = 0; i < lista.Count; i++)
                    {
                        foreach(Corso corso in lista[i].Corsi)
                        {
                            if(corso.Id == corsoID)
                            {
                                utenteAttuale.Corsi.Add(corso);
                                SalvaDati(utenteAttuale);
                                displayCorso(corso.Nome, corso.Id);
                                break;
                            }
                        }
                    }


                }
            }
            
        }

        private void displayCorso(string corsoNome, string corsoID)
        {
            GroupBox corso = new GroupBox();
            corso.Text = corsoNome;
            corso.Width = 250;
            corso.Height = 150;
            flowLayoutPanelCorsi.Controls.Add(corso);
            groupBox1.Hide();
            flowLayoutPanelCorsi.BringToFront();

            corso.Click += (s, eArgs) =>
            {
                this.Hide();
                Form3 form3 = new Form3(this, corsoID);
                form3.Show();
            };

        }
        private void SalvaDati(Account account)
        {
            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));

            for(int i = 0; i < lista.Count; i++)
            {
                if(lista[i].Email == account.Email)
                {
                    lista[i] = account;
                    break;
                }
            }

            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(nomeFile, json);
        }

        private void BackToButton_Click(object sender, EventArgs e)
        {
            chiusuraForm = false;
            this.Close();
            form1.Show();
        }
    }
}
