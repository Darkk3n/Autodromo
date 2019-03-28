using Autodromo.Data.VO;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Autodromo.Data.DA
{
    public class CategoriaDA : BaseDataAccess
    {
        public List<ComboItem> GetCategorias()
        {
            DataTable dt = new DataTable();
            List<ComboItem> lista = new List<ComboItem>();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {

                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandText = "select ID, Nombre from Categoria";
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                lista.Add(new ComboItem("--SELECCIONE--", 0));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(new ComboItem(dt.Rows[i]["Nombre"].ToString(), int.Parse(dt.Rows[i]["ID"].ToString())));
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Categoria GetCategoriaById(int catID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Categoria));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("ID", catID));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Categoria)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCategoriasDT()
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
                        cmd.CommandText = "select ID, Nombre from Categoria";
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
            }
            return dt;
        }
    }
}
