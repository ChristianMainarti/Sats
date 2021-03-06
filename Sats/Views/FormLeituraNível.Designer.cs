
namespace Sats.Views
{
    partial class FormLeituraNível
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
            this.lblLeituraPonto = new System.Windows.Forms.Label();
            this.cbLeituraNPonto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLeituristaN = new System.Windows.Forms.TextBox();
            this.txtValorLeituraN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labTítuloN = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDataHoraN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvarLeituraN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLeituraPonto
            // 
            this.lblLeituraPonto.AutoSize = true;
            this.lblLeituraPonto.Location = new System.Drawing.Point(26, 30);
            this.lblLeituraPonto.Name = "lblLeituraPonto";
            this.lblLeituraPonto.Size = new System.Drawing.Size(46, 19);
            this.lblLeituraPonto.TabIndex = 0;
            this.lblLeituraPonto.Text = "Ponto";
            // 
            // cbLeituraNPonto
            // 
            this.cbLeituraNPonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeituraNPonto.FormattingEnabled = true;
            this.cbLeituraNPonto.Location = new System.Drawing.Point(113, 27);
            this.cbLeituraNPonto.Name = "cbLeituraNPonto";
            this.cbLeituraNPonto.Size = new System.Drawing.Size(175, 27);
            this.cbLeituraNPonto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leiturista";
            // 
            // txtLeituristaN
            // 
            this.txtLeituristaN.Location = new System.Drawing.Point(113, 122);
            this.txtLeituristaN.Name = "txtLeituristaN";
            this.txtLeituristaN.Size = new System.Drawing.Size(175, 25);
            this.txtLeituristaN.TabIndex = 3;
            // 
            // txtValorLeituraN
            // 
            this.txtValorLeituraN.Location = new System.Drawing.Point(113, 215);
            this.txtValorLeituraN.Name = "txtValorLeituraN";
            this.txtValorLeituraN.Size = new System.Drawing.Size(175, 25);
            this.txtValorLeituraN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor (mA)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data/Hora";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.labTítuloN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 125);
            this.panel1.TabIndex = 8;
            // 
            // labTítuloN
            // 
            this.labTítuloN.AutoSize = true;
            this.labTítuloN.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTítuloN.Location = new System.Drawing.Point(34, 47);
            this.labTítuloN.Name = "labTítuloN";
            this.labTítuloN.Size = new System.Drawing.Size(207, 28);
            this.labTítuloN.TabIndex = 1;
            this.labTítuloN.Text = "Nova Leitura Nível";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.txtDataHoraN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbLeituraNPonto);
            this.panel2.Controls.Add(this.lblLeituraPonto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtLeituristaN);
            this.panel2.Controls.Add(this.txtValorLeituraN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(34, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 378);
            this.panel2.TabIndex = 9;
            // 
            // txtDataHoraN
            // 
            this.txtDataHoraN.Location = new System.Drawing.Point(113, 308);
            this.txtDataHoraN.Mask = "00/00/0000 90:00";
            this.txtDataHoraN.Name = "txtDataHoraN";
            this.txtDataHoraN.Size = new System.Drawing.Size(175, 25);
            this.txtDataHoraN.TabIndex = 9;
            this.txtDataHoraN.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "(de 4 a 20)";
            // 
            // btnSalvarLeituraN
            // 
            this.btnSalvarLeituraN.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvarLeituraN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLeituraN.Location = new System.Drawing.Point(343, 584);
            this.btnSalvarLeituraN.Name = "btnSalvarLeituraN";
            this.btnSalvarLeituraN.Size = new System.Drawing.Size(87, 43);
            this.btnSalvarLeituraN.TabIndex = 8;
            this.btnSalvarLeituraN.Text = "Salvar";
            this.btnSalvarLeituraN.UseVisualStyleBackColor = false;
            this.btnSalvarLeituraN.Click += new System.EventHandler(this.btnSalvarLeituraN_Click);
            // 
            // FormLeituraNível
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(448, 651);
            this.Controls.Add(this.btnSalvarLeituraN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FormLeituraNível";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLeituraNível_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblLeituraPonto;
        private System.Windows.Forms.ComboBox cbLeituraNPonto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeituristaN;
        private System.Windows.Forms.TextBox txtValorLeituraN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTítuloN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvarLeituraN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtDataHoraN;
    }
}