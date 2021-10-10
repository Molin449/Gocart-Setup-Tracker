using GocartSetupTracker.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GocartSetupTracker.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateCartSetupPage : ContentPage {
        private CartSetup cartSetup;

        public CreateCartSetupPage() {
            InitializeComponent();
            cartSetup = new CartSetup();
            //propertiesInputs.ItemsSource = cartSetup.GetCartSetupProperties();

            createListOfInputs();
        }

        private void createListOfInputs() {
            List<CartSetupPropertyData> propertyNames = cartSetup.GetCartSetupProperties();
            int row = 0;
            RowDefinitionCollection rowCollection = new RowDefinitionCollection();
            foreach (var item in propertyNames) {
                Entry input = new Entry() { ClassId = item.Propinfo.Name };
                input.Placeholder = item.Key;
                inputsWrap.Children.Add(input);
                row++;
            }
        }

        private void SaveCartSetup(object sender, EventArgs e) {
            var children = inputsWrap.Children;

            //looping through inputs
            foreach (View view in children) {
                if (view is Entry) {
                    Entry input = (Entry)view;
                    if(input.Text != null) {
                        addDataProperty(input);
                    }
                }
            }
            DataStore data = DataStore.getInstance;
            data.AddItem(cartSetup);
            Navigation.PopAsync();
        }




        private void addDataProperty(Entry input) {   
            List<CartSetupPropertyData> propertyNames = cartSetup.GetCartSetupProperties();

            //Finding the right property in the object "CartSetup" from the input that
            //has the same ClassId and then adding it to the property
            foreach (var currCartSetupProperty in propertyNames) {
                var itemxPropinfo = currCartSetupProperty.Propinfo;

                if (input.ClassId == itemxPropinfo.Name) {
                    var t = itemxPropinfo.PropertyType;

                    if (t == typeof(int)) {
                        itemxPropinfo.SetValue(cartSetup, int.Parse(input.Text));
                    }
                    if (t == typeof(double)) {
                        itemxPropinfo.SetValue(cartSetup, double.Parse(input.Text));
                    }
                    if (t == typeof(string)) {
                        itemxPropinfo.SetValue(cartSetup, input.Text);
                    }
                    break;
                }
            }
        }

    }
}