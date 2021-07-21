using Sats.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sats
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void leiturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMacro form = new FormMacro();
            form.Show();
        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPontos form = new FormPontos();
            form.Show();
        }

        private void vazãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraBomba form = new();
            form.Show();
        }
    }
}
