using System;
using System.Data;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;

namespace Autodromo.UI.Catalogos.Busquedas
{
   public partial class frmBuscarCategoria : Form
    {
        public frmBuscarCategoria()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        Categoria cat = new Categoria();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmBuscarCategoria_Load(object sender, EventArgs e)
        {
            dt = new CategoriaBL().GetCategoriasDT();
            dgvCategorias.DataSource = dt;
            dgvCategorias.Columns["ID"].Visible = false;
            dgvCategorias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    cat = new CategoriaBL().GetCategoriaById(int.Parse(dgvCategorias.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    frmCategorias.CategoriaEncontrada = cat;
                    cat = null;
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                dt.DefaultView.RowFilter = "Nombre like '%" + txtValor.Text + "%'";
                dgvCategorias.DataSource = dt.DefaultView;
            }
            else
            {
                dt.DefaultView.RowFilter = "1=1";
            }
        }
    }
}
