using System;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;
using Autodromo.UI.Catalogos.Busquedas;

namespace Autodromo.UI.Catalogos
{
   public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        public static Categoria CategoriaEncontrada;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCat.Text != "")
                {
                    if (CategoriaEncontrada != null)
                    {
                        CategoriaEncontrada.Nombre = txtCat.Text;
                        bool r = new CategoriaBL().SaveCategoria(CategoriaEncontrada, frmLogin.UsuarioLoggeado);
                        if (r)
                        {
                            MessageBox.Show("Datos de Categoria actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                    else
                    {
                        Categoria nCat = new Categoria();
                        nCat.Nombre = txtCat.Text;
                        bool r = new CategoriaBL().SaveCategoria(nCat, frmLogin.UsuarioLoggeado);
                        if (r)
                        {
                            MessageBox.Show("Datos de Categoria actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Escriba un nombre de Categoria para poder continuar.", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarCategoria buscarCat = new frmBuscarCategoria();
            buscarCat.ShowDialog();
            if (CategoriaEncontrada != null)
            {
                txtCat.Text = CategoriaEncontrada.Nombre;
            }
        }
    }
}
