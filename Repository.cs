using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateEmptyNhibernate
{
    public class Repository : IRepository
    {

        private readonly ISession _Session;

        public Repository(ISession session)
        {
            _Session = session;
        }

        public IList<Dossier> GetDossiers()
        {
            return _Session.Query<Dossier>().Where(e => e.RaisonSociale.StartsWith("Test")).ToList();
        }
    }

}
