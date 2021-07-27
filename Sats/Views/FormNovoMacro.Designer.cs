
namespace Sats.Views
{
    partial class FormNovoMacro
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMacro = new System.Windows.Forms.TextBox();
            this.btnSalvarNovoMacro = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNomeMacro
            // 
            this.txtNomeMacro.Location = new System.Drawing.Point(101, 112);
            this.txtNomeMacro.Name = "txtNomeMacro";
            this.txtNomeMacro.Size = new System.Drawing.Size(186, 23);
            this.txtNomeMacro.TabIndex = 1;
            // 
            // btnSalvarNovoMacro
            // 
            this.btnSalvarNovoMacro.BackColor = System.Drawing.Color.LightBlue;
            this.btnSalvarNovoMacro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvarNovoMacro.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalvarNovoMacro.Location = new System.Drawing.Point(39, 178);
            this.btnSalvarNovoMacro.Name = "btnSalvarNovoMacro";
            this.btnSalvarNovoMacro.Size = new System.Drawing.Size(79, 33);
            this.btnSalvarNovoMacro.TabIndex = 2;
            this.btnSalvarNovoMacro.Text = "Salvar";
            this.btnSalvarNovoMacro.UseVisualStyleBackColor = false;
            this.btnSalvarNovoMacro.Click += new System.EventHandler(this.btnSalvarNovoMacro_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // FormNovoMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(354, 285);
            this.Controls.Add(this.btnSalvarNovoMacro);
            this.Controls.Add(this.txtNomeMacro);
            this.Controls.Add(this.label1);
            this.Name = "FormNovoMacro";
            this.Text = "Novo Macro";
            this.Load += new System.EventHandler(this.FormNovoMacro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMacro;
        private System.Windows.Forms.Button btnSalvarNovoMacro;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}