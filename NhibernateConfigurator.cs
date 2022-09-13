using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.ByCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateEmptyNhibernate.NHibernate
{
    public class NhibernateConfigurator
    {
        private Configuration _config;

        public void Init()
        {
            _config = new Configuration();
            _config.Configure();
            _config.AddAssembly(typeof(MainWindow).Assembly);
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(MainWindow).Assembly.GetExportedTypes());
            var mapping = mapper.CompileMappingForAllExplicitlyAddedEntities();
            mapping.autoimport = false;
            _config.AddMapping(mapping);
        }

        public ISession GetSession()
        {
            var sessionFactory = _config.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }


    }
}
