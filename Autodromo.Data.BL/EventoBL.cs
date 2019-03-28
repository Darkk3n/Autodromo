using Autodromo.Data.DA;
using Autodromo.Data.VO;
using System;
using System.Collections;
using System.Data;

namespace Autodromo.Data.BL
{
    public class EventoBL : BusinessFacadeBase
    {
        public IList GetAllEvento()
        {
            try
            {
                EventoDA eventDA = new EventoDA();
                var res = eventDA.GetAllEvento();
                eventDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllEventoByEstatus(Boolean estado)
        {
            try
            {
                EventoDA eventDA = new EventoDA();
                var res = eventDA.GetAllEventoByEstatus(estado);
                eventDA = null;
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Boolean SaveEvento(Evento evento, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(evento, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(evento);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteEvento(Evento evento)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(evento);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllEventoDT()
        {
            try
            {
                EventoDA eventDA = new EventoDA();
                var res = eventDA.GetAllEventoDT();
                eventDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento GetLastEvento(string ev)
        {
            try
            {
                EventoDA eventDA = new EventoDA();
                var res = eventDA.GetLastEvento(ev);
                eventDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento GetEventoByID(Int32 eventoID)
        {
            try
            {
                EventoDA eventDA = new EventoDA();
                var res = eventDA.GetEventoById(eventoID);
                eventDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
