namespace Progetto_Info
{
    partial class Form3
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.aggiungiElemento = new System.Windows.Forms.Button();
            this.VisualizzaPartecipantiButton = new System.Windows.Forms.Button();
            this.RicaricaButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelProfessore = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelStudenti = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.VisualizzaMaterialeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-5, -13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 130);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(517, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "CORSO";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MediumPurple;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(216, 191);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(951, 449);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // aggiungiElemento
            // 
            this.aggiungiElemento.Location = new System.Drawing.Point(216, 139);
            this.aggiungiElemento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.aggiungiElemento.Name = "aggiungiElemento";
            this.aggiungiElemento.Size = new System.Drawing.Size(436, 39);
            this.aggiungiElemento.TabIndex = 0;
            this.aggiungiElemento.Text = "Aggiungi File";
            this.aggiungiElemento.UseVisualStyleBackColor = true;
            this.aggiungiElemento.Click += new System.EventHandler(this.aggiungiElemento_Click);
            // 
            // VisualizzaPartecipantiButton
            // 
            this.VisualizzaPartecipantiButton.BackColor = System.Drawing.SystemColors.Window;
            this.VisualizzaPartecipantiButton.Location = new System.Drawing.Point(962, 139);
            this.VisualizzaPartecipantiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizzaPartecipantiButton.Name = "VisualizzaPartecipantiButton";
            this.VisualizzaPartecipantiButton.Size = new System.Drawing.Size(205, 39);
            this.VisualizzaPartecipantiButton.TabIndex = 2;
            this.VisualizzaPartecipantiButton.Text = "Visualizza Partecipanti";
            this.VisualizzaPartecipantiButton.UseVisualStyleBackColor = false;
            this.VisualizzaPartecipantiButton.Click += new System.EventHandler(this.VisualizzaPartecipantiButton_Click);
            // 
            // RicaricaButton
            // 
            this.RicaricaButton.Location = new System.Drawing.Point(1197, 139);
            this.RicaricaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RicaricaButton.Name = "RicaricaButton";
            this.RicaricaButton.Size = new System.Drawing.Size(150, 39);
            this.RicaricaButton.TabIndex = 3;
            this.RicaricaButton.Text = "Ricarica";
            this.RicaricaButton.UseVisualStyleBackColor = true;
            this.RicaricaButton.Click += new System.EventHandler(this.RicaricaButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanelStudenti);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.flowLayoutPanelProfessore);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(216, 191);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(951, 449);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(307, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Professore";
            // 
            // flowLayoutPanelProfessore
            // 
            this.flowLayoutPanelProfessore.Location = new System.Drawing.Point(262, 40);
            this.flowLayoutPanelProfessore.Name = "flowLayoutPanelProfessore";
            this.flowLayoutPanelProfessore.Size = new System.Drawing.Size(198, 365);
            this.flowLayoutPanelProfessore.TabIndex = 1;
            // 
            // flowLayoutPanelStudenti
            // 
            this.flowLayoutPanelStudenti.Location = new System.Drawing.Point(489, 41);
            this.flowLayoutPanelStudenti.Name = "flowLayoutPanelStudenti";
            this.flowLayoutPanelStudenti.Size = new System.Drawing.Size(198, 365);
            this.flowLayoutPanelStudenti.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(542, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Studenti";
            // 
            // VisualizzaMaterialeButton
            // 
            this.VisualizzaMaterialeButton.BackColor = System.Drawing.SystemColors.Window;
            this.VisualizzaMaterialeButton.Location = new System.Drawing.Point(751, 139);
            this.VisualizzaMaterialeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizzaMaterialeButton.Name = "VisualizzaMaterialeButton";
            this.VisualizzaMaterialeButton.Size = new System.Drawing.Size(205, 39);
            this.VisualizzaMaterialeButton.TabIndex = 5;
            this.VisualizzaMaterialeButton.Text = "Visualizza Materiale";
            this.VisualizzaMaterialeButton.UseVisualStyleBackColor = false;
            this.VisualizzaMaterialeButton.Click += new System.EventHandler(this.VisualizzaMaterialeButton_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1359, 642);
            this.Controls.Add(this.VisualizzaMaterialeButton);
            this.Controls.Add(this.VisualizzaPartecipantiButton);
            this.Controls.Add(this.RicaricaButton);
            this.Controls.Add(this.aggiungiElemento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button aggiungiElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VisualizzaPartecipantiButton;
        private System.Windows.Forms.Button RicaricaButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelStudenti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProfessore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button VisualizzaMaterialeButton;
    }
}