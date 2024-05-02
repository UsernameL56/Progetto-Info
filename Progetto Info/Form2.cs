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

namespace Progetto_Info
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 _form1)
        {
            InitializeComponent();
            form1 = _form1;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            GroupBox groupBox = new GroupBox();
            groupBox.Text = textBox1.Text;
            groupBox.Width = 250;
            groupBox.Height = 150;
            flowLayoutPanelCorsi.Controls.Add(groupBox);
            groupBox1.Hide();
            flowLayoutPanelCorsi.BringToFront();
        }
    }
}
