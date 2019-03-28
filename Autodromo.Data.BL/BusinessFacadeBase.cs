using System;
using Autodromo.Data.VO;
using Autodromo.Data.DA;

namespace Autodromo.Data.BL
{
    public class BusinessFacadeBase
    {
        private int m_currentUserId;

        public BusinessFacadeBase()
        {
        }

        public void Regionalizacion()
        {
            var thisThread = System.Threading.Thread.CurrentThread;
            System.Globalization.CultureInfo originalCulture = null;
            originalCulture = thisThread.CurrentCulture;
            thisThread.CurrentCulture = new System.Globalization.CultureInfo("es-MX");
        }

        protected void VerifyIsLoggedIn()
        {
        }

        /// <summary>
        /// Actualiza los campos de auditoría antes de guardar el Objeto que hereda de BaseBusinessObject
        /// </summary>
        /// <param name="item">Objeto a guardar</param>
        /// <param name="usuarioSistema">Objeto Usuario para guardarlo en el campo de auditoria</param>
        protected virtual void CheckObjectBeforeSave(BaseBusinessObject item, Usuario usuarioSistema)
        {
            if (item != null)
            {
                //Se obtiene la fecha del servidor de base de datos
                DateTime dtSystem = new UtilidadesDA().GetSystemDatetime();

                if (item.Version == 0)
                {
                    //item.CreatedDT = DateTime.Now;
                    item.CreatedDT = dtSystem;
                    item.CreatedBy = usuarioSistema.UserName;
                }

                item.UpdatedDT = dtSystem;
                //item.UpdatedDT = DateTime.Now;

                item.UpdatedBy = usuarioSistema.UserName;


            }
        }


        public int CurrentUserId
        {
            get { return m_currentUserId; }
            set { m_currentUserId = value; }
        }
    }
}
