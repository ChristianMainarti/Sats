
namespace Sats.Views
{
    partial class FormPonto
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
            this.lvPontoLeituras = new System.Windows.Forms.ListView();
            this.colNomePonto = new System.Windows.Forms.ColumnHeader();
            this.colLeiturista = new System.Windows.Forms.ColumnHeader();
            this.colValorLeitura = new System.Windows.Forms.ColumnHeader();
            this.colDataHora = new System.Windows.Forms.ColumnHeader();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaLeitura = new System.Windows.Forms.Button();
            this.btnEditaLeitura = new System.Windows.Forms.Button();
            this.btnApagaLeitura = new System.Windows.Forms.Button();
            this.clbLeituraPontos = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lvPontoLeituras);
            this.panel1.Location = new System.Drawing.Point(192, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 240);
            this.panel1.TabIndex = 0;
            // 
            // lvPontoLeituras
            // 
            this.lvPontoLeituras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNomePonto,
            this.colLeiturista,
            this.colValorLeitura,
            this.colDataHora});
            this.lvPontoLeituras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPontoLeituras.GridLines = true;
            this.lvPontoLeituras.HideSelection = false;
            this.lvPontoLeituras.Location = new System.Drawing.Point(0, 0);
            this.lvPontoLeituras.Name = "lvPontoLeituras";
            this.lvPontoLeituras.Size = new System.Drawing.Size(455, 240);
            this.lvPontoLeituras.TabIndex = 0;
            this.lvPontoLeituras.UseCompatibleStateImageBehavior = false;
            this.lvPontoLeituras.View = System.Windows.Forms.View.Details;
            this.lvPontoLeituras.SelectedIndexChanged += new System.EventHandler(this.lvPontoLeituras_SelectedIndexChanged);
            // 
            // colNomePonto
            // 
            this.colNomePonto.Text = "Ponto";
            this.colNomePonto.Width = 100;
            // 
            // colLeiturista
            // 
            this.colLeiturista.Text = "Leiturista";
            this.colLeiturista.Width = 130;
            // 
            // colValorLeitura
            // 
            this.colValorLeitura.Text = "Valor Leitura";
            this.colValorLeitura.Width = 110;
            // 
            // colDataHora
            // 
            this.colDataHora.Text = "Data/Hora";
            this.colDataHora.Width = 110;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 128);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ultimas Leituras";
            // 
            // btnNovaLeitura
            // 
            this.btnNovaLeitura.BackColor = System.Drawing.Color.LightBlue;
            this.btnNovaLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaLeitura.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovaLeitura.Location = new System.Drawing.Point(12, 157);
            this.btnNovaLeitura.Name = "btnNovaLeitura";
            this.btnNovaLeitura.Size = new System.Drawing.Size(120, 50);
            this.btnNovaLeitura.TabIndex = 3;
            this.btnNovaLeitura.Text = "Nova Leitura";
            this.btnNovaLeitura.UseVisualStyleBackColor = false;
            this.btnNovaLeitura.Click += new System.EventHandler(this.btnNovaLeitura_Click);
            // 
            // btnEditaLeitura
            // 
            this.btnEditaLeitura.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditaLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditaLeitura.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditaLeitura.Location = new System.Drawing.Point(12, 235);
            this.btnEditaLeitura.Name = "btnEditaLeitura";
            this.btnEditaLeitura.Size = new System.Drawing.Size(120, 50);
            this.btnEditaLeitura.TabIndex = 5;
            this.btnEditaLeitura.Text = "Editar Leitura";
            this.btnEditaLeitura.UseVisualStyleBackColor = false;
            // 
            // btnApagaLeitura
            // 
            this.btnApagaLeitura.BackColor = System.Drawing.Color.LightBlue;
            this.btnApagaLeitura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagaLeitura.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagaLeitura.Location = new System.Drawing.Point(12, 313);
            this.btnApagaLeitura.Name = "btnApagaLeitura";
            this.btnApagaLeitura.Size = new System.Drawing.Size(120, 50);
            this.btnApagaLeitura.TabIndex = 6;
            this.btnApagaLeitura.Text = "Apagar Leitura";
            this.btnApagaLeitura.UseVisualStyleBackColor = false;
            // 
            // clbLeituraPontos
            // 
            this.clbLeituraPontos.FormattingEnabled = true;
            this.clbLeituraPontos.Location = new System.Drawing.Point(12, 375);
            this.clbLeituraPontos.Name = "clbLeituraPontos";
            this.clbLeituraPontos.Size = new System.Drawing.Size(120, 112);
            this.clbLeituraPontos.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ponto";
            // 
            // FormPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.clbLeituraPontos);
            this.Controls.Add(this.btnApagaLeitura);
            this.Controls.Add(this.btnEditaLeitura);
            this.Controls.Add(this.btnNovaLeitura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormPonto";
            this.Load += new System.EventHandler(this.FormPonto_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvPontoLeituras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaLeitura;
        private System.Windows.Forms.Button btnEditaLeitura;
        private System.Windows.Forms.Button btnApagaLeitura;
        private System.Windows.Forms.ColumnHeader colNomePonto;
        private System.Windows.Forms.ColumnHeader colLeiturista;
        private System.Windows.Forms.ColumnHeader colValorLeitura;
        private System.Windows.Forms.ColumnHeader colDataHora;
        private System.Windows.Forms.CheckedListBox clbLeituraPontos;
        private System.Windows.Forms.Label label2;
    }
}