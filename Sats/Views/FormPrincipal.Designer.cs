
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
            this.cadastrarLeituraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bombaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nivelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
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
            // 
            // cadastrarLeituraToolStripMenuItem
            // 
            this.cadastrarLeituraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vazãoToolStripMenuItem,
            this.bombaToolStripMenuItem,
            this.nivelToolStripMenuItem});
            this.cadastrarLeituraToolStripMenuItem.Name = "cadastrarLeituraToolStripMenuItem";
            this.cadastrarLeituraToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cadastrarLeituraToolStripMenuItem.Text = "Cadastrar Leitura";
            // 
            // vazãoToolStripMenuItem
            // 
            this.vazãoToolStripMenuItem.Name = "vazãoToolStripMenuItem";
            this.vazãoToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.vazãoToolStripMenuItem.Text = "Vazão";
            this.vazãoToolStripMenuItem.Click += new System.EventHandler(this.vazãoToolStripMenuItem_Click);
            // 
            // bombaToolStripMenuItem
            // 
            this.bombaToolStripMenuItem.Name = "bombaToolStripMenuItem";
            this.bombaToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.bombaToolStripMenuItem.Text = "Bomba";
            this.bombaToolStripMenuItem.Click += new System.EventHandler(this.bombaToolStripMenuItem_Click);
            // 
            // nivelToolStripMenuItem
            // 
            this.nivelToolStripMenuItem.Name = "nivelToolStripMenuItem";
            this.nivelToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.nivelToolStripMenuItem.Text = "Nivel";
            this.nivelToolStripMenuItem.Click += new System.EventHandler(this.nivelToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sats.Properties.Resources.sats1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 637);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}