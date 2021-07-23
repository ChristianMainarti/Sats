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
        
        public FormPonto(string tipo)
        {
            this.tipo = tipo;
            InitializeComponent();
            CarregaDados(tipo);
        }
        private void CarregaDados(string tipo)
        {
            //try
            //{
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
                    else if (tipo == "bomba")
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
            //}
            //catch (Exception)
            //{            
            //}
        }
        private void FormPonto_Load(object sender, EventArgs e)
        {           
        }
        private void btnEditarPonto_Click(object sender, EventArgs e)
        {

        }
        private void btnNovaLeitura_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void lvPontoLeituras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
