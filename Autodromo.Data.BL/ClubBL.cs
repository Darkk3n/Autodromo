using Autodromo.Data.DA;
using Autodromo.Data.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodromo.Data.BL
{
    public class ClubBL : BusinessFacadeBase
    {
        public Boolean SaveClub(Club club, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(club, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(club);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean DeleteCarrera(Club club)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(club);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Club GetClubById(Int32 clubID)
        {
            try
            {
                ClubDA clubDA = new ClubDA();
                var res = clubDA.GetClubById(clubID);
                clubDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ComboItem> GetClubesLista()
        {
            try
            {
                ClubDA clubDA = new ClubDA();
                var res = clubDA.GetClubesLista();
                clubDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetClubesDT()
        {
            try
            {
                ClubDA clDA = new ClubDA();
                var res = clDA.GetClubesDT();
                clDA = null;
                return res; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
    }
}
