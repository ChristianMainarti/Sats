
namespace Sats.Views
{
    partial class FormNovoPonto
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
            this.labNovoPontoPonto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeMedidor = new System.Windows.Forms.TextBox();
            this.cbxPontoTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomePonto = new System.Windows.Forms.TextBox();
            this.cboxPontoMacro = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.labNovoPontoPonto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 119);
            this.panel1.TabIndex = 0;
            // 
            // labNovoPontoPonto
            // 
            this.labNovoPontoPonto.AutoSize = true;
            this.labNovoPontoPonto.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labNovoPontoPonto.Location = new System.Drawing.Point(34, 48);
            this.labNovoPontoPonto.Name = "labNovoPontoPonto";
            this.labNovoPontoPonto.Size = new System.Drawing.Size(125, 26);
            this.labNovoPontoPonto.TabIndex = 0;
            this.labNovoPontoPonto.Text = "Novo Ponto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightBlue;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNomeMedidor);
            this.panel2.Controls.Add(this.cbxPontoTipo);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtEndereço);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNomePonto);
            this.panel2.Controls.Add(this.cboxPontoMacro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 231);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(427, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nome Medidor";
            // 
            // txtNomeMedidor
            // 
            this.txtNomeMedidor.Location = new System.Drawing.Point(536, 96);
            this.txtNomeMedidor.Name = "txtNomeMedidor";
            this.txtNomeMedidor.Size = new System.Drawing.Size(230, 23);
            this.txtNomeMedidor.TabIndex = 8;
            this.txtNomeMedidor.TextChanged += new System.EventHandler(this.txtNomeMedidor_TextChanged);
            // 
            // cbxPontoTipo
            // 
            this.cbxPontoTipo.FormattingEnabled = true;
            this.cbxPontoTipo.Items.AddRange(new object[] {
            "Vazão",
            "Nivel",
            "Bomba"});
            this.cbxPontoTipo.Location = new System.Drawing.Point(536, 27);
            this.cbxPontoTipo.Name = "cbxPontoTipo";
            this.cbxPontoTipo.Size = new System.Drawing.Size(230, 23);
            this.cbxPontoTipo.TabIndex = 7;
            this.cbxPontoTipo.SelectedIndexChanged += new System.EventHandler(this.cbxPontoTipo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(427, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo";
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(117, 163);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(649, 23);
            this.txtEndereço.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // txtNomePonto
            // 
            this.txtNomePonto.Location = new System.Drawing.Point(117, 92);
            this.txtNomePonto.Name = "txtNomePonto";
            this.txtNomePonto.Size = new System.Drawing.Size(230, 23);
            this.txtNomePonto.TabIndex = 2;
            this.txtNomePonto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cboxPontoMacro
            // 
            this.cboxPontoMacro.FormattingEnabled = true;
            this.cboxPontoMacro.Location = new System.Drawing.Point(117, 23);
            this.cboxPontoMacro.Name = "cboxPontoMacro";
            this.cboxPontoMacro.Size = new System.Drawing.Size(230, 23);
            this.cboxPontoMacro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Macro";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(56, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNovoPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormNovoPonto";
            this.Text = "FormNovoPonto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labNovoPontoPonto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomePonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPontoTipo;
        private System.Windows.Forms.ComboBox cboxPontoMacro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeMedidor;
    }
}