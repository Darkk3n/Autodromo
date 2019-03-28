using Autodromo.Data.BL;
using Autodromo.Data.VO;
using System;
using System.Windows.Forms;

namespace Autodromo.UI.Catalogos
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private Boolean Validar()
        {
            if (txtPass.Text == "" | txtUsuario.Text == "")
            {
                errorProv.SetError(txtPass, "Debe llenar todo los campos para continuar");
                return false;
            }
            else
                errorProv.Clear();
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Boolean valido = Validar();
            if (valido)
            {
                Usuario newUser = new Usuario();
                newUser.UserName = txtUsuario.Text;
                newUser.Password = txtPass.Text;
                Boolean r = new UsuarioBL().SaveUsuario(newUser, newUser);
                if (r)
                {
                    MessageBox.Show("Usuario guardado correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    Close();
                }
            }
        }
        private void Limpiar()
        {
            txtPass.Text = "";
            txtUsuario.Text = "";
        }
    }
}
