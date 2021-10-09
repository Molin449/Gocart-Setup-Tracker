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
        public UpdateCartSetupPage(CartSetup cartsetup) {
            Title = $"Opdater: {cartsetup.SetupName}";
            InitializeComponent();
        }
    }
}