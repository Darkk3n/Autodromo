using Autodromo.Data.BL;
using Autodromo.Data.VO;
using System;
using System.Data;
using System.Windows.Forms;

namespace Autodromo.UI.Catalogos.Busquedas
{
    public partial class frmBuscarClub : Form
    {
        public frmBuscarClub()
        {
            InitializeComponent();
        }
        DataTable dtClub = new DataTable();
        Club club = new Club();
        private void dgvClubes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                club = new ClubBL().GetClubById(int.Parse(dgvClubes.Rows[e.RowIndex].Cells["ID"].Value.ToString()));
                frmClubes.ClubEncontrado = club;
                club = null;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            club = null;
            Close();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            if (txtValor.Text != "")
            {
                dtClub.DefaultView.RowFilter = "Nombre like '%" + txtValor.Text + "%'";
                dgvClubes.DataSource = dtClub.DefaultView;
            }
            else
            {
                dtClub.DefaultView.RowFilter = "1=1";
            }
        }

        private void frmBuscarClub_Load(object sender, EventArgs e)
        {
            dtClub = new ClubBL().GetClubesDT();
            dgvClubes.DataSource = dtClub;
            dgvClubes.Columns["ID"].Visible = false;
            dgvClubes.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
