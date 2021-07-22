﻿using Sats.Models;
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
        public FormTelaPontos()
        {
            InitializeComponent();
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
                        s.Tipo_Medidor
                    }).ToList();
                    if (query != null)
                    {
                        foreach (var item in query)
                        {
                            listbPontosPontos.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
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
        private void FormPonto_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
        public void ApagaPonto(int id)
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
                        listbPontosPontos.Items.Clear();
                        lvPontosPontos.Items.Clear();
                        CarregaDados();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private void btnNovoPonto_Click(object sender, EventArgs e)
        {
            FormNovoPonto form = new();
            form.Show();
            listbPontosPontos.Items.Clear();
            lvPontosPontos.Items.Clear();
            CarregaDados();
        }

        private void lbPontosPontos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pegaItem = listbPontosPontos.SelectedItem.ToString();   

        }

        private void btnAttPonto_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new Context();
                {
                    int id = Convert.ToInt32(listbPontosPontos.SelectedItem.ToString().Split(" - ")[0]);
                    FormNovoPonto form = new(id);
                    form.Show();
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }    
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
                MessageBox.Show("Selecione o Ponto antes de clicar na operação", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
