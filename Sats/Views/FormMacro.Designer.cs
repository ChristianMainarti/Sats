
namespace Sats.Views
{
    partial class FormMacro
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovoMacro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTopTelaPontos = new System.Windows.Forms.Label();
            this.lbMacrosPonto = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMacrosPonto);
            this.panel1.Location = new System.Drawing.Point(33, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 256);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.lblTopTelaPontos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 114);
            this.panel2.TabIndex = 1;
            // 
            // btnNovoMacro
            // 
            this.btnNovoMacro.BackColor = System.Drawing.Color.LightBlue;
            this.btnNovoMacro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoMacro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoMacro.Location = new System.Drawing.Point(69, 170);
            this.btnNovoMacro.Name = "btnNovoMacro";
            this.btnNovoMacro.Size = new System.Drawing.Size(102, 43);
            this.btnNovoMacro.TabIndex = 2;
            this.btnNovoMacro.Text = "Novo Macro";
            this.btnNovoMacro.UseVisualStyleBackColor = false;
            this.btnNovoMacro.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(474, 170);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 23);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sats.Properties.Resources.Search_16x;
            this.pictureBox1.Location = new System.Drawing.Point(702, 170);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblTopTelaPontos
            // 
            this.lblTopTelaPontos.AutoSize = true;
            this.lblTopTelaPontos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTopTelaPontos.Location = new System.Drawing.Point(69, 42);
            this.lblTopTelaPontos.Name = "lblTopTelaPontos";
            this.lblTopTelaPontos.Size = new System.Drawing.Size(69, 22);
            this.lblTopTelaPontos.TabIndex = 1;
            this.lblTopTelaPontos.Text = "Macros";
            this.lblTopTelaPontos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMacrosPonto
            // 
            this.lbMacrosPonto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMacrosPonto.FormattingEnabled = true;
            this.lbMacrosPonto.ItemHeight = 15;
            this.lbMacrosPonto.Location = new System.Drawing.Point(0, 0);
            this.lbMacrosPonto.Name = "lbMacrosPonto";
            this.lbMacrosPonto.Size = new System.Drawing.Size(730, 256);
            this.lbMacrosPonto.TabIndex = 0;
            // 
            // FormMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(804, 557);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNovoMacro);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMacro";
            this.Text = "Macros";
            this.Load += new System.EventHandler(this.FormMacro_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNovoMacro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTopTelaPontos;
        private System.Windows.Forms.ListBox lbMacrosPonto;
    }
}