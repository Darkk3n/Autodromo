using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using Autodromo.Data.BL;
using Autodromo.Data.VO;
using Autodromo.UI.Catalogos.Busquedas;

namespace Autodromo.UI.Catalogos
{
   public partial class frmCorredores : Form
   {
      public static Corredor corre;
      private bool Validar()
      {
         foreach (Control item in Controls)
         {
            if (item is TextBox)
            {
               TextBox txt = (TextBox)item;
               if (txt.Text == "")
               {
                  errorProv.SetError(txt, "Debe llenar todos los campos antes de continuar");
                  return false;
               }
               else
                  errorProv.Clear();
            }
            if (item is ComboBox)
            {
               ComboBox cb = (ComboBox)item;
               if (cb.SelectedIndex == 0)
               {
                  errorProv.SetError(cb, "Seleccione un valor de las listas desplegables");
                  return false;
               }
               else
                  errorProv.Clear();
            }
         }
         return true;
      }
      XDocument doc;
      XElement cadena;

      public frmCorredores()
      {
         InitializeComponent();
         cbClub.DataSource = new ClubBL().GetClubesLista();
      }

      private void btnBuscar_Click(object sender, EventArgs e)
      {
         frmBuscarCorredor buscar = new frmBuscarCorredor();
         buscar.ShowDialog();
         if (pbFoto1.Image != null)
         {
            pbFoto1.Image = null;
         }
         if (corre != null)
         {
            txtNombre.Text = corre.Nombre;
            txtApPaterno.Text = corre.ApellidoPaterno;
            txtApMaterno.Text = corre.ApellidoMaterno;
            Club club = new ClubBL().GetClubById(corre.Club.ID);
            cbClub.SelectedIndex = cbClub.FindStringExact(club.Nombre);
            if (corre.Imagen != null)
            {
               try
               {
                  pbFoto1.Image = Image.FromFile(cadena.Value + corre.Imagen);
               }
               catch (FileNotFoundException ex)
               {
                  MessageBox.Show("Ocurrio un error:" + Environment.NewLine + "No se encontro el archivo deseado: " + ex.FileName, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
         }
      }

      private void btnExaminar1_Click(object sender, EventArgs e)
      {
         DialogResult res = fdFoto.ShowDialog();
         if (res == DialogResult.OK)
         {
            try
            {
               if (fdFoto.FileName.Length > 30)
               {
                  MessageBox.Show("El nombre del archivo de imagen es demasiado largo. Modifiquelo o seleccione otra imagen.", "Administrador de Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
               pbFoto1.Image = Image.FromFile(fdFoto.FileName);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         bool valido = Validar();
         if (valido)
         {
            try
            {
               if (corre != null)
               {
                  ComboItem clubItem = (ComboItem)cbClub.SelectedItem;
                  corre.Nombre = txtNombre.Text;
                  corre.ApellidoPaterno = txtApPaterno.Text;
                  corre.ApellidoMaterno = txtApMaterno.Text;
                  corre.NombreCompleto = txtNombre.Text + " " + txtApPaterno.Text + " " + txtApMaterno.Text;
                  corre.Club = new ClubBL().GetClubById(clubItem.intValue);
                  corre.Imagen = fdFoto.SafeFileName;
                  bool r = new CorredorBL().SaveCorredor(corre, frmLogin.UsuarioLoggeado);
                  if (r)
                  {
                     MessageBox.Show("Datos de Corredor actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Close();
                  }
               }
               else
               {
                  ComboItem clubItem = (ComboItem)cbClub.SelectedItem;
                  Corredor newCorredor = new Corredor();
                  newCorredor.Nombre = txtNombre.Text;
                  newCorredor.ApellidoPaterno = txtApPaterno.Text;
                  newCorredor.ApellidoMaterno = txtApMaterno.Text;
                  newCorredor.NombreCompleto = txtNombre.Text + " " + txtApPaterno.Text + " " + txtApMaterno.Text;
                  newCorredor.Estatus = true;
                  newCorredor.Club = new ClubBL().GetClubById(clubItem.intValue);
                  newCorredor.Imagen = fdFoto.SafeFileName;
                  bool r = new CorredorBL().SaveCorredor(newCorredor, frmLogin.UsuarioLoggeado);
                  if (r)
                  {
                     MessageBox.Show("Corredor almacenado correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Close();
                  }
               }
            }
            catch (Exception ex)
            {
               throw ex;
            }
         }
      }

      private void btnCancelar_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void frmCorredores_Load(object sender, EventArgs e)
      {
         doc = XDocument.Load(Application.StartupPath + @"\Configuracion.xml");
         cadena = doc.Descendants("ruta").First();
      }
   }
}