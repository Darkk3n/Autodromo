using Autodromo.Data.VO;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Autodromo.Data.DA
{
    public class EventoDA : BaseDataAccess
    {
        public IList GetAllEvento()
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Evento));
                criteria.AddOrder(Order.Asc("Id"));
                criteria.Add(Restrictions.Eq("Estatus", true));

                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllEventoByEstatus(Boolean estado)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Evento));
                criteria.AddOrder(Order.Asc("Id"));
                criteria.Add(Restrictions.Eq("Estatus", estado));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento GetEventoById(int eventoID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Evento));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("ID", eventoID));

                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Evento)items[0];
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
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandText = "select id, Nombre, Fecha from evento";
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Evento GetLastEvento(string evento)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria<Evento>();
                criteria.Add(Restrictions.Eq("Nombre", evento));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Evento)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
