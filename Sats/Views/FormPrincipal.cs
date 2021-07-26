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
            FormNovoMacro form = new();
            form.Show();
        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTelaPontos form = new ();
            form.Show();
        }

        private void cadastrarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoPonto form = new();
            form.Show();
        }

        private void vazãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraVazão form = new();
            form.Show();
        }

        private void bombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraBomba form = new();
            form.Show();
        }
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraNível form = new();
            form.Show();
        }

        private void macrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMacro form = new();
            form.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
