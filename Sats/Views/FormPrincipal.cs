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
        private void cadastrarMacroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoMacro form = new();
            form.ShowDialog();
            Close();
        }

        private void pontosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTelaPontos form = new ();
            form.ShowDialog();
        }

        private void cadastrarPontoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNovoPonto form = new();
            form.ShowDialog();
        }

        private void vazãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraVazão form = new();
            form.ShowDialog();
        }

        private void bombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraBomba form = new();
            form.ShowDialog();
        }
        private void nivelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeituraNível form = new();
            form.ShowDialog();
        }

        private void macrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMacro form = new();
            form.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
