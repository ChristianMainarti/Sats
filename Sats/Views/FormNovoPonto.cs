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

        public FormNovoPonto(int id)
        {
            InitializeComponent();
            labPontoPonto.Text = "Atualizar Ponto";
            BuscaDados(id);
        }

        public void BuscaDados(int id)
        {            
            using (var context = new Context())
            {
                var query = context.Pontos.Where(s => s.ID_Ponto == id).Select(s=> new {
                    s.ID_Ponto,
                    s.Endereço_Ponto,
                    s.Nome_Ponto,
                    s.Tipo_Medidor,
                    s.Nome_Medidor,
                    s.Macro,
                }).First();
                if (query!= null)
                {
                    txtNomePonto.Text = query.Nome_Ponto;
                    txtEndereço.Text = query.Endereço_Ponto;
                    txtNomeMedidor.Text = query.Nome_Medidor;
                    cboxPontoMacro.Text = $"{query.Macro.ID} - {query.Macro.Nome_Macro}";
                    cbxPontoTipo.Text = query.Tipo_Medidor;
                }
            }
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
                    Ponto ponto = new();
                    ponto.Macro_ID = Convert.ToInt32(cboxPontoMacro.SelectedItem.ToString().Split("-")[0]);
                    ponto.Nome_Ponto = txtNomePonto.Text;
                    ponto.Endereço_Ponto = txtEndereço.Text;
                    ponto.Nome_Medidor = txtNomeMedidor.Text;
                    ponto.Tipo_Medidor = cbxPontoTipo.Text;

                    Context.Pontos.Add(ponto);
                    Context.SaveChanges();
                }
                MessageBox.Show("Novo ponto salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch   
            {
                MessageBox.Show("Não foi Possível salvar!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void cbxPontoTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeMedidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pontos_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Macros.Select(s => new { s.ID, s.Nome_Macro }).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            cboxPontoMacro.Items.Add($"{item.ID} - {item.Nome_Macro}");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
