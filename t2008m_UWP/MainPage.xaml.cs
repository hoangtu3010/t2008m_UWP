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
            MainFrame.Navigate(typeof(Pages.MailList));
        }

        private void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.Home));

        }

        private void PersonInfo(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(Pages.PersonInformation));

        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new MenuItem() { Name = "Home", MenuPage = "home" };
            var item2 = new MenuItem() { Name = "Person Infomation", MenuPage = "pi" };
            Menu.Items.Add(item);
            Menu.Items.Add(item2);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(Pages.Home)); break;
                case "pi": MainFrame.Navigate(typeof(Pages.PersonInformation)); break;
            }
        }
    }
}
