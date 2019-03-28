using NHibernate;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodromo.Data.DA
{
    public class UtilidadesDA : BaseDataAccess
    {
        public byte[] ConvertImagenToByteArray(String ruta)
        {

            // El objeto FileStream permite leer el archivo desde el disco.
            FileStream fs = new FileStream(ruta, System.IO.FileMode.Open, System.IO.FileAccess.Read);

            // Almacena el archivo leido en un arrego de bytes.
            byte[] archivoLeido = new byte[fs.Length];

            fs.Read(archivoLeido, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();

            return archivoLeido;

        }

        public Boolean SaveByteArrayToFile(String FileName, Byte[] Data, out String rutaFisica, String complementoRutaFisica)
        {
            BinaryWriter Writer = null;

            if (!Directory.Exists(ConfigurationManager.AppSettings["Anexo_EWMS_CESIGSA"].ToString() + complementoRutaFisica))
                Directory.CreateDirectory(ConfigurationManager.AppSettings["Anexo_EWMS_CESIGSA"].ToString() + complementoRutaFisica);
            string uploadDir = ConfigurationManager.AppSettings["Anexo_EWMS_CESIGSA"].ToString() + complementoRutaFisica;

            try
            {
                // Create a new stream to write to the file
                rutaFisica = uploadDir + FileName;
                Writer = new BinaryWriter(File.OpenWrite(rutaFisica));

                // Writer raw data                
                Writer.Write(Data);
                Writer.Flush();
                Writer.Close();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DateTime GetSystemDatetime()
        {
            try
            {
                //Consulta la fecha del servidor de base de datos
                string query = String.Empty;
                query = "SELECT GETDATE()";

                IQuery _sqlQuery = m_session.CreateSQLQuery(query);

                return (DateTime)_sqlQuery.UniqueResult();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}