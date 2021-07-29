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
        int id;
        string ponto;
        bool verifica = false;
        bool isEdit;
        public FormLeituraVazão()
        {
            this.isEdit = false;
            InitializeComponent();
        }
        public FormLeituraVazão(string ponto, int idLeitura)
        {
            this.isEdit = true;
            this.ponto = ponto;
            InitializeComponent();
            verifica = true;
            labTítuloV.Text = "Atualiza Leitura Vazão";
            BuscaLeitura(idLeitura);
        }
        private void BuscaLeitura(int id)
        {
            using (var context = new Context())
            {
                var query = context.LeituraVazãos.Where(s => s.ID_Leitura == id).Select(s => new
                {
                    s.ID_Leitura,
                    s.Leiturista,
                    s.Ponto_Leitura,
                    s.Valor_Leitura,
                    s.Data_Hora,                       
                    s.Ponto
                }).First();
                if (query!= null)
                {
                    cbLeituraVPonto.Text = $"{query.Ponto.ID_Ponto} - {query.Ponto.Nome_Ponto}";
                    txtLeituristaV.Text = query.Leiturista;
                    txtLeituraVazão.Text = query.Valor_Leitura.ToString();
                    mtxDataHoraV.Text = query.Data_Hora.ToString();
                }
                else
                {
                    MessageBox.Show("Ponto Não encontrado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }
        private void CadLeitura()
        {
            try
            {
                using (var context = new Context())
                {
                    if (!isEdit)
                    {
                        LeituraVazão leituraVazão = new();
                        leituraVazão.Ponto_Leitura = Convert.ToInt32(cbLeituraVPonto.SelectedItem.ToString().Split(" - ")[0]);
                        leituraVazão.Leiturista = txtLeituristaV.Text;
                        leituraVazão.Valor_Leitura = (float)(float.Parse(txtLeituraVazão.Text) * 3.6);
                        leituraVazão.Data_Hora = Convert.ToDateTime(mtxDataHoraV.Text);
                        context.LeituraVazãos.Add(leituraVazão);
                        context.SaveChanges();
                        MessageBox.Show("Nova leitura salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        var query = context.LeituraVazãos.Where(s => s.ID_Leitura == id).FirstOrDefault();
                        query.Ponto_Leitura = Convert.ToInt32(cbLeituraVPonto.SelectedItem.ToString().Split(" - ")[0]);
                        query.Leiturista = txtLeituristaV.Text;
                        query.Valor_Leitura = (float)(float.Parse(txtLeituraVazão.Text) * 3.6);
                        query.Data_Hora = Convert.ToDateTime(mtxDataHoraV.Text);
                        context.SaveChanges();
                        MessageBox.Show("Leitura editada com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível salvar a Leitura, tente novamente.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }
        }
        private void FormLeituraVazão_Load(object sender, EventArgs e)
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
                                cbLeituraVPonto.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                            }
                        }
                    }
                }
                else
                {
                    cbLeituraVPonto.Items.Add(ponto);
                    cbLeituraVPonto.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi Possível Carregar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvarLeituraV_Click(object sender, EventArgs e)
        {

            CadLeitura();
        }
    }
}
