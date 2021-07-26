
namespace Sats
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.macrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leiturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bombaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarLeituraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.macrosToolStripMenuItem,
            this.pontosToolStripMenuItem,
            this.leiturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // macrosToolStripMenuItem
            // 
            this.macrosToolStripMenuItem.Name = "macrosToolStripMenuItem";
            this.macrosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.macrosToolStripMenuItem.Text = "Macros";
            this.macrosToolStripMenuItem.Click += new System.EventHandler(this.macrosToolStripMenuItem_Click);
            // 
            // pontosToolStripMenuItem
            // 
            this.pontosToolStripMenuItem.Name = "pontosToolStripMenuItem";
            this.pontosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.pontosToolStripMenuItem.Text = "Pontos";
            this.pontosToolStripMenuItem.Click += new System.EventHandler(this.pontosToolStripMenuItem_Click);
            // 
            // leiturasToolStripMenuItem
            // 
            this.leiturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarLeituraToolStripMenuItem});
            this.leiturasToolStripMenuItem.Name = "leiturasToolStripMenuItem";
            this.leiturasToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.leiturasToolStripMenuItem.Text = "Leituras";
            this.leiturasToolStripMenuItem.Click += new System.EventHandler(this.leiturasToolStripMenuItem_Click);
            // 
            // vazãoToolStripMenuItem
            // 
            this.vazãoToolStripMenuItem.Name = "vazãoToolStripMenuItem";
            this.vazãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vazãoToolStripMenuItem.Text = "Vazão";
            this.vazãoToolStripMenuItem.Click += new System.EventHandler(this.vazãoToolStripMenuItem_Click);
            // 
            // bombaToolStripMenuItem
            // 
            this.bombaToolStripMenuItem.Name = "bombaToolStripMenuItem";
            this.bombaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bombaToolStripMenuItem.Text = "Bomba";
            this.bombaToolStripMenuItem.Click += new System.EventHandler(this.bombaToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nivelToolStripMenuItem.Text = "Nivel";
            this.nivelToolStripMenuItem.Click += new System.EventHandler(this.nivelToolStripMenuItem_Click);
            // 
            // cadastrarLeituraToolStripMenuItem
            // 
            this.cadastrarLeituraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vazãoToolStripMenuItem,
            this.bombaToolStripMenuItem,
            this.nivelToolStripMenuItem});
            this.cadastrarLeituraToolStripMenuItem.Name = "cadastrarLeituraToolStripMenuItem";
            this.cadastrarLeituraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarLeituraToolStripMenuItem.Text = "Cadastrar Leitura";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem macrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pontosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leiturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarLeituraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bombaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nivelToolStripMenuItem;
    }
}