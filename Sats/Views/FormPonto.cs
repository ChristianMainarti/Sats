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
        public FormPonto()
        {
            InitializeComponent();
        }
        private void CarregaDados()
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Leituras.Select(s => new {
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
            catch (Exception)
            {

                throw;
            }
        }
        private void FormPonto_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void btnEditarPonto_Click(object sender, EventArgs e)
        {
           
        }
    }
}
