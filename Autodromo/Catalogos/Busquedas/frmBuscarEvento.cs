using System;
using System.Data;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;

namespace Autodromo.UI.Catalogos.Busquedas
{
   public partial class frmBuscarEvento : Form
    {
        public frmBuscarEvento()
        {
            InitializeComponent();
        }
        DataTable dtEvento = null;
        Evento evento = new Evento();
        private void frmBuscarEvento_Load(object sender, EventArgs e)
        {
            dtEvento = new EventoBL().GetAllEventoDT();
            dgvEvento.DataSource = dtEvento;
            Columnas();
        }
        private void Columnas()
        {
            dgvEvento.Columns["ID"].Visible = false;
            dgvEvento.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvEvento.Columns["Fecha"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtValor.Text != "")
                {
                    dtEvento.DefaultView.RowFilter = "Nombre like '%" + txtValor.Text + "%'";
                    dgvEvento.DataSource = dtEvento.DefaultView;
                }
                else
                    dtEvento.DefaultView.RowFilter = "1=1";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgvEvento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    evento = new EventoBL().GetEventoByID(int.Parse(dgvEvento.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                    frmNuevoEvento.buscarEvento = evento;
                    evento = null;
                    Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
