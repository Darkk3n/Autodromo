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
    public class CarreraDA : BaseDataAccess
    {
        public IList GetAllCarrera()
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Carrera));
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
        public Carrera GetCarreraById(Int32 carreraID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Carrera));
                //ICriteria criteria = m_session.CreateCriteria(typeof(Carrera));

                criteria.AddOrder(Order.Asc("Id"));
                criteria.Add(Restrictions.Eq("Id", carreraID));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Carrera)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllCarreraByEstatus(Boolean estado)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Carrera));
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
        public DataTable GetCorredorAutoByID(Int32 CorredorID, Int32 AutoID)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "sp_GetCorredorAutoByID";
                        cmd.Parameters.AddWithValue("@CorredorID", CorredorID);
                        cmd.Parameters.AddWithValue("@AutoID", AutoID);
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
        public DataTable GetCarrerasPorEvento()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandText = "select * from fn_GetCarrerasPorEvento() order by Tiempo";
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                return dt;
            }
        }
    }
}
