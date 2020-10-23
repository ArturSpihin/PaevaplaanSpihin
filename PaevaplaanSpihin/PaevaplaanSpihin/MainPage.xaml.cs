using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PaevaplaanSpihin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout st = new StackLayout();
            Button esm_btn = new Button { Text = "Esmaspäev" };
            st.Children.Add(esm_btn);
            esm_btn.Clicked += new EventHandler(Button_ClickedAsync);
            Content = st;
        }

        private async Task Button_ClickedAsync(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Esmaspäev":
                    await Navigation.PopAsync();
                    Esmaspaev esmaspaev = new Esmaspaev();
                    await Navigation.PopAsync(esmaspaev);
                    break;
            }



        }
    }
}
