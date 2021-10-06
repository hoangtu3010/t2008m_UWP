using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using t2008m_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace t2008m_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame _mainFrame;

        public MainPage()
        {
            this.InitializeComponent();
            _mainFrame = MainFrame;
            MainFrame.Navigate(typeof(Pages.DemoFilePage));
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new MenuItem() { Name = "Home", MenuPage = "home", Icon = "\ue80f" };
            var item2 = new MenuItem() { Name = "Person Infomation", MenuPage = "pi", Icon = "\ue8d4" };
            var item3 = new MenuItem() { Name = "Contact", MenuPage = "contact", Icon = "\ue717" };
            Menu.Items.Add(item);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            RenderCategoryToMenu();
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home), selectedItem); break;
                case "pi": MainFrame.Navigate(typeof(Pages.PersonInformation)); break;
                case "category": MainFrame.Navigate(typeof(Pages.CategoryPage), selectedItem.Category); break;
            }
        }

        public async void RenderCategoryToMenu()
        {
            // dung Sevieces de lay obj Categories
            Services.MenuSevices sevices = new Services.MenuSevices();
            Models.Categories categories = await sevices.GetMenu();
            if(categories != null)
            {
                foreach(Models.Category c in categories.data)
                {
                    Menu.Items.Add(new MenuItem() { Name = c.name, MenuPage = "category", Icon = "\ue71d", Category = c });
                }
            }
        }
    }
}
