using GocartSetupTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GocartSetupTracker.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UpdateCartSetupPage : ContentPage {
        private CartSetup cartSetup;
        public UpdateCartSetupPage(CartSetup cartsetup) {
            this.cartSetup = cartsetup;
            InitializeComponent();
            createListOfCartsetupAttributes();
        }

        private async void DeleteItem(object sender, EventArgs e) {
            bool wantToDelete = await DisplayAlert("Du er ved at slette et setup!", $"Du er ved at slette: {cartSetup.SetupName}. Vil du fortsætte?", "Slet", "Nej");
            if (wantToDelete) {
                DataStore data = DataStore.getInstance;
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                await Navigation.PopAsync();
                data.DeleteItem(cartSetup);
            }
        }

        private void createListOfCartsetupAttributes() {
            List<CartSetupPropertyData> propertyNames = cartSetup.GetCartSetupProperties();

            foreach (var item in propertyNames) {
                Label label = new Label() { Text = item.Key };
                Entry input = new Entry() { Placeholder = item.Value };
                inputsWrap.Children.Add(label);
                inputsWrap.Children.Add(input);
            }
        }

        private void SaveCartSetupUpdate(object sender, EventArgs e) {

        }
    }
}