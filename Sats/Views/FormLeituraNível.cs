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
        int id;
        string ponto;
        bool verifica = false;
        public FormLeituraNível()
        {
            InitializeComponent();
        }
        public FormLeituraNível(string ponto,int idLeitura)
        {
            this.ponto = ponto;
            InitializeComponent();
            verifica = true;
            labTítuloN.Text = "Atualiza Leitura Nível";

            BuscaLeitura(idLeitura);
        }
        private void BuscaLeitura(int id)
        {
            using (var context = new Context())
            {
                var query = context.LeituraNívels.Where(s => s.ID_Leitura == id).Select(s => new
                {
                    s.ID_Leitura,
                    s.Leiturista,
                    s.Ponto_Leitura,
                    s.Valor_Leitura,
                    s.Data_Hora,
                    s.Ponto,                    
                }).First();
                if (query != null)
                {
                    cbLeituraNPonto.Text = $"{query.Ponto.ID_Ponto} - {query.Ponto.Nome_Ponto}";
                    txtLeituristaN.Text = query.Leiturista;
                    txtValorLeituraN.Text = query.Valor_Leitura.ToString();
                    txtDataHoraN.Text = query.Data_Hora.ToString();
                }
                else
                {
                    MessageBox.Show("Ponto Não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void FormLeituraNível_Load(object sender, EventArgs e)
        {
            try
            {
                if (!verifica)
                {
                    using (var context = new Context())
                    {
                        var query = context.Pontos.Select(s => new { s.ID_Ponto, s.Nome_Ponto });
                        if (query != null)
                        {
                            foreach (var item in query)
                            {
                                cbLeituraNPonto.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                            }
                        }
                    }
                }
                else
                {
                    cbLeituraNPonto.Items.Add(ponto);
                    cbLeituraNPonto.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi Possível Carregar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarLeituraN_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    LeituraNível leituraNível = new();
                    var Ponto_ID = Convert.ToInt32(cbLeituraNPonto.SelectedItem.ToString().Split(" - ")[0]);
                    var query = context.ConfigNvs.Where(s => s.Ponto_ID == Ponto_ID).First();
                    leituraNível.Ponto_Leitura = Ponto_ID;
                    leituraNível.Leiturista = txtLeituristaN.Text;
                    leituraNível.Valor_Leitura = (float.Parse(txtValorLeituraN.Text) - 4)*(query.LimSup - query.LimInf)/16 + query.LimInf;
                    leituraNível.Data_Hora = Convert.ToDateTime(txtDataHoraN.Text);                 
                    context.LeituraNívels.Add(leituraNível);
                    context.SaveChanges();
                }
                MessageBox.Show("Nova leitura salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi Possível salvar!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
