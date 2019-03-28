using System;
using System.Collections;
using Autodromo.Data.VO;
using NHibernate;
using NHibernate.Criterion;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;

namespace Autodromo.Data.DA
{
    public class ClubDA : BaseDataAccess
    {
        public Club GetClubById(Int32 clubID)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Club));
                criteria.AddOrder(Order.Asc("ID"));
                criteria.Add(Restrictions.Eq("ID", clubID));
                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Club)items[0];
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ComboItem> GetClubesLista()
        {
            List<ComboItem> lista = new List<ComboItem>();
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandText = "select id, nombre from Club";
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
        public DataTable GetClubesDT()
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
                        cmd.CommandText = "select ID, Nombre from Club";
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
