using Autodromo.Data.DA;
using Autodromo.Data.VO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Autodromo.Data.BL
{
    public class AutomovilBL : BusinessFacadeBase
    {
        public IList GetAllAutomovil()
        {
            try
            {
                AutomovilDA autoDA = new AutomovilDA();
                var res = autoDA.GetAllAutomovil();
                autoDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllAutomovilByEstatus(Boolean estado)
        {
            try
            {
                AutomovilDA autoDA = new AutomovilDA();
                var res = autoDA.GetAllAutomovilByEstatus(estado);
                autoDA = null;
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Automovil GetAutomovilById(int autoID)
        {
            try
            {
                AutomovilDA autoDA = new AutomovilDA();
                var res = autoDA.GetAutomovilById(autoID);
                autoDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean SaveAutomovil(Automovil auto, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(auto, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(auto);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteAutomovil(Automovil auto)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(auto);
                bda = null;
                return true;
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
                AutomovilDA autoDA = new AutomovilDA();
                var res = autoDA.GetAllAutomovilDT();
                autoDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ComboItem> GetCategorias()
        {
            try
            {
                AutomovilDA autoDA = new AutomovilDA();
                var res = autoDA.GetCategorias();
                autoDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
