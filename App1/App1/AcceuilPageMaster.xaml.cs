using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AcceuilPageMaster : ContentPage
    {
        public ListView ListView;

        public AcceuilPageMaster()
        {
            InitializeComponent();

            BindingContext = new AcceuilPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class AcceuilPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<AcceuilPageMenuItem> MenuItems { get; set; }

            public AcceuilPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<AcceuilPageMenuItem>(new[]
                {
                    new AcceuilPageMenuItem { Id = 0, Title = "Mes offres", TargetType = typeof(OffresPage) },
                    new AcceuilPageMenuItem { Id = 1, Title = "Mes Clients", TargetType = typeof(ClientsPage) },
                    new AcceuilPageMenuItem { Id = 2, Title = "Mes Ventes", TargetType = typeof(VentesPage) },
                    new AcceuilPageMenuItem { Id = 3, Title = "Mon Profil" },
                    new AcceuilPageMenuItem { Id = 4, Title = "Se déconnecter" , TargetType = typeof(LoginPage) }
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}