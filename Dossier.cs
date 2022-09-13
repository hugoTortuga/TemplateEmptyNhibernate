using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TemplateEmptyNhibernate
{

    public class DossierMap : ClassMapping<Dossier>
    {
        public DossierMap()
        {
            Schema("sesame");
            Table("dossier");
            Id(x => x.CodeDossier, m => m.Generator(Generators.Assigned));
            Property(x => x.RaisonSociale);
        }
    }

    public class Dossier : INotifyPropertyChanged
    {

        private string _CodeDossier;
        public virtual string CodeDossier
        {
            get { return _CodeDossier; }
            set
            {
                _CodeDossier = value;
                OnPropertyChanged();
            }
        }

        private string _RaisonSociale;
        public virtual string RaisonSociale
        {
            get { return _RaisonSociale; }
            set
            {
                _RaisonSociale = value;
                OnPropertyChanged();
            }
        }

        #region INotify
        public virtual event PropertyChangedEventHandler PropertyChanged;  
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}