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
    public class UsuarioDA : BaseDataAccess
    {
        public IList GetAllUsuario()
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Usuario));
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
        public IList GetAllUsuarioByEstatus(Boolean estado)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Usuario));
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
        public Usuario GetUsuarioById(Int32 userId)
        {
            IList items = null;
            try
            {
                ICriteria criteria = m_session.CreateCriteria(typeof(Usuario));
                criteria.AddOrder(Order.Asc("Id"));
                criteria.Add(Restrictions.Eq("Id", userId));

                items = criteria.List();
                if (items == null || items.Count < 1)
                    return null;
                else
                    return (Usuario)items[0];
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Boolean IniciarSesion(string usuario, string contraseña)
        {
            try
            {
                string pass;
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ToString()))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = conn;
                        cmd.Connection.Open();
                        cmd.CommandText = "Select password from usuario where UserName='" + usuario + "'";
                        pass = cmd.ExecuteScalar().ToString();
                    }
                }
                if (pass == contraseña)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<ComboItem> GetUsuariosLista()
        {
            List<ComboItem> lista = new List<ComboItem>();
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        {
                            cmd.Connection = conn;
                            cmd.Connection.Open();
                            cmd.CommandText = "select ID,UserName from Usuario";
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                            }
                        }
                    }
                }
                lista.Add(new ComboItem("--SELECCIONE--", 0));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(new ComboItem(dt.Rows[i]["UserName"].ToString(), int.Parse(dt.Rows[i]["ID"].ToString())));
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public DataTable GetUsuariosDT()
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
                        cmd.CommandText = "select ID, UserName from Usuario";
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
