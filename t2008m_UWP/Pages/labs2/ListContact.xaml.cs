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
    public sealed partial class ListContact : Page
    {
        List<ContactModel> contacts { get; set; }

        public ListContact()
        {
            this.InitializeComponent();

            contacts = new List<ContactModel>();
            contacts.Add(new ContactModel() { Name = "nam", Tel = "1234567890", Mail = "nam@gmail.com" });
            contacts.Add(new ContactModel() { Name = "Lam", Tel = "1234567890", Mail = "lam@gmail.com" });
            contacts.Add(new ContactModel() { Name = "Khanh", Tel = "1234567890", Mail = "khanh@gmail.com" });
        }
    }
}
