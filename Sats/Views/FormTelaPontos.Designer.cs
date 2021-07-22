
namespace Sats
{
    partial class FormTelaPontos
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTopTelaPontos = new System.Windows.Forms.Label();
            this.btnNovoPonto = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvPontosPontos = new System.Windows.Forms.ListView();
            this.col_Nome = new System.Windows.Forms.ColumnHeader();
            this.col_Macro = new System.Windows.Forms.ColumnHeader();
            this.col_Tipo = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAttPonto = new System.Windows.Forms.Button();
            this.listbPontosPontos = new System.Windows.Forms.CheckedListBox();
            this.btnApagarPonto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblTopTelaPontos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 128);
            this.panel1.TabIndex = 0;
            // 
            // lblTopTelaPontos
            // 
            this.lblTopTelaPontos.AutoSize = true;
            this.lblTopTelaPontos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopTelaPontos.Location = new System.Drawing.Point(43, 53);
            this.lblTopTelaPontos.Name = "lblTopTelaPontos";
            this.lblTopTelaPontos.Size = new System.Drawing.Size(68, 22);
            this.lblTopTelaPontos.TabIndex = 0;
            this.lblTopTelaPontos.Text = "Pontos";
            this.lblTopTelaPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNovoPonto
            // 
            this.btnNovoPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnNovoPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoPonto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoPonto.Location = new System.Drawing.Point(12, 157);
            this.btnNovoPonto.Name = "btnNovoPonto";
            this.btnNovoPonto.Size = new System.Drawing.Size(120, 50);
            this.btnNovoPonto.TabIndex = 3;
            this.btnNovoPonto.Text = "Novo Ponto";
            this.btnNovoPonto.UseVisualStyleBackColor = false;
            this.btnNovoPonto.Click += new System.EventHandler(this.btnNovoPonto_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvPontosPontos);
            this.panel2.Location = new System.Drawing.Point(192, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 240);
            this.panel2.TabIndex = 7;
            // 
            // lvPontosPontos
            // 
            this.lvPontosPontos.BackColor = System.Drawing.Color.AliceBlue;
            this.lvPontosPontos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Nome,
            this.col_Macro,
            this.col_Tipo});
            this.lvPontosPontos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPontosPontos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPontosPontos.FullRowSelect = true;
            this.lvPontosPontos.GridLines = true;
            this.lvPontosPontos.HideSelection = false;
            this.lvPontosPontos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvPontosPontos.Location = new System.Drawing.Point(0, 0);
            this.lvPontosPontos.Name = "lvPontosPontos";
            this.lvPontosPontos.Size = new System.Drawing.Size(455, 240);
            this.lvPontosPontos.TabIndex = 2;
            this.lvPontosPontos.UseCompatibleStateImageBehavior = false;
            this.lvPontosPontos.View = System.Windows.Forms.View.Details;
            // 
            // col_Nome
            // 
            this.col_Nome.Text = "Nome";
            this.col_Nome.Width = 150;
            // 
            // col_Macro
            // 
            this.col_Macro.Text = "Macro";
            this.col_Macro.Width = 150;
            // 
            // col_Tipo
            // 
            this.col_Tipo.Text = "Tipo";
            this.col_Tipo.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(192, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ultimos Pontos Cadastrados";
            // 
            // btnAttPonto
            // 
            this.btnAttPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnAttPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttPonto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAttPonto.Location = new System.Drawing.Point(12, 235);
            this.btnAttPonto.Name = "btnAttPonto";
            this.btnAttPonto.Size = new System.Drawing.Size(120, 50);
            this.btnAttPonto.TabIndex = 12;
            this.btnAttPonto.Text = "Atualizar Ponto";
            this.btnAttPonto.UseVisualStyleBackColor = false;
            this.btnAttPonto.Click += new System.EventHandler(this.btnAttPonto_Click);
            // 
            // listbPontosPontos
            // 
            this.listbPontosPontos.FormattingEnabled = true;
            this.listbPontosPontos.Location = new System.Drawing.Point(12, 375);
            this.listbPontosPontos.Name = "listbPontosPontos";
            this.listbPontosPontos.Size = new System.Drawing.Size(120, 112);
            this.listbPontosPontos.TabIndex = 13;
            // 
            // btnApagarPonto
            // 
            this.btnApagarPonto.BackColor = System.Drawing.Color.LightBlue;
            this.btnApagarPonto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagarPonto.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApagarPonto.Location = new System.Drawing.Point(12, 313);
            this.btnApagarPonto.Name = "btnApagarPonto";
            this.btnApagarPonto.Size = new System.Drawing.Size(120, 50);
            this.btnApagarPonto.TabIndex = 13;
            this.btnApagarPonto.Text = "Apagar Ponto";
            this.btnApagarPonto.UseVisualStyleBackColor = false;
            this.btnApagarPonto.Click += new System.EventHandler(this.btnApagarPonto_Click);
            // 
            // FormTelaPontos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.listbPontosPontos);
            this.Controls.Add(this.btnApagarPonto);
            this.Controls.Add(this.btnAttPonto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNovoPonto);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormTelaPontos";
            this.Load += new System.EventHandler(this.FormPonto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTopTelaPontos;
        private System.Windows.Forms.Button btnNovoPonto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvPontosPontos;
        private System.Windows.Forms.ColumnHeader col_Nome;
        private System.Windows.Forms.ColumnHeader col_Macro;
        private System.Windows.Forms.ColumnHeader col_Tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAttPonto;
        private System.Windows.Forms.CheckedListBox listbPontosPontos;
        private System.Windows.Forms.Button btnApagarPonto;
    }
}

