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
    public partial class SetupItemDetailPage : ContentPage {
        private CartSetup currCartSetup;
        public SetupItemDetailPage(CartSetup cartSetup) {
            currCartSetup = cartSetup;
            Title = $"{cartSetup.SetupName}";
            BindingContext = this;
            InitializeComponent();
            CartSetupProperties.ItemsSource = cartSetup.GetCartSetupProperties();
        }

        private void UpdateCartSetup(object sender, EventArgs e) {
            Navigation.PushAsync(new UpdateCartSetupPage(currCartSetup));
        }
    }
}