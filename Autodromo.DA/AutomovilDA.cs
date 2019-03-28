using System;
using System.Collections;
using System.Collections.Generic;
using Autodromo.Data.VO;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace Autodromo.Data.DA
{
    public class AutomovilDA : BaseDataAccess
    {
        public IList GetAllAutomovil()
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Automovil));
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
        public Automovil GetAutomovilById(Int32 autoID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Automovil));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("ID", autoID));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Automovil)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllAutomovilByEstatus(Boolean estado)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Automovil));
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
        public DataTable GetAllAutomovilDT()
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
                        cmd.CommandText = "Select * from fn_GetAutomoviles()";
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
        public List<ComboItem> GetCategorias()
        {
            DataTable dt = new DataTable();
            List<ComboItem> lista = new List<ComboItem>();
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.Connection.Open();
                    cmd.CommandText = "select Categoria from Automovil group by Categoria";
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                if (dt.Rows.Count >= 1)
                {
                    lista.Add(new ComboItem("--SELECCIONE--", "--SELECCIONE--"));
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        lista.Add(new ComboItem(dt.Rows[i]["Categoria"].ToString(), dt.Rows[i]["Categoria"].ToString()));
                    }
                }
            }
            return lista;
        }
    }
}