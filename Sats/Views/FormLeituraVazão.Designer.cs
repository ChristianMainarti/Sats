
namespace Sats.Views
{
    partial class FormLeituraVazão
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
            this.labTítuloV = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxDataHoraV = new System.Windows.Forms.MaskedTextBox();
            this.txtLeituraVazão = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeituristaV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLeituraVPonto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalvarLeituraV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.labTítuloV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 125);
            this.panel1.TabIndex = 0;
            // 
            // labTítuloV
            // 
            this.labTítuloV.AutoSize = true;
            this.labTítuloV.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labTítuloV.Location = new System.Drawing.Point(34, 42);
            this.labTítuloV.Name = "labTítuloV";
            this.labTítuloV.Size = new System.Drawing.Size(217, 28);
            this.labTítuloV.TabIndex = 1;
            this.labTítuloV.Text = "Nova Leitura Vazão";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.mtxDataHoraV);
            this.panel2.Controls.Add(this.txtLeituraVazão);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtLeituristaV);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbLeituraVPonto);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(34, 169);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 378);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data/Hora";
            // 
            // mtxDataHoraV
            // 
            this.mtxDataHoraV.Location = new System.Drawing.Point(113, 307);
            this.mtxDataHoraV.Mask = "00/00/0000 90:00";
            this.mtxDataHoraV.Name = "mtxDataHoraV";
            this.mtxDataHoraV.Size = new System.Drawing.Size(115, 25);
            this.mtxDataHoraV.TabIndex = 6;
            this.mtxDataHoraV.ValidatingType = typeof(System.DateTime);
            // 
            // txtLeituraVazão
            // 
            this.txtLeituraVazão.Location = new System.Drawing.Point(112, 215);
            this.txtLeituraVazão.Name = "txtLeituraVazão";
            this.txtLeituraVazão.Size = new System.Drawing.Size(192, 25);
            this.txtLeituraVazão.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Volume (L)";
            // 
            // txtLeituristaV
            // 
            this.txtLeituristaV.Location = new System.Drawing.Point(112, 123);
            this.txtLeituristaV.Name = "txtLeituristaV";
            this.txtLeituristaV.Size = new System.Drawing.Size(192, 25);
            this.txtLeituristaV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Leiturista";
            // 
            // cbLeituraVPonto
            // 
            this.cbLeituraVPonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeituraVPonto.FormattingEnabled = true;
            this.cbLeituraVPonto.Location = new System.Drawing.Point(112, 29);
            this.cbLeituraVPonto.Name = "cbLeituraVPonto";
            this.cbLeituraVPonto.Size = new System.Drawing.Size(192, 27);
            this.cbLeituraVPonto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ponto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Location = new System.Drawing.Point(390, 747);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 62);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSalvarLeituraV
            // 
            this.btnSalvarLeituraV.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvarLeituraV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarLeituraV.Location = new System.Drawing.Point(343, 584);
            this.btnSalvarLeituraV.Name = "btnSalvarLeituraV";
            this.btnSalvarLeituraV.Size = new System.Drawing.Size(87, 43);
            this.btnSalvarLeituraV.TabIndex = 3;
            this.btnSalvarLeituraV.Text = "Salvar";
            this.btnSalvarLeituraV.UseVisualStyleBackColor = false;
            this.btnSalvarLeituraV.Click += new System.EventHandler(this.btnSalvarLeituraV_Click);
            // 
            // FormLeituraVazão
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(448, 651);
            this.Controls.Add(this.btnSalvarLeituraV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLeituraVazão";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormLeituraVazão_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalvarLeituraV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLeituraVPonto;
        private System.Windows.Forms.TextBox txtLeituristaV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLeituraVazão;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxDataHoraV;
        private System.Windows.Forms.Label labTítuloV;
    }
}