using NHibernate;
using NHibernate.Mapping.ByCode;
using TemplateEmptyNhibernate.NHibernate;

namespace TemplateEmptyNhibernate
{
    internal class MainViewModel
    {
        public Service Service { get; set; }
        public MainViewModel()
        {
            var configNH = new NhibernateConfigurator();
            configNH.Init();
            var repo = new Repository(configNH.GetSession());
            Service = new Service(repo);

            var dossiers = Service.GetDossiers();

        }
    }
}