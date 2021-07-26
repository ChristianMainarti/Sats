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
        int id;
        
        public FormPonto(string tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            CarregaDados(tipo);
        }
        public FormPonto()
        {
            InitializeComponent();

        }
        private void CadLeitura()
        {
            if (tipo == "Vazão")
            {
                FormLeituraVazão form = new();
                form.Show();
            }
            else if (tipo == "Bomba")
            {
                FormLeituraBomba form = new();
                form.Show();
            }
            else
            {
                FormLeituraNível form = new();
                form.Show();
            }
        }
        private void EditaLeitura()
        {
            using var context = new Context();
            {
                int id = Convert.ToInt32(clbLeituraPontos.SelectedItem.ToString().Split(" - ")[0]);
                if (tipo == "Vazão")
                {
                    FormLeituraVazão formVazão = new(id);
                    formVazão.Show();
                }
                else if (tipo == "Bomba")
                {
                    FormLeituraBomba formBomba = new(id);
                    formBomba.Show();
                }
                else
                {
                    FormLeituraNível formNível = new(id);
                    formNível.Show();
                }
                
                clbLeituraPontos.Items.Clear();
                lvPontoLeituras.Items.Clear();
                CarregaDados(tipo);
            }
        }
        private void ApagaLeitura(int id)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Where(s => s.ID_Ponto == id).First();
                    if (query != null)
                    {
                        context.Pontos.Remove(query);
                        context.SaveChanges();
                        clbLeituraPontos.Items.Clear();
                        lvPontoLeituras.Items.Clear();
                        CarregaDados(tipo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void CarregaDados(string tipo)
        {
            try
            {
                using (var context = new Context())
                {               
                    if (tipo == "Vazão")
                    {
                        {
                            var query = context.LeituraVazãos.Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura
                            }).ToList();
                            var query2 = context.Pontos.Select(s => new
                            {
                                s.ID_Ponto,
                                s.Nome_Ponto
                            }
                            ).ToList();
                            if (query2 != null)
                            {
                                foreach (var item in query2)
                                {
                                    clbLeituraPontos.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                                }
                            }
                                if (query != null)
                                {
                                foreach (var item in query)
                                {
                                    clbLeituraPontos.Items.Add($"{item.Ponto_Leitura}");
                                    string[] listview = new string[4];
                                    listview[0] = item.Ponto_Leitura.ToString();
                                    listview[1] = item.Leiturista;
                                    listview[2] = item.Data_Hora.ToString();
                                    listview[3] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                    else if (tipo == "Bomba")
                    {
                        {
                            var query = context.LeituraBombas.Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura
                            }).ToList();
                            if (query != null)
                            {
                                foreach (var item in query)
                                {
                                    clbLeituraPontos.Items.Add($"{item.Ponto_Leitura}");
                                    string[] listview = new string[4];
                                    listview[0] = item.Ponto_Leitura.ToString();
                                    listview[1] = item.Leiturista;
                                    listview[2] = item.Data_Hora.ToString();
                                    listview[3] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                    else
                    {
                        {
                            var query = context.LeituraNívels.Select(s => new
                            {
                                s.Ponto_Leitura,
                                s.Leiturista,
                                s.Data_Hora,
                                s.Valor_Leitura
                            }).ToList();
                            if (query != null)
                            {
                                foreach (var item in query)
                                {
                                    clbLeituraPontos.Items.Add($"{item.Ponto_Leitura}");
                                    string[] listview = new string[4];
                                    listview[0] = item.Ponto_Leitura.ToString();
                                    listview[1] = item.Leiturista;
                                    listview[2] = item.Data_Hora.ToString();
                                    listview[3] = item.Valor_Leitura.ToString();
                                    lvPontoLeituras.Items.Add(new ListViewItem(listview));
                                }
                            }
                        }
                    }
                }                
            }
            catch (Exception)
            {            
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
            }
        }
        private void btnApagaLeitura_Click(object sender, EventArgs e)
        {
            try
            {
                ApagaLeitura(id);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private void clbLeituraPontos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
