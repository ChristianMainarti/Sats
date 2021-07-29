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
    public partial class FormMacro : Form
    {
        int id;
        public FormMacro()
        {
            InitializeComponent();
        }
        FormMacro(int id)
        {
            InitializeComponent();
        }
        public void CarregaDados()
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Macros.Select(s => new
                    {
                        s.ID,
                        s.Nome_Macro,
                        s.Pontos
                    }).ToList();
                    if (query!=null)
                    {
                        foreach (var item in query)
                        {
                            lbMacrosPonto.Items.Add($"{item.ID} - {item.Nome_Macro}");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Não foi possivel carregar os dados", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void FormMacro_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }
        private void btnNovoMacro_Click(object sender, EventArgs e)
        {
            FormNovoMacro form = new FormNovoMacro();
            form.ShowDialog();
            lbMacrosPonto.Items.Clear();
            CarregaDados();
        }
        private void btnEditarM_Click(object sender, EventArgs e)
        {
            try
            {
                using var context = new Context();
                {
                    int id = Convert.ToInt32(lbMacrosPonto.SelectedItem.ToString().Split(" - ")[0]);
                    FormNovoMacro form = new(id);
                    form.ShowDialog();
                    lbMacrosPonto.Items.Clear();
                    CarregaDados();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Selecione o Macro antes de editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnApagarM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a operação?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }
            try
            {
                string macro = lbMacrosPonto.SelectedItem.ToString();
                int id = Convert.ToInt32(lbMacrosPonto.SelectedItem.ToString().Split(" - ")[0]);
                using var context = new Context();
                {                    
                    var query = context.Macros.Where(s => s.ID == id).FirstOrDefault();
                    if (query!= null)
                    {
                        context.Macros.Remove(query);
                        context.SaveChanges();
                        lbMacrosPonto.Items.Clear();
                        CarregaDados();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Não foi possivel encontrar o macro ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
