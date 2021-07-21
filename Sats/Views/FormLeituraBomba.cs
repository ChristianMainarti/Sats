﻿using Sats.Models;
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
    public partial class FormLeituraBomba : Form
    {
        public FormLeituraBomba()
        {
            InitializeComponent();
        }

        private void FormLeituraBomba_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Pontos.Select(s => new {s.ID_Ponto, s.Nome_Ponto});
                    if (query!=null)
                    {
                        foreach (var item in query)
                        {
                            cbLeituraB.Items.Add($"{item.ID_Ponto} - {item.Nome_Ponto}");
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalvarLeituraB_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    LeituraBomba leituraBomba = new();
                    leituraBomba.Ponto_Leitura = Convert.ToInt32(cbLeituraB.SelectedItem.ToString().Split(" - ")[0]);
                    leituraBomba.Leiturista = txtLeituristaB.Text;
                    leituraBomba.Data_Hora = Convert.ToDateTime(mtbDataHoraB.Text);
                    leituraBomba.Valor_Leitura = Convert.ToBoolean(Convert.ToInt32(cbEstadoMedidor.SelectedItem.ToString()));

                    context.LeituraBombas.Add(leituraBomba);
                    context.SaveChanges();
                }
                MessageBox.Show("Nova leitura salva com sucesso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi Possível salvar!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}