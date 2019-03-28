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
   public partial class frmAutomoviles : Form
   {
      XDocument doc;
      XElement cadena;
      public static Automovil AutoEncontrado;
      public frmAutomoviles()
      {
         InitializeComponent();

      }
      private void btnBuscarImgAuto1_Click(object sender, EventArgs e)
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
               pbAuto1.Image = Image.FromFile(fdFoto.FileName);
            }
            catch (Exception ex)
            {
               MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
      }
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
            }
            if (item is ComboBox)
            {
               ComboBox cb = (ComboBox)item;
               if (cb.SelectedIndex == 0)
               {
                  errorProv.SetError(cb, "Seleccione un valor de la lista desplegable");
                  return false;
               }
            }
         }
         return true;
      }
      private void btnBuscarAuto1_Click(object sender, EventArgs e)
      {
         frmBuscarAutomovil buscaAuto = new frmBuscarAutomovil();
         buscaAuto.ShowDialog();
         if (pbAuto1.Image != null)
         {
            pbAuto1.Image = null;
         }
         if (AutoEncontrado != null)
         {
            txtNum.Text = AutoEncontrado.Numero.ToString();
            txtMarca.Text = AutoEncontrado.Marca;
            txtModelo.Text = AutoEncontrado.Modelo.ToString();
            txtCilindrada.Text = AutoEncontrado.Cilindrada;
            cbCategoria.SelectedIndex = cbCategoria.FindStringExact(AutoEncontrado.Categoria.Nombre);
            cbClubes.SelectedIndex = cbClubes.FindStringExact(AutoEncontrado.Club.Nombre);
            cbMotor.SelectedIndex = cbMotor.FindStringExact(AutoEncontrado.TipoMotor);
            if (AutoEncontrado.Imagen != null)
            {
               try
               {
                  pbAuto1.Image = Image.FromFile(cadena.Value + @"\" + AutoEncontrado.Imagen);
               }
               catch (FileNotFoundException ex)
               {

                  MessageBox.Show("Ocurrio un error:" + Environment.NewLine + "No se encontro el archivo deseado: " + ex.FileName, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return;
               }
            }
         }
      }
      private void btnAceptar_Click(object sender, EventArgs e)
      {
         bool valido = Validar();
         {
            if (valido)
            {
               if (AutoEncontrado != null)
               {
                  ComboItem club = (ComboItem)cbClubes.SelectedItem;
                  ComboItem cat = (ComboItem)cbCategoria.SelectedItem;
                  AutoEncontrado.Numero = int.Parse(txtNum.Text);
                  AutoEncontrado.Marca = txtMarca.Text;
                  AutoEncontrado.Modelo = int.Parse(txtModelo.Text);
                  AutoEncontrado.Imagen = fdFoto.SafeFileName;
                  AutoEncontrado.Cilindrada = txtCilindrada.Text;
                  AutoEncontrado.TipoMotor = cbMotor.SelectedItem.ToString();
                  AutoEncontrado.Categoria = new CategoriaBL().GetCategoriaById(cat.intValue);
                  AutoEncontrado.Club = new ClubBL().GetClubById(club.intValue);
                  bool r = new AutomovilBL().SaveAutomovil(AutoEncontrado, frmLogin.UsuarioLoggeado);
                  if (r)
                  {
                     MessageBox.Show("Datos de Automovil actualizados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Limpiar();
                     Close();
                  }

               }
               else
               {
                  Automovil nAuto = new Automovil();
                  ComboItem club = (ComboItem)cbClubes.SelectedItem;
                  ComboItem cat = (ComboItem)cbCategoria.SelectedItem;
                  nAuto.Numero = int.Parse(txtNum.Text);
                  nAuto.Marca = txtMarca.Text;
                  nAuto.Modelo = int.Parse(txtModelo.Text);
                  nAuto.Imagen = fdFoto.SafeFileName;
                  nAuto.Cilindrada = txtCilindrada.Text;
                  nAuto.TipoMotor = cbMotor.SelectedItem.ToString();
                  nAuto.Categoria = new CategoriaBL().GetCategoriaById(cat.intValue);
                  nAuto.Club = new ClubBL().GetClubById(club.intValue);
                  bool r = new AutomovilBL().SaveAutomovil(nAuto, frmLogin.UsuarioLoggeado);
                  if (r)
                  {
                     MessageBox.Show("Datos de Automovil almacenados correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     Limpiar();
                     Close();
                  }
               }
            }
         }
      }
      private void frmAutomoviles_Load(object sender, EventArgs e)
      {
         cbClubes.DataSource = new ClubBL().GetClubesLista();
         cbCategoria.DataSource = new CategoriaBL().GetCategorias();
         cbMotor.SelectedIndex = 0;
         doc = XDocument.Load(Application.StartupPath + @"\Configuracion.xml");
         cadena = doc.Descendants("ruta").First();
      }
      private void btnCancelar_Click(object sender, EventArgs e)
      {
         Close();
      }
      private void Limpiar()
      {
         foreach (Control item in Controls)
         {
            if (item is TextBox)
            {
               TextBox txt = (TextBox)item;
               txt.Text = "";
            }
            if (item is ComboBox)
            {
               ComboBox cb = (ComboBox)item;
               cb.SelectedIndex = 0;
            }
         }

      }
   }
}