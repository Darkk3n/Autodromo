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
   public partial class frmNuevoEvento : Form
   {
      #region Declarations
      public static Corredor Corredor1, Corredor2;
      public static Automovil Auto1, Auto2;
      public static Evento buscarEvento;
      XDocument doc;
      XElement cadena;
      Usuario user = new Usuario();
      #endregion

      #region Constructor
      public frmNuevoEvento()
      {
         InitializeComponent();
      }
      #endregion

      #region Methods
      private void CargarImagen(PictureBox pb)
      {
         DialogResult res = ofdFoto.ShowDialog();
         if (res == DialogResult.OK)
         {
            try
            {
               if (ofdFoto.FileName.Length > 30)
               {
                  MessageBox.Show("El nombre del archivo de imagen es demasiado largo. Modifiquelo o seleccione otra imagen.", "Administrador de Transportes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
               pb.Image = Image.FromFile(ofdFoto.FileName);
               ofdFoto.FileName = "";
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
      }

      private void CargarCorredor(int corredor)
      {
         frmBuscarCorredor buscar = new frmBuscarCorredor(corredor);
         buscar.ShowDialog();


         if (corredor == 1)
         {
            if (pbFoto1.Image != null)
            {
               pbFoto1.Image = null;
            }
            if (Corredor1 != null)
            {
               txtNombre1.Text = Corredor1.Nombre;
               txtApPaterno1.Text = Corredor1.ApellidoPaterno;
               txtApMaterno1.Text = Corredor1.ApellidoMaterno;
               txtClub1.Text = Corredor1.Club.Nombre;
               try
               {
                  pbFoto1.Image = Image.FromFile(cadena.Value + @"\" + Corredor1.Imagen);
               }
               catch (FileNotFoundException ex)
               {
                  MessageBox.Show("Ocurrio un error:" + Environment.NewLine + "No se encontro el archivo deseado: " + ex.FileName, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
         }
         else
         {
            if (pbFoto2.Image != null)
            {
               pbFoto2.Image = null;
            }
            if (Corredor2 != null)
            {
               txtNombre2.Text = Corredor2.Nombre;
               txtApPaterno2.Text = Corredor2.ApellidoPaterno;
               txtApMaterno2.Text = Corredor2.ApellidoMaterno;
               txtClub2.Text = Corredor2.Club.Nombre;
               try
               {
                  pbFoto2.Image = Image.FromFile(cadena.Value + @"\" + Corredor2.Imagen);
               }
               catch (FileNotFoundException ex)
               {

                  MessageBox.Show("Ocurrio un error:" + Environment.NewLine + "No se encontro el archivo deseado: " + ex.FileName, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
         }
      }

      private void CargarAutomovil(int auto)
      {
         frmBuscarAutomovil buscarCarro = new frmBuscarAutomovil(auto);
         buscarCarro.ShowDialog();
         if (auto == 1)
         {
            if (pbAuto1.Image != null)
            {
               pbAuto1.Image = null;
            }

            if (Auto1 != null)
            {
               txtNum1.Text = Auto1.Numero.ToString();
               txtMarca1.Text = Auto1.Marca;
               txtModelo1.Text = Auto1.Modelo.ToString();
               txtCilindrada1.Text = Auto1.Cilindrada;
               txtCat1.Text = Auto1.Categoria.Nombre;
               txtMotor1.Text = Auto1.TipoMotor;
               txtAutoClub1.Text = Auto1.Club.Nombre;
               pbAuto1.Image = Image.FromFile(cadena.Value + @"\" + Auto1.Imagen);
            }
         }
         else
         {
            if (pbAuto2.Image != null)
            {
               pbAuto2.Image = null;
            }
            if (Auto2 != null)
            {
               txtMarca2.Text = Auto2.Marca;
               txtNum2.Text = Auto2.Numero.ToString();
               txtModelo2.Text = Auto2.Modelo.ToString();
               txtCilindrada2.Text = Auto2.Cilindrada;
               txtCat2.Text = Auto2.Categoria.Nombre;
               txtMotor2.Text = Auto2.TipoMotor;
               txtAutoClub2.Text = Auto2.Club.Nombre;
               pbAuto2.Image = Image.FromFile(cadena.Value + @"\" + Auto2.Imagen);

            }
         }
      }

      private void btnBuscarCorredor1_Click(object sender, EventArgs e)
      {
         CargarCorredor(1);
      }

      private void btnBuscarCorredor2_Click(object sender, EventArgs e)
      {
         CargarCorredor(2);
      }

      private void btnBuscarAuto1_Click(object sender, EventArgs e)
      {
         CargarAutomovil(1);
      }

      private void btnBuscarAutomovil2_Click(object sender, EventArgs e)
      {
         CargarAutomovil(2);
      }

      private void btnBuscarEvento_Click(object sender, EventArgs e)
      {
         frmBuscarEvento buscaEvent = new frmBuscarEvento();
         buscaEvent.ShowDialog();
         if (buscarEvento != null)
         {
            txtEvento.Text = buscarEvento.Nombre;
            dtpFecha.Value = buscarEvento.Fecha;
         }
      }

      private bool Validar()
      {

         if (txtEvento.Text == "")
         {
            errorProv.SetError(txtEvento, "Escriba el nombre del Evento.");
            return false;
         }
         else
            errorProv.Clear();
         #region Corredores

         foreach (Control item in gbCorredor1.Controls)
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
         }
         foreach (Control item in gbCorredor2.Controls)
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
         }
         #endregion
         #region Autos
         foreach (Control item in gbAuto1.Controls)
         {
            if (item is ComboBox)
            {
               ComboBox cb = (ComboBox)item;
               if (cb.SelectedIndex == 0)
               {
                  errorProv.SetError(cb, "Seleccione un valor de la lista desplegable");
                  return false;
               }
               else
                  errorProv.Clear();
            }
            if (item is MaskedTextBox)
            {
               MaskedTextBox msk = (MaskedTextBox)item;
               if (msk.Text == "")
               {
                  errorProv.SetError(msk, "Debe llenar todos los datos antes de continuar");
                  return false;
               }
               else
                  errorProv.Clear();
            }
         }
         foreach (Control item in gbAuto2.Controls)
         {
            if (item is MaskedTextBox)
            {
               MaskedTextBox msk = (MaskedTextBox)item;
               if (msk.Text == "")
               {
                  errorProv.SetError(msk, "Debe llenar todos los datos antes de continuar");
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
                  errorProv.SetError(cb, "Seleccione un valor de la lista desplegable");
                  return false;
               }
               else
                  errorProv.Clear();
            }
         }
         #endregion


         return true;
      }

      private void frmNuevoEvento_Load(object sender, EventArgs e)
      {
         doc = XDocument.Load(Application.StartupPath + @"\Configuracion.xml");
         cadena = doc.Descendants("ruta").First();
      }

      private void btnIniciar_Click(object sender, EventArgs e)
      {
         bool r = Validar();
         if (r)
         {
            bool res;
            if (buscarEvento != null)
            {
               buscarEvento.Nombre = txtEvento.Text;
               buscarEvento.Fecha = dtpFecha.Value;
               res = new EventoBL().SaveEvento(buscarEvento, frmLogin.UsuarioLoggeado);
               if (res)
               {
                  MessageBox.Show("Datos de Evento actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  frmCarrera carrera = new frmCarrera(Corredor1.ID, Corredor2.ID, Auto1.ID, Auto2.ID, txtEvento.Text);
                  Limpiar();
                  carrera.ShowDialog();
               }

            }
            else
            {
               Evento ev = new Evento();
               ev.Nombre = txtEvento.Text;
               ev.Fecha = dtpFecha.Value;
               res = new EventoBL().SaveEvento(ev, frmLogin.UsuarioLoggeado);
            }
            if (res)
            {
               MessageBox.Show("Evento almacenado correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               frmCarrera carrera = new frmCarrera(Corredor1.ID, Corredor2.ID, Auto1.ID, Auto2.ID, txtEvento.Text);
               Limpiar();
               carrera.ShowDialog();
            }
         }
      }

      private void Limpiar()
      {
         foreach (Control item in Controls)
         {
            if (item is TextBox)
            {
               TextBox txt = (TextBox)item;
               if (txt.Enabled == false)
               {
                  txt.Enabled = true;
                  txt.Text = "";
                  txt.Enabled = false;
               }
               txt.Text = "";
            }
         }
      }
      #endregion
   }
}