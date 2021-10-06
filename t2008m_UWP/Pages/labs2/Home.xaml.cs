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
using t2008m_UWP.Models.labs2;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2008m_UWP.Pages.labs2
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public static Frame _frame;
        public Home()
        {
            this.InitializeComponent();
            _frame = MainFrame;
        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuList() { Name = "Home", NamePage = "home" };
            var item2 = new MenuList() { Name = "Contact", NamePage = "contact" };
            var item3 = new MenuList() { Name = "Customer", NamePage = "customer" };
            var item4 = new MenuList() { Name = "Mail", NamePage = "mail" };

            HomeMenu.Items.Add(item1);
            HomeMenu.Items.Add(item2);
            HomeMenu.Items.Add(item3);
            HomeMenu.Items.Add(item4);
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuList selectedItem = (MenuList)HomeMenu.SelectedItem;
            switch (selectedItem.NamePage)
            {
                case "home": Frame.Navigate(typeof(Pages.labs2.Home)); break;
                case "contact": MainFrame.Navigate(typeof(Pages.labs2.Contact)); break;
                case "customer": MainFrame.Navigate(typeof(Pages.labs2.Customer)); break;
                case "mail": MainFrame.Navigate(typeof(Pages.labs2.Mail)); break;
            }
        }

        private void click_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Spl.IsPaneOpen = !Spl.IsPaneOpen;
        }
    }
}
