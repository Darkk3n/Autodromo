using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Autodromo.Data.DA;
using Autodromo.Data.VO;

namespace Autodromo.Data.BL
{
   public class UsuarioBL : BusinessFacadeBase
    {
        public IList GetAllUsuario()
        {
            try
            {
                UsuarioDA userDA = new UsuarioDA();
                var res = userDA.GetAllUsuario();
                userDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllUsuarioByEstatus(Boolean estado)
        {
            try
            {
                UsuarioDA usuarioDA = new UsuarioDA();
                var res = usuarioDA.GetAllUsuarioByEstatus(estado);
                usuarioDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Usuario GetUsuarioById(Int32 usuarioID)
        {
            try
            {
                UsuarioDA usuarioDA = new UsuarioDA();
                var res = usuarioDA.GetUsuarioById(usuarioID);
                usuarioDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean SaveUsuario(Usuario user, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(user, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(user);
                bda = null;
                return true;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteUsuario(Usuario user)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(user);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean IniciarSesion(string usuario, string contra)
        {
            try
            {
                UsuarioDA userDA = new UsuarioDA();
                var res = userDA.IniciarSesion(usuario, contra);
                userDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ComboItem> GetUsuariosLista()
        {
            try
            {
                UsuarioDA userDA = new UsuarioDA();
                var res = userDA.GetUsuariosLista();
                userDA = null;
                return res;
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
                UsuarioDA userDA = new UsuarioDA();
                var res = userDA.GetUsuariosDT();
                userDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }     
    }
}
