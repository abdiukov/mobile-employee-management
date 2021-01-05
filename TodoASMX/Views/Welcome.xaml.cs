using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TodoASMX.Views
{
    public partial class Welcome : ContentPage
    {
        private bool default_theme;
        public Welcome()
        {
            InitializeComponent();
            
            //selecting the default theme and showing it with an outline (button outline) 
            Btn_Default_Theme.BorderWidth = 10;
            default_theme = true;
        }

        async void OnShowHelp(object sender, EventArgs e)
        {
            //upon clicking the button, it gets inverted
            Help.IsVisible = !Help.IsVisible;
        }

        //navigates to main menu
        async void OnNavigateMainMenu(object sender, EventArgs e)
        {
            switch (default_theme)
            {
                case true:
                    await Navigation.PushAsync(new TodoListPage());
                    break;
                case false:
                    await Navigation.PushAsync(new TodoListPage
                    {
                        BackgroundColor = Color.FromHex("#fdab9f")
                    });
                    break;
            }
        }
        private void Btn_Default_Theme_Clicked(object sender, EventArgs e)
        {
            Btn_Orange_Theme.BorderWidth = 0;
            Btn_Default_Theme.BorderWidth = 10;
            default_theme = true;
            BackgroundColor = Color.FromHex("#fff");
            }

        private void Btn_Orange_Theme_Clicked(object sender, EventArgs e)
        {
            Btn_Default_Theme.BorderWidth = 0;
            Btn_Orange_Theme.BorderWidth = 10;
            default_theme = false;
            BackgroundColor = Color.FromHex("#fdab9f");
            }
    }
}