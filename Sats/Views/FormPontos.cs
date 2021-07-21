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
    public partial class FormPontos : Form
    {

        public FormPontos()
        {
            InitializeComponent();
        }

        private void FormPonto_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Select(s => new {
                        s.Nome_Ponto, 
                        s.Macro_ID, 
                        s.Tipo_Medidor}).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            lbPontosPontos.Items.Add($"{item.Nome_Ponto}");
                            string[] listview = new string[3];
                            listview[0] = item.Nome_Ponto;
                            listview[1] = item.Macro_ID.ToString();
                            listview[2] = item.Tipo_Medidor;
                            lvPontosPontos.Items.Add(new ListViewItem(listview));
                        }                                               
                    }
                }
            }
            catch (Exception)   
            {
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovoPonto_Click(object sender, EventArgs e)
        {
            FormNovoPonto form = new();
            form.Show();
        }

        private void lbPontosPontos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pegaItem = lbPontosPontos.SelectedItem.ToString();
        }

        private void lvPontosPontos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
