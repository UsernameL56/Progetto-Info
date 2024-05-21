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
        public Form3(Form2 _form2, string _corsoID)
        {
            InitializeComponent();
            form2 = _form2;
            corsoID = _corsoID;
            nomeFile = _form2.nomeFile;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            VisualizzaFile();
        }

        private void CaricamentoFile()
        {
            Corso corso = form2.utenteAttuale.Corsi.FirstOrDefault(c => c.Id == corsoID);
            if (corso != null)
            {
                foreach (var file in corso.Materiali)
                {
                    AggiungiFile(file);
                }
            }
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
            groupBoxFile.Width = 860;
            groupBoxFile.Height = 70;

            Button buttonVisualizza = new Button();
            buttonVisualizza.Text = "Visualizza";
            buttonVisualizza.Click += (s, eArgs) =>
            {
                System.Diagnostics.Process.Start(pathFile);
            };
            groupBoxFile.Controls.Add(buttonVisualizza);
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
    }
}
