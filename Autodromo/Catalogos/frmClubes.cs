using System;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;
using Autodromo.UI.Catalogos.Busquedas;

namespace Autodromo.UI.Catalogos
{
   public partial class frmClubes : Form
    {
        public frmClubes()
        {
            InitializeComponent();
        }
        public static Club ClubEncontrado;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarClub buscaClub = new frmBuscarClub();
            buscaClub.ShowDialog();
            if (ClubEncontrado != null)
            {
                txtClub.Text = ClubEncontrado.Nombre;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtClub.Text!="")
                {
                    if(ClubEncontrado!=null)
                    {
                        ClubEncontrado.Nombre = txtClub.Text;
                        bool r = new ClubBL().SaveClub(ClubEncontrado, frmLogin.UsuarioLoggeado);
                        if(r)
                        {
                            MessageBox.Show("Datos de Club actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClubEncontrado = null;
                            Close();
                        }
                    }
                    else
                    {
                        Club nClub = new Club();
                        nClub.Nombre = txtClub.Text;
                        bool r = new ClubBL().SaveClub(nClub, frmLogin.UsuarioLoggeado);
                        if (r)
                        {
                            MessageBox.Show("Club almacenado correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClubEncontrado = null;
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Escriba el nombre del Club", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
