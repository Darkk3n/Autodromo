using NHibernate;
using System;
using System.Collections;

namespace Autodromo.Data.DA
{
    public class BaseDataAccess
    {
        protected ISession m_session;

        public BaseDataAccess()
        {
            m_session = NHibernateHelper.CurrentSession;
        }

        public virtual void Save(object item)
        {
            Save(item, true);
        }

        protected virtual void Save(object item, bool pointlessParameter)
        {
            ITransaction tx = null;

            try
            {
                tx = m_session.BeginTransaction();
                m_session.SaveOrUpdate(item);
                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();
                throw ex;
            }
        }

        public virtual void Save(IList items)
        {
            ITransaction tx = null;

            //m_session.Dispose();
            //m_session = NhibernateHttpModOMM.CreateSession();

            try
            {
                tx = m_session.BeginTransaction();

                if (items != null)
                {
                    foreach (object item in items)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();

                throw ex;
            }
        }

        public virtual void Save(IList items1, IList items2, IList items3)
        {
            ITransaction tx = null;

            //m_session.Dispose();
            //m_session = NhibernateHttpModOMM.CreateSession();

            try
            {
                tx = m_session.BeginTransaction();

                if (items1 != null)
                {
                    foreach (object item in items1)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                if (items2 != null)
                {
                    foreach (object item in items2)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                if (items3 != null)
                {
                    foreach (object item in items3)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();

                throw ex;
            }
        }

        public virtual void DeleteSave(IList itemToSave1, IList itemToSave2, IList itemToDelete)
        {
            ITransaction tx = null;

            //m_session.Dispose();
            //m_session = NhibernateHttpModOMM.CreateSession();

            try
            {
                tx = m_session.BeginTransaction();

                if (itemToSave1 != null)
                {
                    foreach (object item in itemToSave1)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                if (itemToSave2 != null)
                {
                    foreach (object item in itemToSave2)
                    {
                        if (item != null)
                        {
                            m_session.SaveOrUpdate(item);
                        }
                    }
                }

                if (itemToDelete != null)
                {
                    foreach (object item in itemToDelete)
                    {
                        if (item != null)
                        {
                            m_session.Delete(item);
                        }
                    }
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                tx.Rollback();

                throw ex;
            }
        }

        public virtual void Delete(object item)
        {
            ITransaction tx = null;

            try
            {
                tx = m_session.BeginTransaction();

                m_session.Delete(item);

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();

                throw ex;
            }
        }

        public virtual void Delete(IList items, Boolean dist)
        {
            ITransaction tx = null;

            try
            {
                tx = m_session.BeginTransaction();

                if (items != null)
                {
                    foreach (Object item in items)
                        m_session.Delete(item);
                }

                tx.Commit();
            }
            catch (Exception ex)
            {
                if (tx != null) tx.Rollback();

                throw ex;
            }
        }

        public object Get(Type type, object id)
        {
            object returnValue = null;

            try
            {
                returnValue = m_session.Load(type, id);

                return returnValue;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
