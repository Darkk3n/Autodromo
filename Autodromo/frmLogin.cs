using System;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;
using Autodromo.UI.Catalogos;

namespace Autodromo.UI
{
   public partial class frmLogin : Form
   {
      public frmLogin()
      {
         InitializeComponent();
      }
      public static Usuario UsuarioLoggeado;
      private void btnSalir_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
      private void CargarUsuarios()
      {
         UsuarioBL usBL = new UsuarioBL();
         cbUsuario.DataSource = usBL.GetUsuariosLista();
         usBL = null;
      }
      private void frmLogin_Load(object sender, EventArgs e)
      {
         CargarUsuarios();
      }
      private void btnEntrar_Click(object sender, EventArgs e)
      {
         Boolean validar = Validar();
         if (validar)
         {
            //Usuario us = (Usuario)cbUsuario.SelectedItem;
            ComboItem us = (ComboItem)cbUsuario.SelectedItem;
            bool r = new UsuarioBL().IniciarSesion(us.Name, txtPass.Text);
            if (r)
            {
               UsuarioLoggeado = new UsuarioBL().GetUsuarioById(us.intValue);
               frmMenu men = new frmMenu();
               men.Show();
               Visible = false;
            }
            else
            {
               MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Contraseña incorrecta.", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtPass.Text = "";
            }
         }
      }
      private bool Validar()
      {
         if (cbUsuario.SelectedIndex == 0)
         {
            errorProv.SetError(cbUsuario, "Seleccione un Usuario");
            return false;
         }
         else
            errorProv.Clear();
         if (txtPass.Text == "")
         {
            errorProv.SetError(txtPass, "Escriba una contraseña");
            return false;
         }
         else
            errorProv.Clear();
         return true;
      }
      private void btnNUsuario_Click(object sender, EventArgs e)
      {
         frmUsuarios nuevoUser = new frmUsuarios();
         nuevoUser.ShowDialog();
      }
      private void btnCambiarP_Click(object sender, EventArgs e)
      {
         if (cbUsuario.SelectedIndex != 0)
         {
            ComboItem cb = (ComboItem)cbUsuario.SelectedItem;
            Usuario usuario = new UsuarioBL().GetUsuarioById(cb.intValue);
            frmCambiarPass cambiar = new frmCambiarPass(usuario);
            cambiar.ShowDialog();
         }
         else
            MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Seleccione un Usuario", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      private void frmLogin_Activated(object sender, EventArgs e)
      {
         CargarUsuarios();
      }

      private void cbUsuario_SelectedIndexChanged(object sender, EventArgs e)
      {
         txtPass.Focus();
      }
   }
}
