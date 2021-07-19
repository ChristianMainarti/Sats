
namespace Sats
{
    partial class FormPonto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPonto_Macro = new System.Windows.Forms.DataGridView();
            this.dgvPonto_Leitura = new System.Windows.Forms.DataGridView();
            this.btnNovoPonto = new System.Windows.Forms.Button();
            this.btnEditarPonto = new System.Windows.Forms.Button();
            this.btnPesquisarPonto = new System.Windows.Forms.Button();
            this.btnApagarPonto = new System.Windows.Forms.Button();
            this.colLeituraDGVPonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMacroDGVPonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto_Macro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto_Leitura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 130);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPonto_Macro);
            this.panel2.Location = new System.Drawing.Point(458, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 178);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvPonto_Leitura);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 303);
            this.panel3.TabIndex = 2;
            // 
            // dgvPonto_Macro
            // 
            this.dgvPonto_Macro.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPonto_Macro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonto_Macro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMacroDGVPonto});
            this.dgvPonto_Macro.Location = new System.Drawing.Point(0, 0);
            this.dgvPonto_Macro.Name = "dgvPonto_Macro";
            this.dgvPonto_Macro.RowTemplate.Height = 25;
            this.dgvPonto_Macro.Size = new System.Drawing.Size(314, 178);
            this.dgvPonto_Macro.TabIndex = 0;
            // 
            // dgvPonto_Leitura
            // 
            this.dgvPonto_Leitura.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvPonto_Leitura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPonto_Leitura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLeituraDGVPonto});
            this.dgvPonto_Leitura.Location = new System.Drawing.Point(0, 0);
            this.dgvPonto_Leitura.Name = "dgvPonto_Leitura";
            this.dgvPonto_Leitura.RowTemplate.Height = 25;
            this.dgvPonto_Leitura.Size = new System.Drawing.Size(784, 303);
            this.dgvPonto_Leitura.TabIndex = 3;
            // 
            // btnNovoPonto
            // 
            this.btnNovoPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnNovoPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPonto.Location = new System.Drawing.Point(92, 226);
            this.btnNovoPonto.Name = "btnNovoPonto";
            this.btnNovoPonto.Size = new System.Drawing.Size(99, 44);
            this.btnNovoPonto.TabIndex = 3;
            this.btnNovoPonto.Text = "Novo Ponto";
            this.btnNovoPonto.UseVisualStyleBackColor = false;
            this.btnNovoPonto.Click += new System.EventHandler(this.btnNovoPonto_Click);
            // 
            // btnEditarPonto
            // 
            this.btnEditarPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnEditarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPonto.Location = new System.Drawing.Point(235, 226);
            this.btnEditarPonto.Name = "btnEditarPonto";
            this.btnEditarPonto.Size = new System.Drawing.Size(99, 44);
            this.btnEditarPonto.TabIndex = 5;
            this.btnEditarPonto.Text = "Editar Ponto";
            this.btnEditarPonto.UseVisualStyleBackColor = false;
            // 
            // btnPesquisarPonto
            // 
            this.btnPesquisarPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnPesquisarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarPonto.Location = new System.Drawing.Point(92, 295);
            this.btnPesquisarPonto.Name = "btnPesquisarPonto";
            this.btnPesquisarPonto.Size = new System.Drawing.Size(99, 42);
            this.btnPesquisarPonto.TabIndex = 6;
            this.btnPesquisarPonto.Text = "Pesquisar Ponto";
            this.btnPesquisarPonto.UseVisualStyleBackColor = false;
            // 
            // btnApagarPonto
            // 
            this.btnApagarPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnApagarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarPonto.Location = new System.Drawing.Point(235, 295);
            this.btnApagarPonto.Name = "btnApagarPonto";
            this.btnApagarPonto.Size = new System.Drawing.Size(99, 42);
            this.btnApagarPonto.TabIndex = 7;
            this.btnApagarPonto.Text = "Apagar Ponto";
            this.btnApagarPonto.UseVisualStyleBackColor = false;
            // 
            // colLeituraDGVPonto
            // 
            this.colLeituraDGVPonto.HeaderText = "Leituras";
            this.colLeituraDGVPonto.Name = "colLeituraDGVPonto";
            this.colLeituraDGVPonto.Width = 740;
            // 
            // colMacroDGVPonto
            // 
            this.colMacroDGVPonto.HeaderText = "Macros";
            this.colMacroDGVPonto.Name = "colMacroDGVPonto";
            this.colMacroDGVPonto.Width = 271;
            // 
            // FormPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(784, 749);
            this.Controls.Add(this.btnApagarPonto);
            this.Controls.Add(this.btnPesquisarPonto);
            this.Controls.Add(this.btnEditarPonto);
            this.Controls.Add(this.btnNovoPonto);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormPonto";
            this.Text = "Pontos";
            this.Load += new System.EventHandler(this.FormPonto_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto_Macro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPonto_Leitura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPonto_Macro;
        private System.Windows.Forms.DataGridView dgvPonto_Leitura;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMacroDGVPonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeituraDGVPonto;
        private System.Windows.Forms.Button btnNovoPonto;
        private System.Windows.Forms.Button btnEditarPonto;
        private System.Windows.Forms.Button btnPesquisarPonto;
        private System.Windows.Forms.Button btnApagarPonto;
    }
}

