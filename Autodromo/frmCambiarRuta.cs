using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Autodromo
{
   public partial class frmCambiarRuta : Form
   {
      XDocument doc;

      public frmCambiarRuta()
      {
         InitializeComponent();
      }

      private void btnDialog_Click(object sender, EventArgs e)
      {
         DialogResult res = folder.ShowDialog();
         if (res == DialogResult.OK)
         {
            try
            {
               XElement ruta = doc.Descendants("ruta").First();
               ruta.Value = folder.SelectedPath;
               txtRuta.Text = ruta.Value;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Ocurrio un error: " + Environment.NewLine + ex.Message, "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return;
            }
         }
      }

      private void frmCambiarRuta_Load(object sender, EventArgs e)
      {
         doc = XDocument.Load(Application.StartupPath + @"\Configuracion.xml");
         XElement cadena = doc.Descendants("ruta").First();
         string ruta = (string)cadena;
         txtRuta.Text = ruta;
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         DialogResult res = (MessageBox.Show("¿Esta seguro que desea cambiar la ruta de guardado?", "Autodromo", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
         if (res == DialogResult.Yes)
         {
            doc.Save(Application.StartupPath + @"\Configuracion.xml");
            Close();
         }
      }
   }
}