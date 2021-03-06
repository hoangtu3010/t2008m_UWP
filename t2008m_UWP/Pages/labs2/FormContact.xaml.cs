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
    public sealed partial class FormContact : Page
    {
        List<ContactModel> contacts { get; set; }


        public FormContact()
        {
            this.InitializeComponent();
            contacts = new List<ContactModel>();
        }

        private void add(object sender, RoutedEventArgs e)
        {
            contacts.Add(new ContactModel() { Name = inputName.Text, Tel = inputTel.Text, Mail = inputEmail.Text });
            Home._frame.Navigate(typeof(Pages.labs2.ListContact));
        }
    }
}
