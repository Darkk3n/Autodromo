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
    public class CategoriaBL : BusinessFacadeBase
    {
        public bool SaveCategoria(Categoria cat, Usuario usuarioSistema)
        {
            try
            {
                CheckObjectBeforeSave(cat, usuarioSistema);
                BaseDataAccess bda = new BaseDataAccess();
                bda.Save(cat);
                bda = null;
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteCategoria(Categoria cat, Usuario usuarioSistema)
        {
            try
            {
                BaseDataAccess bda = new BaseDataAccess();
                bda.Delete(cat);
                bda = null;
                return true;
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
                CategoriaDA catDA = new CategoriaDA();
                var res = catDA.GetCategorias();
                catDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Categoria GetCategoriaById(int catID)
        {
            try
            {
                CategoriaDA catDA = new CategoriaDA();
                var res = catDA.GetCategoriaById(catID);
                catDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetCategoriasDT()
        {
            try
            {
                CategoriaDA catDA = new CategoriaDA();
                var res = catDA.GetCategoriasDT();
                catDA = null;
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
