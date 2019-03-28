using Autodromo.Data.DA;
using Autodromo.Data.VO;
using System;
using System.Collections;
using System.Data;

namespace Autodromo.Data.BL
{
    public class CorredorBL : BusinessFacadeBase
    {
        public IList GetAllCorredor()
        {
            try
            {
                CorredorDA corredorDA = new CorredorDA();
                var res = corredorDA.GetAllCorredor();
                corredorDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Corredor GetCorredorById(Int32 id)
        {
            try
            {
                CorredorDA corredorDA = new CorredorDA();
                var res = corredorDA.GetCorredorById(id);
                corredorDA = null;
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IList GetAllCorredorByEstatus(Boolean estado)
        {
            try
            {
                CorredorDA corredorDA = new CorredorDA();
                var res = corredorDA.GetAllCorredorByEstatus(estado);
                corredorDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean SaveCorredor(Corredor corredor, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(corredor, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(corredor);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteCorredor(Corredor corredor)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(corredor);
                bda = null;
                return true;
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
                CorredorDA corredorDA = new CorredorDA();
                var res = corredorDA.GetAllCorredorDT();
                corredorDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Corredor GetCorredorByFullName(String Nombre)
        {
            try
            {
                CorredorDA correDA = new CorredorDA();
                var res = correDA.GetCorredorByName(Nombre);
                correDA = null;
                return res;
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
    }
}
