using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progetto_Info
{
    public partial class Form3 : Form
    {
        private Form2 form2;
        public Form3(Form2 _form2)
        {
            InitializeComponent();
            form2 = _form2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
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
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = openFileDialog.FileName;

                    GroupBox groupBoxFile = new GroupBox();
                    groupBoxFile.Text = System.IO.Path.GetFileName(file);
                    groupBoxFile.Width = 860;
                    groupBoxFile.Height = 70;

                    Button buttonVisualizza = new Button();
                    buttonVisualizza.Text = "Visualizza";
                    buttonVisualizza.Click += (s, eArgs) =>
                    {
                        System.Diagnostics.Process.Start(file);
                    };
                    groupBoxFile.Controls.Add(buttonVisualizza);
                    buttonVisualizza.Dock = DockStyle.Fill;

                    FlowLayoutPanel flowLayoutPanelMateriali = (FlowLayoutPanel)this.Controls["flowLayoutPanel1"];
                    flowLayoutPanelMateriali.Controls.Add(groupBoxFile);
                }
            }
        }
    }
}
