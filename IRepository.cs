using System.Collections.Generic;

namespace TemplateEmptyNhibernate
{
    public interface IRepository
    {
        IList<Dossier> GetDossiers();
    }
}