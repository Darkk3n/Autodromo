using Autodromo.Data.BL;
using Autodromo.Data.VO;
using System;
using System.Windows.Forms;

namespace Autodromo
{
    public partial class frmCambiarPass : Form
    {
        public frmCambiarPass()
        {
            InitializeComponent();
        }
        public frmCambiarPass(Usuario us)
        {
            InitializeComponent();
            newPass = us;
        }
        public static Usuario newPass;
        UsuarioBL guardar = new UsuarioBL();
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNPass.Text != "" && txtNPass2.Text != "")
                {
                    if (txtNPass.Text == txtNPass2.Text)
                    {
                        newPass.Password = txtNPass.Text;
                        bool r = new UsuarioBL().SaveUsuario(newPass, newPass);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Las contraseñas no coinciden", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Llene todos los campos antes de continuar", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
