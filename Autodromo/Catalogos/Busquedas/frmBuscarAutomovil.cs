using System;
using System.Data;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;
namespace Autodromo.UI.Catalogos.Busquedas
{
    public partial class frmBuscarAutomovil : Form
    {
        int CualAuto;
        public frmBuscarAutomovil()
        {
            InitializeComponent();
        }
        public frmBuscarAutomovil(int Auto)
        {
            InitializeComponent();
            CualAuto = Auto;
        }
        Automovil auto = new Automovil();
        DataTable dtAuto = new DataTable();
        private void frmBuscarAutomovil_Load(object sender, EventArgs e)
        {
            dtAuto = new AutomovilBL().GetAllAutomovilDT();
            dgvAutomovil.DataSource = dtAuto;
            cbFiltro.SelectedIndex = 0;
            Columnas();
        }
        private void Columnas()
        {
            dgvAutomovil.Columns["ID"].Visible = false;
            dgvAutomovil.Columns["Imagen"].Visible = false;
            dgvAutomovil.Columns["Numero"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Marca"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Modelo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Cilindrada"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Categoria"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Tipo de Motor"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAutomovil.Columns["Club"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void dgvAutomovil_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    auto = new AutomovilBL().GetAutomovilById(int.Parse(dgvAutomovil.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    frmAutomoviles.AutoEncontrado = auto;
                    if (CualAuto == 1)
                        frmNuevoEvento.Auto1 = auto;
                    else
                        frmNuevoEvento.Auto2 = auto;
                    auto = null;
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
                dtAuto.DefaultView.RowFilter = "1=1";
                txtValor.Text = "";
            }
        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbFiltro.SelectedIndex != 0 && txtValor.Text != "")
                {
                    dtAuto.DefaultView.RowFilter = (cbFiltro.SelectedItem.ToString() + " like '%" + txtValor.Text + "%'");
                    dgvAutomovil.DataSource = dtAuto.DefaultView;
                }
                else

                    dtAuto.DefaultView.RowFilter = "1=1";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
