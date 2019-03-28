using System;
using System.Collections;
using Autodromo.Data.VO;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Autodromo.Data.DA
{
    public class CorredorDA : BaseDataAccess
    {
        public IList GetAllCorredor()
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Corredor));
                criteria.AddOrder(Order.Asc("Id"));
                criteria.Add(Restrictions.Eq("Estatus", true));
                items = criteria.List();
                return items;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Corredor GetCorredorById(Int32 corredorID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Corredor));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("ID", corredorID));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Corredor)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Corredor GetCorredorByName(String nomb)
        {            
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Corredor));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("NombreCompleto", nomb));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Corredor)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllCorredorByEstatus(Boolean estado)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Corredor));
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
        public DataTable GetAllCorredorDT()
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
                        cmd.CommandText = "select * from fn_GetCorredores()";
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
    }
}