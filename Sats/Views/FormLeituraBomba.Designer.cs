
namespace Sats.Views
{
    partial class FormLeituraBomba
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLeituristaB = new System.Windows.Forms.TextBox();
            this.cbEstadoMedidor = new System.Windows.Forms.ComboBox();
            this.cbLeituraB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvarLeituraB = new System.Windows.Forms.Button();
            this.mtbDataHoraB = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 126);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nova Leitura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.mtbDataHoraB);
            this.panel2.Controls.Add(this.txtLeituristaB);
            this.panel2.Controls.Add(this.cbEstadoMedidor);
            this.panel2.Controls.Add(this.cbLeituraB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(35, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 378);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtLeituristaB
            // 
            this.txtLeituristaB.Location = new System.Drawing.Point(106, 115);
            this.txtLeituristaB.Name = "txtLeituristaB";
            this.txtLeituristaB.Size = new System.Drawing.Size(143, 25);
            this.txtLeituristaB.TabIndex = 6;
            // 
            // cbEstadoMedidor
            // 
            this.cbEstadoMedidor.FormattingEnabled = true;
            this.cbEstadoMedidor.Items.AddRange(new object[] {
            "1",
            "0"});
            this.cbEstadoMedidor.Location = new System.Drawing.Point(106, 201);
            this.cbEstadoMedidor.Name = "cbEstadoMedidor";
            this.cbEstadoMedidor.Size = new System.Drawing.Size(143, 27);
            this.cbEstadoMedidor.TabIndex = 5;
            // 
            // cbLeituraB
            // 
            this.cbLeituraB.FormattingEnabled = true;
            this.cbLeituraB.Location = new System.Drawing.Point(106, 27);
            this.cbLeituraB.Name = "cbLeituraB";
            this.cbLeituraB.Size = new System.Drawing.Size(143, 27);
            this.cbLeituraB.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Data/Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Estado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Leiturista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ponto";
            // 
            // btnSalvarLeituraB
            // 
            this.btnSalvarLeituraB.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvarLeituraB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLeituraB.Location = new System.Drawing.Point(346, 592);
            this.btnSalvarLeituraB.Name = "btnSalvarLeituraB";
            this.btnSalvarLeituraB.Size = new System.Drawing.Size(83, 36);
            this.btnSalvarLeituraB.TabIndex = 3;
            this.btnSalvarLeituraB.Text = "Salvar";
            this.btnSalvarLeituraB.UseVisualStyleBackColor = false;
            this.btnSalvarLeituraB.Click += new System.EventHandler(this.btnSalvarLeituraB_Click);
            // 
            // mtbDataHoraB
            // 
            this.mtbDataHoraB.Location = new System.Drawing.Point(107, 288);
            this.mtbDataHoraB.Mask = "00/00/0000 90:00";
            this.mtbDataHoraB.Name = "mtbDataHoraB";
            this.mtbDataHoraB.Size = new System.Drawing.Size(142, 25);
            this.mtbDataHoraB.TabIndex = 8;
            this.mtbDataHoraB.ValidatingType = typeof(System.DateTime);
            // 
            // FormLeituraBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(444, 651);
            this.Controls.Add(this.btnSalvarLeituraB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLeituraBomba";
            this.Text = "FormLeituraBomba";
            this.Load += new System.EventHandler(this.FormLeituraBomba_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeituristaB;
        private System.Windows.Forms.ComboBox cbEstadoMedidor;
        private System.Windows.Forms.ComboBox cbLeituraB;
        private System.Windows.Forms.Button btnSalvarLeituraB;
        private System.Windows.Forms.MaskedTextBox mtbDataHoraB;
    }
}