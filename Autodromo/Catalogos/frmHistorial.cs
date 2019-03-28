using System;
using System.Data;
using System.Windows.Forms;
using Autodromo.Data.BL;

namespace Autodromo.UI.Catalogos
{
   public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void frmHistorial_Load(object sender, EventArgs e)
        {
            dt = new CarreraBL().GetCarrerasPorEvento();
            dgvHistorial.DataSource = dt;
            Columnas();
        }
        private void Columnas()
        {
            for (int i = 0; i < dgvHistorial.Columns.Count; i++)
            {
                dgvHistorial.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvHistorial.Columns["Año"].Visible = false;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                dt.DefaultView.RowFilter = "Año = '" + txtValor.Text + "'";
                dgvHistorial.DataSource = dt.DefaultView;
            }
            else
            {
                dt.DefaultView.RowFilter = "1=1";
            }
        }
    }
}
