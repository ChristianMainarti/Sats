using Sats.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sats.Views
{
    public partial class FormNovoPonto : Form
    {
        public FormNovoPonto()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var Context = new Context())
                {
                    var query = Context.Set<Ponto>();
                    query.Add(new Ponto
                    {
//                        Macro = cboxPontoMacro.SelectedItem.ToString()
                        Nome_Ponto = txtNomePonto.Text,
                        Endereço_Ponto = txtEndereço.Text,
                        Nome_Medidor = txtNomeMedidor.Text,
                        Tipo_Medidor = cbxPontoTipo.SelectedItem.ToString()
                    });
                }
            }
            catch(InvalidCastException)
            {
                Console.WriteLine("Tente Novamente");
            }
        }

        private void cbxPontoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeMedidor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
