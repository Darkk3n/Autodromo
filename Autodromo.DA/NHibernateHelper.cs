using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Configuration;
using Autodromo.Data.VO;
using System.Web;
namespace Autodromo.Data.DA
{
    public static class NHibernateHelper
    {
        private static ISessionFactory _SessionFactory;

        // this is only used if not running in HttpModule mode
        private static ISessionFactory m_factory;

        // this is only used if not running in HttpModule mode
        private static ISession m_session;

        //private NHibernateManager mgr;

        private static readonly string KEY_NHIBERNATE_FACTORY = "NHibernateSessionFactoryAutodromo";
        private static readonly string KEY_NHIBERNATE_SESSION = "NHibernateSessionAutodromo";
        private static readonly string KEY_CONNECTION_STRING = "Autodromo";

        public static ISessionFactory CreateSessionFactory()
        {
            _SessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(ConfigurationManager.ConnectionStrings["Autodromo"].ConnectionString.ToString()))
                .Mappings(m =>
                    m.FluentMappings.AddFromAssemblyOf<CorredorMap>())
                .BuildSessionFactory();

            return _SessionFactory;
        }

        public static ISession OpenSession()
        {
            try
            {
                var sessionFactory = CreateSessionFactory();
                return sessionFactory.OpenSession();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISessionFactory CurrentFactory
        {
            get
            {
                if (HttpContext.Current == null)
                {
                    // running without an HttpContext (non-web mode)
                    // the nhibernate session is a singleton in the app domain
                    if (m_factory != null)
                    {
                        return m_factory;
                    }
                    else
                    {
                        //NHibernateManager mgr = new NHibernateManager();
                        m_factory = CreateSessionFactory();
                        //m_factory = mgr.Session.SessionFactory;
                        return m_factory;
                    }
                }
                else
                {
                    HttpContext currentContext = HttpContext.Current;

                    ISessionFactory factory = currentContext.Application[KEY_NHIBERNATE_FACTORY] as ISessionFactory;

                    if (factory == null)
                    {
                        // NHibernateManager mgr = new NHibernateManager();
                        factory = CreateSessionFactory();
                        //factory = mgr.Session.SessionFactory;
                        currentContext.Application[KEY_NHIBERNATE_FACTORY] = factory;
                    }

                    return factory;
                }
            }
        }

        public static ISession CreateSession()
        {
            ISessionFactory factory;
            ISession session;

            factory = NHibernateHelper.CurrentFactory;

            if (factory == null)
            {
                throw new InvalidOperationException("Call to Configuration.BuildSessionFactory() returned null.");
            }

            session = factory.OpenSession();

            if (session == null)
            {
                throw new InvalidOperationException("Call to factory.OpenSession() returned null.");
            }

            return session;
        }

        public static ISession CurrentSession
        {
            get
            {

                if (HttpContext.Current == null)
                {
                    // running without an HttpContext (non-web mode)
                    // the nhibernate session is a singleton in the app domain
                    if (m_session != null)
                    {
                        return m_session;
                    }
                    else
                    {
                        // NHibernateManager mgr = new NHibernateManager();
                        m_session = CreateSession();
                        // m_session = mgr.Session;

                        return m_session;
                    }
                }
                else
                {
                    // running inside of an HttpContext (web mode)
                    // the nhibernate session is a singleton to the http request
                    HttpContext currentContext = HttpContext.Current;

                    ISession session = currentContext.Items[KEY_NHIBERNATE_SESSION] as ISession;

                    if (session == null)
                    {
                        //NHibernateManager mgr = new NHibernateManager();
                        session = CreateSession();
                        //session = mgr.Session;
                        currentContext.Items[KEY_NHIBERNATE_SESSION] = session;
                    }

                    return session;
                }
            }
        }
    }
}
