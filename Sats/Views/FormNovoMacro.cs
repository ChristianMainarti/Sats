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
    public partial class FormNovoMacro : Form
    {
        public FormNovoMacro()
        {
            InitializeComponent();
        }
        public FormNovoMacro(int id)
        {
            InitializeComponent();
            BuscaMacro(id);
        }
        private void BuscaMacro(int id)
        {
            try
            {
                using var context = new Context();
                {
                    var query = context.Macros.Where(s => s.ID == id).Select(s => new
                    {
                        s.Nome_Macro
                    }).First();
                    if (query!=null)
                    {
                        txtNomeMacro.Text = query.Nome_Macro; 
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Macro Não encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormNovoMacro_Load(object sender, EventArgs e)
        {

        }
        // botão responsável por salvar o cadastro de um novo macro
        private void btnSalvarNovoMacro_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var query = context.Set<Macro>();
                    query.Add(new Macro
                    {
                        Nome_Macro = txtNomeMacro.Text,
                    });
                    context.SaveChanges();
                }
                MessageBox.Show("Novo Macro cadastrado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Entrada de dados incorreta!","Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
