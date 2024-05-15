namespace Progetto_Info
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCorsi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreaCorso = new System.Windows.Forms.Button();
            this.nomeCorso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 129);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 613);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titolo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1327, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aggiungi Corso";
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(1244, 28);
            this.temp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(75, 57);
            this.temp.TabIndex = 2;
            this.temp.Text = "button1";
            this.temp.UseVisualStyleBackColor = true;
            this.temp.Click += new System.EventHandler(this.temp_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.temp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(3, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1464, 123);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanelCorsi
            // 
            this.flowLayoutPanelCorsi.AutoScroll = true;
            this.flowLayoutPanelCorsi.Location = new System.Drawing.Point(319, 129);
            this.flowLayoutPanelCorsi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanelCorsi.Name = "flowLayoutPanelCorsi";
            this.flowLayoutPanelCorsi.Size = new System.Drawing.Size(1156, 613);
            this.flowLayoutPanelCorsi.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonCreaCorso);
            this.groupBox1.Controls.Add(this.nomeCorso);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(505, 202);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(371, 282);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crea un corso";
            this.groupBox1.Visible = false;
            // 
            // buttonCreaCorso
            // 
            this.buttonCreaCorso.Location = new System.Drawing.Point(135, 213);
            this.buttonCreaCorso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCreaCorso.Name = "buttonCreaCorso";
            this.buttonCreaCorso.Size = new System.Drawing.Size(100, 28);
            this.buttonCreaCorso.TabIndex = 4;
            this.buttonCreaCorso.Text = "Crea";
            this.buttonCreaCorso.UseVisualStyleBackColor = true;
            this.buttonCreaCorso.Click += new System.EventHandler(this.buttonCreaCorso_Click);
            // 
            // nomeCorso
            // 
            this.nomeCorso.Location = new System.Drawing.Point(121, 65);
            this.nomeCorso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nomeCorso.Name = "nomeCorso";
            this.nomeCorso.Size = new System.Drawing.Size(160, 22);
            this.nomeCorso.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 65);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nome Corso";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Matematica",
            "Italiano",
            "Storia",
            "Inglese",
            "Geografia",
            "Chimica",
            "Informatica",
            "Telecomunicazioni",
            "Sistemi e Reti",
            "Tecnologie e Progettazione",
            "Educazione Fisica",
            "Religione",
            "Altro"});
            this.comboBox1.Location = new System.Drawing.Point(121, 121);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tipologia";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 743);
            this.Controls.Add(this.flowLayoutPanelCorsi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button temp;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCorsi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCreaCorso;
        private System.Windows.Forms.TextBox nomeCorso;
        private System.Windows.Forms.Label label4;
    }
}