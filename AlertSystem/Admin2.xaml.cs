using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlertSystem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin2 : ContentPage
    {

        Dictionary<string,Array> nameToAreas = new Dictionary<string, Array>
        {
            { "Metrology 1", Array. }, { "Metrology 2", Array.M2 },
            { "Server Room 1", Array.SR1 }, { "Server Room 2", Array.SR1 },
            { "Server Room 3", Array.SR1 }
        };

        public Admin2()
        {
            InitializeComponent();

            Label header = new Label
            {
                Text = "Picker",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };

            Picker picker = new Picker
            {
                Title = "Area",
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            foreach (string areasName in nameToAreas.Keys)
            {
                picker.Items.Add(areasName);
            }

        
    }
    




            private async void BtnLogOut_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new MainPage()));

        }

      
    }

    }
