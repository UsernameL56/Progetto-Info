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
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(377, 22);
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
            this.VisualizzaPartecipantiButton.Location = new System.Drawing.Point(658, 139);
            this.VisualizzaPartecipantiButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.VisualizzaPartecipantiButton.Name = "VisualizzaPartecipantiButton";
            this.VisualizzaPartecipantiButton.Size = new System.Drawing.Size(436, 39);
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1359, 642);
            this.Controls.Add(this.VisualizzaPartecipantiButton);
            this.Controls.Add(this.RicaricaButton);
            this.Controls.Add(this.aggiungiElemento);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button aggiungiElemento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button VisualizzaPartecipantiButton;
        private System.Windows.Forms.Button RicaricaButton;
    }
}