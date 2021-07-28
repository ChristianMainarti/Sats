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
    public partial class FormPonto : Form
    {
        string tipo;
        int idleitura;
        int idponto;
        string ponto;
        public FormPonto(string ponto)
        {
            this.ponto = ponto;
            tipo = ponto.Split(" - ")[2];
            idponto = Convert.ToInt32(ponto.Split(" - ")[0]);
            InitializeComponent();
            CarregaDados();
        }
        public FormPonto()
        {
            InitializeComponent();
        }
        private void CadLeitura()
        {
            try
            {
                if (tipo == "Vazão")
                {
                    FormLeituraVazão form = new();
                    form.ShowDialog();
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
                else if (tipo == "Bomba")
                {
                    FormLeituraBomba form = new();
                    form.ShowDialog();
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
                else
                {
                    FormLeituraNível form = new();
                    form.ShowDialog();
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi Possível Salvar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            lvPontoLeituras.Items.Clear();
            CarregaDados();
        }
        private void EditaLeitura()
        {
            int idLeitura = Convert.ToInt32(lvPontoLeituras.SelectedItems[0].Text);
            try
            { 
                using var context = new Context();
                if (tipo == "Vazão")
                {
                    FormLeituraVazão formVazão = new(ponto, idLeitura);
                    formVazão.ShowDialog();
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
                else if (tipo == "Bomba")
                {
                    FormLeituraBomba formBomba = new(ponto, idLeitura);
                    formBomba.ShowDialog();
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
                else
                {
                    FormLeituraNível formNível = new(ponto, idLeitura);
                    formNível.ShowDialog(); 
                    lvPontoLeituras.Items.Clear();
                    CarregaDados();
                }
                lvPontoLeituras.Items.Clear();
                CarregaDados();
                lvPontoLeituras.Items.Clear();
                CarregaDados();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi Possível editar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }
        private void ApagaLeitura(int id)
        {
            if (MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            id = Convert.ToInt32(lvPontoLeituras.SelectedItems[0].Text);
            try
            {
                using (var context = new Context())
                {

                    if (tipo == "Bomba")
                    {
                        var query = context.LeituraBombas.Where(s => s.ID_Leitura == id).FirstOrDefault();
                        if (query != null)
                        {
                            context.LeituraBombas.Remove(query);
                            context.SaveChanges();
                            lvPontoLeituras.Items.Clear();
                            CarregaDados();
                        }
                        else
                        {
                            MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (tipo=="Vazão")
                    {
                        var query = context.LeituraVazãos.Where(s => s.ID_Leitura == id).FirstOrDefault();
                        if (query != null)
                        {
                            context.LeituraVazãos.Remove(query);
                            context.SaveChanges();
                            lvPontoLeituras.Items.Clear();
                            CarregaDados();
                        }
                        else
                        {
                            MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        var query = context.LeituraNívels.Where(s => s.ID_Leitura == id).FirstOrDefault();
                        if (query != null)
                        {
                            context.LeituraNívels.Remove(query);
                            context.SaveChanges();
                            lvPontoLeituras.Items.Clear();
                            CarregaDados();
                        }
                        else
                        {
                            MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CarregaDados()
        {
            try
            {
                using (var context = new Context())
                {               
                    if (tipo == "Vazão")
                    {
                        {
                            var query = context.LeituraVazãos.Where(s=> s.Ponto_Leitura == idponto).Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura,
                                s.ID_Leitura,
                                s.Ponto.Nome_Ponto
                            }).ToList();                            
                                if (query != null)
                                {
                                foreach (var item in query)
                                {
                                    string[] listview = new string[5];
                                    listview[0] = item.ID_Leitura.ToString();
                                    listview[1] = item.Nome_Ponto;
                                    listview[2] = item.Leiturista;
                                    listview[3] = item.Data_Hora.ToString();
                                    listview[4] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                    else if (tipo == "Bomba")
                    {
                        {
                            var query = context.LeituraBombas.Where(s => s.Ponto_Leitura == idponto).Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura,
                                s.ID_Leitura,
                                s.Ponto.Nome_Ponto
                            }).ToList();                                               
                            if (query != null)
                            {
                                foreach (var item in query)
                                {
                                    string[] listview = new string[5];
                                    listview[0] = item.ID_Leitura.ToString();
                                    listview[1] = item.Nome_Ponto;
                                    listview[2] = item.Leiturista;
                                    listview[3] = item.Data_Hora.ToString();
                                    listview[4] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                    else
                    {
                        {
                            var query = context.LeituraNívels.Where(s => s.Ponto_Leitura == idponto).Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura,
                                s.ID_Leitura,
                                s.Ponto.Nome_Ponto
                            }).ToList();                           
                            if (query != null)
                            {
                                foreach (var item in query)
                                {
                                    string[] listview = new string[5];
                                    listview[0] = item.ID_Leitura.ToString();
                                    listview[1] = item.Nome_Ponto;
                                    listview[2] = item.Leiturista;
                                    listview[3] = item.Data_Hora.ToString();
                                    listview[4] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                }                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi Possível Carregar as Leituras!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormPonto_Load(object sender, EventArgs e)
        {           
        }
        private void btnNovaLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                CadLeitura();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

        private void btnEditaLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                EditaLeitura();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnApagaLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                ApagaLeitura(idleitura);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi Possível apagar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
