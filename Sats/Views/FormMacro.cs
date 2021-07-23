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
        public FormMacro()
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
                        s.Nome_Macro
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
            catch (Exception)
            {

                throw;
            }
        }
        private void FormMacro_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNovoMacro form = new FormNovoMacro();
            form.Show();
        }
    }
}
