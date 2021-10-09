using GocartSetupTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GocartSetupTracker.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class setupsListPage : ContentPage {
        public ObservableCollection<CartSetup> cartSetupsList;
        private Data data;

        public setupsListPage() {
            InitializeComponent();
            data = new Data();
            
            cartSetupsList = data.GetList;
            setupsListView.ItemsSource = cartSetupsList;
        }

        private void setUpSelected(object sender, SelectedItemChangedEventArgs e) {
            CartSetup cartSetup = (CartSetup)e.SelectedItem;
            Navigation.PushAsync(new SetupItemDetailPage(cartSetup));
        }

        private void CreateNewCartSetup(object sender, EventArgs e) {
            Navigation.PushAsync(new CreateCartSetupPage());
        }
    }
}