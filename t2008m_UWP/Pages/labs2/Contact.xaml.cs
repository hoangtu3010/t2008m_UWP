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
    public sealed partial class Contact : Page
    {

        public Contact()
        {
            this.InitializeComponent();
            ContactFrame.Navigate(typeof(Pages.labs2.ListContact));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            butAddCon.Visibility = Visibility.Collapsed;
            ContactFrame.Navigate(typeof(Pages.labs2.FormContact));
            butBackCon.Visibility = Visibility.Visible;

        }

        private void butBackCon_Click(object sender, RoutedEventArgs e)
        {
            butBackCon.Visibility = Visibility.Collapsed;
            ContactFrame.Navigate(typeof(Pages.labs2.ListContact));
            butAddCon.Visibility = Visibility.Visible;

        }
    }
}
