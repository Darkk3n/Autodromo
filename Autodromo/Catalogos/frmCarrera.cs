using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Autodromo.Data.BL;
using Autodromo.Data.VO;

namespace Autodromo.UI.Catalogos
{
   public partial class frmCarrera : Form
   {
      #region Declarations
      string dato, EventoRecibido, Letra, fCorredor1, fCorredor2, fAuto1, fAuto2;
      string[] ports;
      bool pos1 = false, pos2 = false, llego1 = false, llego2 = false, configurado = false;
      int mili, mili2, corr1, corr2, at1, at2;
      DataTable dtCorredor1, dtCorredor2;
      Evento evento;
      private const int CP_NOCLOSE_BUTTON = 0x200;
      #endregion

      #region Constructors
      public frmCarrera()
      {
         InitializeComponent();
      }
      public frmCarrera(int Corredor1, int Corredor2, int Auto1, int Auto2, string Evento)
      {
         InitializeComponent();
         dtCorredor1 = new CarreraBL().GetCorredorAutoById(Corredor1, Auto1);
         dgvCorredor1.DataSource = dtCorredor1;
         dtCorredor2 = new CarreraBL().GetCorredorAutoById(Corredor2, Auto2);
         dgvCorredor2.DataSource = dtCorredor2;

         fCorredor1 = dtCorredor1.Rows[0]["ImagenCorredor"].ToString();
         fAuto1 = dtCorredor1.Rows[0]["ImagenCorredor"].ToString();
         fCorredor2 = dtCorredor2.Rows[0]["ImagenCorredor"].ToString();
         fAuto2 = dtCorredor2.Rows[0]["ImagenCorredor"].ToString();

         CargarImagenes(fCorredor1, fCorredor2);
         Columnas();
         corr1 = Corredor1;
         at1 = Auto1;
         corr2 = Corredor2;
         at2 = Auto2;
         EventoRecibido = Evento;
      }
      #endregion

      #region  Methods
      private void CargarImagenes(string c1, string c2)
      {
         DataGridViewImageColumn img = new DataGridViewImageColumn();
         Image imagenC1 = Image.FromFile(ConfigurationManager.AppSettings["RutaImagenes"] + c1);
         img.Image = imagenC1;
         img.HeaderText = "Corredor";
         img.Name = "Corredor";
         img.Width = 300;
         img.ImageLayout = DataGridViewImageCellLayout.Zoom;
         dgvCorredor1.Columns.Add(img);
         dgvCorredor1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

         DataGridViewImageColumn img2 = new DataGridViewImageColumn();
         Image imagenC2 = Image.FromFile(ConfigurationManager.AppSettings["RutaImagenes"] + c2);
         img2.Image = imagenC2;
         img2.HeaderText = "Corredor2";
         img2.Name = "Corredor2";
         img2.Width = 300;
         img2.ImageLayout = DataGridViewImageCellLayout.Zoom;
         dgvCorredor2.Columns.Add(img2);
         dgvCorredor2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

      }
      private void Columnas()
      {
         dgvCorredor1.Columns["CorredorID"].Visible = false;
         dgvCorredor1.Columns["AutomovilID"].Visible = false;
         dgvCorredor1.Columns["ImagenAuto"].Visible = false;
         dgvCorredor1.Columns["ImagenCorredor"].Visible = false;
         dgvCorredor2.Columns["CorredorID"].Visible = false;
         dgvCorredor2.Columns["AutomovilID"].Visible = false;
         dgvCorredor2.Columns["ImagenAuto"].Visible = false;
         dgvCorredor2.Columns["ImagenCorredor"].Visible = false;
         for (int i = 0; i < dgvCorredor1.Columns.Count - 2; i++)
         {

            dgvCorredor1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCorredor2.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvCorredor1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvCorredor2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter;
         }
      }
      private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
      {
         try
         {
            dato = SerialPort1.ReadExisting().Trim();
            if (dato.Contains("ll1"))
            {
               Milisegundos1.Stop();
               llego1 = true;
            }
            else if (dato.Contains("ll2"))
            {
               Milisegundos2.Stop();
               llego2 = true;
            }
            else if (dato.Contains("11"))
            {
               pbRojo1.Visible = false;
               pos1 = true;
               pbRojo2.Visible = false;
               pos2 = true;
            }

            else if (dato.Contains("10"))
            {
               pbRojo1.Visible = false;
               pos1 = true;
               pbRojo2.Visible = true;
               pos2 = false;
            }
            else if (dato.Contains("01"))
            {
               pbRojo1.Visible = true;
               pos1 = false;
               pbRojo2.Visible = false;
               pos2 = true;
            }
            else if (dato.Contains("00"))
            {
               pbRojo1.Visible = true;
               pos1 = false;
               pbRojo2.Visible = true;
               pos2 = false;
            }
            else if (dato.Contains("A"))
            {
               Letra = dato;
            }
            else if (dato.Contains("B"))
            {
               Letra = dato;
            }
            else if (dato.Contains("C"))
            {
               Letra = dato;
            }
            else if (dato.Contains("D"))
            {
               Letra = dato;
            }
            dato = "";
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }
      }
      private void CualAdelanto(string Letra)
      {
         switch (Letra)
         {
            case "A":
               {
                  pbAdelanto1.Visible = true;
                  break;
               }
            case "B":
               {
                  pbAdelanto2.Visible = true;
                  break;
               }
            case "C":
               {
                  pbAdelanto1.Visible = true;
                  pbAdelanto2.Visible = true;
                  break;
               }
            case "D":
               {
                  pbAdelanto1.Visible = false;
                  pbAdelanto2.Visible = false;
                  break;
               }
         }
      }
      private void Milisegundos1_Tick(object sender, EventArgs e)
      {
         mili += 16;
         lblTiempo1.Text = mili.ToString();
      }
      private void frmCarrera_Load(object sender, EventArgs e)
      {
         evento = new EventoBL().GetLastEvento(EventoRecibido);
         CheckForIllegalCrossThreadCalls = false;
      }
      private void btnPosicion_Click(object sender, EventArgs e)
      {
         try
         {
            GetSerialPortNames();
            if (!configurado)
            {
               SetupPuertoSerie(ports[1]);
               configurado = true;
               SerialPort1.Write("2");
            }
            else
               SerialPort1.Write("2");
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      private void Milisegundos2_Tick(object sender, EventArgs e)
      {
         mili2 += 16;
         lblTiempo2.Text = mili2.ToString();
      }
      private void btnFinalizar_Click(object sender, EventArgs e)
      {
         try
         {
            if (llego1)
            {
               GuardarDatos();
               SerialPort1.Write("3");
               Close();
            }
            else
            {
               MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Ambos autos deben estar en la meta para realizar la captura de datos.", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      private void GetSerialPortNames()
      {
         try
         {
            ports = SerialPort.GetPortNames();
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      private void SetupPuertoSerie(string nombre)
      {

         try
         {
            if (SerialPort1.IsOpen)
            {
               SerialPort1.Close();
            }

            SerialPort1.PortName = nombre;
            SerialPort1.BaudRate = 9600;
            //// 19200 baud rate 
            SerialPort1.DataBits = 8;
            //// 8 data bits                                                   
            SerialPort1.StopBits = StopBits.One;
            //// 1 Stop bit 
            SerialPort1.Parity = Parity.None;
            //
            SerialPort1.DtrEnable = false;
            SerialPort1.Handshake = Handshake.None;
            SerialPort1.ReadBufferSize = 2048;
            SerialPort1.WriteBufferSize = 2048;
            //.ReceivedBytesThreshold = 1

            SerialPort1.WriteTimeout = 1000;
            SerialPort1.Encoding = Encoding.Default;
            SerialPort1.Open();
            //  ABRE EL PUERTO SERIE
         }
         catch (Exception ex)
         {
            MessageBox.Show("Error al abrir el puerto serial: " + ex.Message);
         }
      }
      private void btnIniciar_Click(object sender, EventArgs e)
      {
         if (pos1 & pos2)
         {
            try
            {
               SerialPort1.Write("1");
               Thread.Sleep(3770);
               CualAdelanto(Letra);
               Milisegundos1.Start();
               Milisegundos2.Start();
               btnIniciar.Enabled = false;
               btnPosicion.Enabled = false;
               btnFinalizar.Enabled = true;
            }
            catch (Exception ex)
            {
               throw ex;
            }
         }
         else
         {
            MessageBox.Show("Ocurrio un error: " + Environment.NewLine + "Hay un coche en posición incorrecta", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
         }
      }
      private void GuardarDatos()
      {
         try
         {
            Carrera Race = new Carrera();
            Race.Corredor = new CorredorBL().GetCorredorById(corr1);
            Race.Automovil = new AutomovilBL().GetAutomovilById(at1);
            Race.Estatus = true;
            Race.Evento = evento;
            Race.Tiempo = TimeSpan.FromMilliseconds(double.Parse(lblTiempo1.Text));
            bool r1 = new CarreraBL().SaveCarrera(Race, frmLogin.UsuarioLoggeado);
            Carrera Race2 = new Carrera();
            Race2.Corredor = new CorredorBL().GetCorredorById(corr2);
            Race2.Automovil = new AutomovilBL().GetAutomovilById(at2);
            Race2.Estatus = true;
            Race2.Evento = evento;
            Race2.Tiempo = TimeSpan.FromMilliseconds(double.Parse(lblTiempo2.Text));
            bool r2 = new CarreraBL().SaveCarrera(Race2, frmLogin.UsuarioLoggeado);
            if (r1 & r2)
            {
               MessageBox.Show("Carrera almacenada correctamente", "Autodromo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }
         catch (Exception ex)
         {
            throw ex;
         }
      }
      #endregion
   }
}