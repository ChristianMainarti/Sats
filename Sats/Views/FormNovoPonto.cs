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
        int id;
        bool isEdit;
        string macro;
        int idMacro;
        bool verifica = false;
        public FormNovoPonto()
        {
            this.isEdit = false;
            InitializeComponent();
        }
        public FormNovoPonto(int id, string macro)
        {
            this.isEdit = true;
            this.id = id;
            this.macro = macro.Split(" - ")[4];
            idMacro = Convert.ToInt32(macro.Split(" - ")[3]);
            InitializeComponent();
            verifica = true;
            labPontoPonto.Text = "Atualizar Ponto";
            BuscaPonto(id, macro);
        }
        private void CadPonto()
        {
            try
            {
                using (var context = new Context())
                {
                    if (!isEdit)
                    {
                        Ponto ponto = new();
                        ConfigNv configNv = new();
                        ponto.Macro_ID = Convert.ToInt32(cboxPontoMacro.SelectedItem.ToString().Split("-")[0]);
                        ponto.Nome_Ponto = txtNomePonto.Text;
                        ponto.Endereço_Ponto = txtEndereço.Text;
                        ponto.Nome_Medidor = txtNomeMedidor.Text;
                        ponto.Tipo_Medidor = cbxPontoTipo.Text;
                        configNv.LimSup = Convert.ToInt32(txtLimSup.Text);
                        configNv.LimInf = Convert.ToInt32(txtLimInf.Text);
                        context.ConfigNvs.Add(configNv);
                        context.Pontos.Add(ponto);
                        context.SaveChanges();
                        MessageBox.Show("Novo ponto salvo com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        var query = context.Pontos.Where(s => s.ID_Ponto == id).FirstOrDefault();
                        query.Macro_ID = idMacro;
                        query.Nome_Ponto = txtNomePonto.Text;
                        query.Endereço_Ponto = txtEndereço.Text;
                        query.Nome_Medidor = txtNomeMedidor.Text;
                        query.Tipo_Medidor = cbxPontoTipo.Text;
                        var query2 = context.ConfigNvs.Where(s => s.Ponto_ID == id).FirstOrDefault();
                        query2.LimSup = Convert.ToInt32(txtLimSup.Text);
                        query2.LimInf = Convert.ToInt32(txtLimInf.Text);
                        context.SaveChanges();
                        MessageBox.Show("Ponto editado com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Não foi Possível salvar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void BuscaPonto(int id, string macro)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Where(s => s.ID_Ponto == id).Select(s => new {
                        s.ID_Ponto,
                        s.Endereço_Ponto,
                        s.Nome_Ponto,
                        s.Tipo_Medidor,
                        s.Nome_Medidor,
                        s.Macro,
                    }).First();
                    if (query != null)
                    {
                        txtNomePonto.Text = query.Nome_Ponto;
                        txtEndereço.Text = query.Endereço_Ponto;
                        txtNomeMedidor.Text = query.Nome_Medidor;
                        cboxPontoMacro.Text = $"{query.Macro.ID} - {query.Macro.Nome_Macro}";
                        cbxPontoTipo.Text = query.Tipo_Medidor;
                    }
                    else
                    {
                        MessageBox.Show("Ponto Não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void btnSalvarNovoPonto_Click(object sender, EventArgs e)
        {
            CadPonto();           
        }
        private void Pontos_Load(object sender, EventArgs e)
        {
            try
            {
                if (!verifica)
                {
                    using (var context = new Context())
                    {
                        var query = context.Macros.Select(s => new { s.ID, s.Nome_Macro });
                        if (query != null)
                        {
                            foreach (var item in query)
                            {
                                cboxPontoMacro.Items.Add($"{item.ID} - {item.Nome_Macro}");
                            }
                        }
                    }
                }
                else
                {
                    cboxPontoMacro.Items.Add(macro);
                    cboxPontoMacro.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi possivel carregar os pontos","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
