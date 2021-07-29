    using Sats.Models;
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
    public partial class FormTelaPontos : Form
    {
        int id;
        string macro;
        public FormTelaPontos()
        {
            InitializeComponent();
        }
        public FormTelaPontos(int id, string macro)
        {
            this.macro = macro;
            
            InitializeComponent();
            CarregaDados();
        }
        private void CarregaDados()
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Select(s => new {
                        s.ID_Ponto,
                        s.Nome_Ponto,
                        s.Macro_ID,
                        s.Tipo_Medidor,
                        s.Macro.Nome_Macro
                    }).ToList();
                    
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            listbPontosPontos.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto} - {item.Tipo_Medidor} - {item.Macro_ID} - {item.Nome_Macro}");
                            string[] listview = new string[4];
                            listview[0] = item.Nome_Ponto;
                            listview[1] = item.Macro_ID.ToString();
                            listview[2] = item.Nome_Macro;
                            listview[3] = item.Tipo_Medidor;
                            lvPontosPontos.Items.Add(new ListViewItem(listview));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                MessageBox.Show("Não foi possivel carregar os dados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormPonto_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void ApagaPonto(int id)
        {
            if (MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Where(s => s.ID_Ponto == id).First();
                    if (query != null)
                    {
                        context.Pontos.Remove(query);
                        context.SaveChanges();
                        listbPontosPontos.Items.Clear();
                        lvPontosPontos.Items.Clear();
                        CarregaDados();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi possivel apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CadPonto()
        {
            FormNovoPonto form = new();
            form.ShowDialog();
            listbPontosPontos.Items.Clear();
            lvPontosPontos.Items.Clear();
            CarregaDados();
        }
        private void EditaPonto()
        {
            try
            {
                int id = Convert.ToInt32(listbPontosPontos.SelectedItem.ToString().Split(" - ")[0]);
                string macro = listbPontosPontos.SelectedItem.ToString();
                using var context = new Context();
                {

                    FormNovoPonto form = new(id, macro);
                    form.ShowDialog();
                    listbPontosPontos.Items.Clear();
                    lvPontosPontos.Items.Clear();
                    CarregaDados();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnNovoPonto_Click(object sender, EventArgs e)
        {
            CadPonto();    
        }
        private void btnAttPonto_Click(object sender, EventArgs e)
        {
            EditaPonto();
        }
        private void btnApagarPonto_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new Context();
                {
                    int id = Convert.ToInt32(listbPontosPontos.SelectedItem.ToString().Split(" - ")[0]);
                    ApagaPonto(id);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void SelecionaTipoLeitura(string tipo)
        {
            try
            {
                string tipol = tipo.Split(" - ")[2];
                using (var context = new Context())
                {
                    var query = context.Pontos.Where(s => s.Tipo_Medidor == tipol).FirstOrDefault();
                    if (query!=null )
                    {
                        if (tipol == "Vazão")
                        {
                            FormLeituraVazão form = new();
                            form.ShowDialog();
                        }
                        else if (tipol == "Bomba")
                        {
                            FormLeituraBomba form = new();
                            form.ShowDialog();
                        }
                        else
                        {
                            FormLeituraNível form = new();
                            form.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível selecionar, favor confir o tipo do ponto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNovaLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (listbPontosPontos.SelectedIndex > -1)
                {
                    using var context = new Context();
                    {
                        string ponto = listbPontosPontos.SelectedItem.ToString();
                        SelecionaTipoLeitura(ponto);
                    }
                }
                else 
                {
                    MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível Salvar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnMostraLeiturasPonto_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = listbPontosPontos.SelectedItem.ToString();
                FormPonto form = new(tipo);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
