using Controllers;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamados_2._0
{
    public partial class frmIncluirChamado : Form
    {
        public frmIncluirChamado()
        {
            InitializeComponent();
            txtData.Text = DateTime.Today.ToString("d");
        }

        private void brnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ChamadoController chamadoController = new ChamadoController();
                Chamado chamado = new Chamado();

                chamado.descricao = txtDescricao.Text;
                chamado.custo = Convert.ToDouble(txtCusto.Text);
                chamado.dataAbertura = Convert.ToDateTime(txtData.Text);


                chamadoController.Incluir(chamado);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
