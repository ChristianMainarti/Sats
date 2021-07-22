
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.lvPontoLeituras);
            this.panel1.Location = new System.Drawing.Point(227, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 272);
            this.panel1.TabIndex = 0;
            // 
            // lvPontoLeituras
            // 
            this.lvPontoLeituras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPontoLeituras.HideSelection = false;
            this.lvPontoLeituras.Location = new System.Drawing.Point(0, 0);
            this.lvPontoLeituras.Name = "lvPontoLeituras";
            this.lvPontoLeituras.Size = new System.Drawing.Size(420, 272);
            this.lvPontoLeituras.TabIndex = 0;
            this.lvPontoLeituras.UseCompatibleStateImageBehavior = false;
            this.lvPontoLeituras.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 126);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ultimas Leituras";
            // 
            // FormPonto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(659, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FormPonto";
            this.Text = "FormPonto";
            this.Load += new System.EventHandler(this.FormPonto_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvPontoLeituras;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}