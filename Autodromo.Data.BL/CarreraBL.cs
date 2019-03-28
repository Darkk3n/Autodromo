using System;
using Autodromo.Data.VO;
using Autodromo.Data.DA;
using System.Collections;
using System.Data;

namespace Autodromo.Data.BL
{
    public class CarreraBL : BusinessFacadeBase
    {
        public IList GetAllCarrera()
        {
            try
            {
                CarreraDA carreraDA = new CarreraDA();
                var res = carreraDA.GetAllCarrera();
                carreraDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IList GetAllCarreraByEstatus(Boolean estado)
        {
            try
            {
                CarreraDA carreraDA = new CarreraDA();
                var res = carreraDA.GetAllCarreraByEstatus(estado);
                carreraDA = null;
                return res;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Boolean SaveCarrera(Carrera carrer, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(carrer, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(carrer);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteCarrera(Carrera carrer)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(carrer);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCorredorAutoById(Int32 corredorID, Int32 autoID)
        {
            try
            {
                CarreraDA carreraDA = new CarreraDA();
                var res = carreraDA.GetCorredorAutoByID(corredorID, autoID);
                carreraDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCarrerasPorEvento()
        {
            try
            {
                CarreraDA carrDA = new CarreraDA();
                var res = carrDA.GetCarrerasPorEvento();
                carrDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
