using System;
using System.Windows.Forms;
using Autodromo.UI.Catalogos;

namespace Autodromo.UI
{
   public partial class frmMenu : Form
   {
      public frmMenu()
      {
         InitializeComponent();
      }

      private void nuevoEventoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmNuevoEvento evento = new frmNuevoEvento();
         evento.ShowDialog();
      }

      private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }

      private void salirToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmLogin.UsuarioLoggeado = null;
         frmLogin l = new frmLogin();
         l.Show();
         Close();
      }

      private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmCambiarPass cambiarPass = new frmCambiarPass(frmLogin.UsuarioLoggeado);
         cambiarPass.ShowDialog();
      }

      private void agregarOModificarToolStripMenuItem3_Click(object sender, EventArgs e)
      {
         frmCorredores corre = new frmCorredores();
         corre.ShowDialog();
      }

      private void agregarOModificarToolStripMenuItem1_Click(object sender, EventArgs e)
      {
         frmClubes clubes = new frmClubes();
         clubes.ShowDialog();
      }

      private void agregarOModificarToolStripMenuItem4_Click(object sender, EventArgs e)
      {
         frmAutomoviles autos = new frmAutomoviles();
         autos.ShowDialog();
      }

      private void historialDeEventosToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmHistorial historial = new frmHistorial();
         historial.ShowDialog();
      }

      private void agregarOModificarToolStripMenuItem2_Click(object sender, EventArgs e)
      {
         frmCategorias cat = new frmCategorias();
         cat.ShowDialog();
      }

      private void acercaDeAutodromoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         AcercaDe acerca = new AcercaDe();
         acerca.ShowDialog();
      }

      private void cambiarRutaDeGuardadoToolStripMenuItem_Click(object sender, EventArgs e)
      {
         frmCambiarRuta cambiar = new frmCambiarRuta();
         cambiar.ShowDialog();
      }
   }
}