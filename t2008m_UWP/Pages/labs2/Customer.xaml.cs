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
    public sealed partial class Customer : Page
    {
        List<CustomerModel>  customers { get; set; }
        public Customer()
        {
            this.InitializeComponent();
            customers = new List<CustomerModel>();
            customers.Add(new CustomerModel() { Name = "Nam", Age = 19, Address = "Ba Vi" });
            customers.Add(new CustomerModel() { Name = "Khanh", Age = 23, Address = "8 Ton That Thuyet" });
            customers.Add(new CustomerModel() { Name = "Tuyet", Age = 24, Address = "Ha Noi" });
        }
    }
}
