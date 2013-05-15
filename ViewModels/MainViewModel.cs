using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using UVwebForWindowsPhone.Resources;

namespace UVwebForWindowsPhone.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            this.UvItems = new ObservableCollection<UvItemViewModel>();
            this.NewsfeedEntries = new ObservableCollection<NewsfeedEntryViewModel>();
        }

        /// <summary>
        /// Collection for UvItemViewModels
        /// </summary>
        public ObservableCollection<UvItemViewModel> UvItems { get; private set; }

        /// <summary>
        /// Collection for NewsfeedEntryViewModels
        /// </summary>
        public ObservableCollection<NewsfeedEntryViewModel> NewsfeedEntries { get; private set; }

        private string _sampleProperty = "Sample Runtime Property Value";
        /// <summary>
        /// Exemple de propriété ViewModel ; cette propriété est utilisée dans la vue pour afficher sa valeur à l'aide d'une liaison
        /// </summary>
        /// <returns></returns>
        public string SampleProperty
        {
            get
            {
                return _sampleProperty;
            }
            set
            {
                if (value != _sampleProperty)
                {
                    _sampleProperty = value;
                    NotifyPropertyChanged("SampleProperty");
                }
            }
        }

        /// <summary>
        /// Exemple de propriété qui retourne une chaîne localisée
        /// </summary>
        public string LocalizedSampleProperty
        {
            get
            {
                return AppResources.SampleProperty;
            }
        }

        public bool IsDataLoaded
        {
            get;
            private set;
        }

        /// <summary>
        /// Crée et ajoute quelques objets ItemViewModel dans la collection Items.
        /// </summary>
        public void LoadData()
        {
            // Exemple de données ; remplacer par des données réelles
            this.UvItems.Add(new UvItemViewModel() { Name = "MT23", Title = "Algèbre linéaire"});
            this.UvItems.Add(new UvItemViewModel() { Name = "LO21", Title = "Programmation orientée objet" });
            this.UvItems.Add(new UvItemViewModel() { Name = "MQ01", Title = "Résistance des matériaux" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF16", Title = "Algorithmique et structures de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF17", Title = "Conception de bases de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "IA04", Title = "Systèmes multi-agents" });
            this.UvItems.Add(new UvItemViewModel() { Name = "MT23", Title = "Algèbre linéaire" });
            this.UvItems.Add(new UvItemViewModel() { Name = "LO21", Title = "Programmation orientée objet" });
            this.UvItems.Add(new UvItemViewModel() { Name = "MQ01", Title = "Résistance des matériaux" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF16", Title = "Algorithmique et structures de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF17", Title = "Conception de bases de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "IA04", Title = "Systèmes multi-agents" });
            this.UvItems.Add(new UvItemViewModel() { Name = "MT23", Title = "Algèbre linéaire" });
            this.UvItems.Add(new UvItemViewModel() { Name = "LO21", Title = "Programmation orientée objet" });
            this.UvItems.Add(new UvItemViewModel() { Name = "MQ01", Title = "Résistance des matériaux" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF16", Title = "Algorithmique et structures de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "NF17", Title = "Conception de bases de données" });
            this.UvItems.Add(new UvItemViewModel() { Name = "IA04", Title = "Systèmes multi-agents" });

            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "amasciul", Action = "a publié un nouveau commentaire", Date = "15 mai 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "tkeunebr", Action = "a publié un nouveau commentaire", Date = "22 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "mboiteau", Action = "a publié un nouveau commentaire", Date = "3 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "amasciul", Action = "a publié un nouveau commentaire", Date = "15 mai 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "tkeunebr", Action = "a publié un nouveau commentaire", Date = "22 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "mboiteau", Action = "a publié un nouveau commentaire", Date = "3 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "amasciul", Action = "a publié un nouveau commentaire", Date = "15 mai 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "tkeunebr", Action = "a publié un nouveau commentaire", Date = "22 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
            this.NewsfeedEntries.Add(new NewsfeedEntryViewModel() { Author = "mboiteau", Action = "a publié un nouveau commentaire", Date = "3 avril 2013", Comment = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });

            this.IsDataLoaded = true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}