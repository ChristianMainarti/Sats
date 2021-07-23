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
    public partial class FormLeituraNível : Form
    {
        public FormLeituraNível()
        {
            InitializeComponent();
        }

        private void FormLeituraNível_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var queryP = context.Pontos.Select(r => new { r.ID_Ponto, r.Nome_Ponto}).ToList();
                    if (queryP!=null)
                    {
                        foreach (var item in queryP)
                        {
                            cbLeituraNPonto.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                        }
                    }                    
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnSalvarLeituraN_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    LeituraNível leituraNível = new();
                    leituraNível.Ponto_Leitura = Convert.ToInt32(cbLeituraNPonto.SelectedItem.ToString().Split(" - ")[0]);
                    leituraNível.Leiturista = txtLeituristaN.Text;
                    leituraNível.Valor_Leitura = float.Parse(txtValorLeituraN.Text);
                    leituraNível.Data_Hora = Convert.ToDateTime(txtDataHoraN.Text);

                    context.LeituraNívels.Add(leituraNível);
                    context.SaveChanges();
                }
                MessageBox.Show("Nova leitura salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi Possível salvar!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
