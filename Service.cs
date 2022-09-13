using System.Collections.Generic;

namespace TemplateEmptyNhibernate
{
    public class Service
    {
        private readonly IRepository _Repository;
        public Service(IRepository repository)
        {
            _Repository = repository;
        }

        public IList<Dossier> GetDossiers()
        {
            // if.... la logique métier 
            return _Repository.GetDossiers();
        }

    }
}