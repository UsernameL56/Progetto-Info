using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classi;
using Newtonsoft.Json;

namespace Progetto_Info
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        private string corsoID;
        string nomeFile;
        public Account utenteAttuale => form2.utenteAttuale;
        private Corso corsoCorrente;
        public Form3(Form2 _form2, string _corsoID)
        {
            InitializeComponent();
            form2 = _form2;
            corsoID = _corsoID;
            nomeFile = _form2.nomeFile;
            foreach(Corso corso in utenteAttuale.Corsi)
            {
                if(corso.Id == corsoID)
                {
                    corsoCorrente = corso;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if(utenteAttuale.Ruolo == "Professore")
            {
                RicaricaButton.Hide();
            }
            else
            {
                aggiungiElemento.Hide();
            }
            VisualizzaFile();
            label1.Text = corsoCorrente.Nome;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            form2.Show();
        }

        private void aggiungiElemento_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string pathFile = openFileDialog.FileName;

                    Corso corso = form2.utenteAttuale.Corsi.FirstOrDefault(c => c.Id == corsoID);
                    if (corso != null)
                    {
                        corso.Materiali.Insert(0, pathFile); 
                        SalvaDati(form2.utenteAttuale);

                       
                        AggiungiFile(pathFile);
                    }
                }
            }
        }

        private void SalvaDati(Account account)
        {
            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(form2.nomeFile));

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Email == account.Email)
                {
                    lista[i] = account;
                    break;
                }
            }

            string json = JsonConvert.SerializeObject(lista, Formatting.Indented);
            File.WriteAllText(nomeFile, json);
        }

        private void AggiungiFile(string pathFile)
        {
            GroupBox groupBoxFile = new GroupBox();
            groupBoxFile.Text = System.IO.Path.GetFileName(pathFile);
            groupBoxFile.Width = 650;
            groupBoxFile.Height = 70;

            Button buttonVisualizza = new Button();
            buttonVisualizza.Text = "Visualizza";
            buttonVisualizza.Click += (s, eArgs) =>
            {
                System.Diagnostics.Process.Start(pathFile);
            };
            groupBoxFile.Controls.Add(buttonVisualizza);
            buttonVisualizza.BackColor = System.Drawing.Color.White;
            buttonVisualizza.Dock = DockStyle.Fill;

            FlowLayoutPanel flowLayoutPanelMateriali = (FlowLayoutPanel)this.Controls["flowLayoutPanel1"];
            flowLayoutPanelMateriali.Controls.Add(groupBoxFile);
            flowLayoutPanelMateriali.Controls.SetChildIndex(groupBoxFile, 0);
        }
        
        private void VisualizzaFile()
        {
            int temp = 0;
            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));

            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Email == utenteAttuale.Email)
                {
                    foreach (Corso corso in utenteAttuale.Corsi)
                    {
                        if (corso.Id == corsoID)
                        {
                            foreach(var materiale in corso.Materiali)
                            {
                                stack.Push(materiale);
                            }
                            while(stack.Count > 0)
                            {
                                AggiungiFile(stack.Pop());
                            }
                            return;
                        }
                    }
                }
            }
        }

        private void RicaricaButton_Click(object sender, EventArgs e)
        {
            RemoveGroupBoxesWithButton();
            if (utenteAttuale.Ruolo == "Studente")
            {
                List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));
                
                foreach(Corso corso in utenteAttuale.Corsi)
                {
                    for (int i = 0; i < lista.Count; i++)
                    {
                        foreach(Corso corsoLista in lista[i].Corsi)
                        {
                            if (corso.Proprietario == lista[i].Cognome && corso.Id == corsoLista.Id)
                            {
                                corso.Materiali.RemoveAll(item => item is string);
                                foreach(var materiale in corsoLista.Materiali)
                                {
                                    corso.Materiali.Add(materiale);
                                }
                            }
                        }
                        
                    }
                }

                SalvaDati(utenteAttuale);
                VisualizzaFile();
            }
        }

        private void RemoveGroupBoxesWithButton()
        {
            FlowLayoutPanel flowLayoutPanelMateriali = (FlowLayoutPanel)this.Controls["flowLayoutPanel1"];
            for (int i = flowLayoutPanelMateriali.Controls.Count - 1; i >= 0; i--)
            {
                GroupBox groupBox = flowLayoutPanelMateriali.Controls[i] as GroupBox;
                if (groupBox != null)
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        if (control is Button)
                        {
                            flowLayoutPanelMateriali.Controls.Remove(groupBox);
                            break;
                        }
                    }
                }
            }
        }

        private void VisualizzaPartecipantiButton_Click(object sender, EventArgs e)
        {

            panel2.BringToFront();

            List<Account> lista = JsonConvert.DeserializeObject<List<Account>>(File.ReadAllText(nomeFile));
            List<string> professori = new List<string>();
            List<string> studenti = new List<string>();

            foreach (Account account in lista)
            {
                foreach (Corso corso in account.Corsi)
                {
                    if (corso.Id == corsoID)
                    {
                        if (account.Ruolo == "Professore")
                        {
                            professori.Add(account.Nome + " " + account.Cognome);
                        }
                        else
                        {
                            studenti.Add(account.Nome + " " + account.Cognome);
                        }
                    }
                }
            }

            flowLayoutPanelProfessore.Controls.Clear();
            flowLayoutPanelProfessore.Controls.Clear();
            foreach (string professore in professori)
            {
                Label labelProfessore = new Label();
                labelProfessore.Text = professore;
                labelProfessore.AutoSize = true;
                labelProfessore.ForeColor = Color.White;
                flowLayoutPanelProfessore.Controls.Add(labelProfessore);
            }

            flowLayoutPanelStudenti.Controls.Clear();
            foreach (string studente in studenti)
            {
                Label labelStudente = new Label();
                labelStudente.Text = studente;
                labelStudente.AutoSize = true;
                labelStudente.ForeColor = Color.White;
                flowLayoutPanelStudenti.Controls.Add(labelStudente);
            }
        }

        private void VisualizzaMaterialeButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.BringToFront();
        }
    }
}
