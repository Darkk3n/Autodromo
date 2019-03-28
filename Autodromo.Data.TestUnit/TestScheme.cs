using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using System;
using System.Configuration;
using Autodromo.Data.VO;
namespace Autodromo.Data.TestUnit
{
    [TestFixture]
    public class TestScheme
    {
        private static ISessionFactory _SessionFactory;
        [Test]
        public void GeneraEsquema()
        {
            try
            {
                _SessionFactory = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008
                        .ConnectionString(ConfigurationManager.ConnectionStrings["Autodromo"].ToString()))
                    .Mappings(m =>
                        m.FluentMappings.AddFromAssemblyOf<CarreraMap>())
                        .ExposeConfiguration(cfg =>
                        {
                            new SchemaExport(cfg)
                                .Execute(true, false, false);
                        })
                    .BuildSessionFactory();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
