using System;
using System.Data;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;

namespace Autodromo.UI.Catalogos.Busquedas
{
   public partial class frmBuscarCorredor : Form
    {
        public frmBuscarCorredor()
        {
            InitializeComponent();
        }
        int CualCorredor;
        public frmBuscarCorredor(int Corredor)
        {
            InitializeComponent();
            CualCorredor = Corredor;
        }
        Corredor corre = new Corredor();
        DataTable dtCorredor = new DataTable();
        private void frmBuscarCorredor_Load(object sender, EventArgs e)
        {
            dtCorredor = new CorredorBL().GetAllCorredorDT();
            dgvCorredor.DataSource = dtCorredor;
            cbFiltro.SelectedIndex = 0;
            Columnas();
        }
        private void Columnas()
        {
            dgvCorredor.Columns["id"].Visible = false;
            dgvCorredor.Columns["Imagen"].Visible = false;
            dgvCorredor.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCorredor.Columns["Apellido Paterno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCorredor.Columns["Apellido Materno"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dgvCorredor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    corre = new CorredorBL().GetCorredorById(int.Parse(dgvCorredor.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    frmCorredores.corre = corre;
                    if (CualCorredor == 1)
                        frmNuevoEvento.Corredor1 = corre;
                    else
                        frmNuevoEvento.Corredor2 = corre;
                    corre = null;
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFiltro.SelectedIndex != 0)
            {
                dtCorredor.DefaultView.RowFilter = "1=1";
                txtValor.Text = "";
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.SelectedIndex != 0 && txtValor.Text != "")
                {
                    dtCorredor.DefaultView.RowFilter = (cbFiltro.SelectedItem.ToString() + " like '%" + txtValor.Text + "%'");
                    dgvCorredor.DataSource = dtCorredor.DefaultView;
                }
                else

                    dtCorredor.DefaultView.RowFilter = "1=1";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
