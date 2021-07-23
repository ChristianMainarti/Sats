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
    public partial class FormLeituraVazão : Form
    {
        public FormLeituraVazão()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormLeituraVazão_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Select(s => new {s.ID_Ponto, s.Nome_Ponto});
                    if (query!=null)
                    {
                        foreach (var item in query)
                        {
                            cbLeituraVPonto.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                        }
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }

        private void btnSalvarLeituraV_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    LeituraVazão leituraVazão = new();
                    leituraVazão.Ponto_Leitura = Convert.ToInt32(cbLeituraVPonto.SelectedItem.ToString().Split(" - ")[0]);
                    leituraVazão.Leiturista = txtLeituristaV.Text;
                    leituraVazão.Valor_Leitura = (float)(float.Parse(txtLeituraVazão.Text) * 3.6);
                    leituraVazão.Data_Hora = Convert.ToDateTime(mtxDataHoraV.Text);

                context.LeituraVazãos.Add(leituraVazão);
                context.SaveChanges();                
                }
                MessageBox.Show("Nova leitura salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível salvar a Leitura, tente novamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
