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
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2008m_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        public Home()
        {
            this.InitializeComponent();
            GV.Items.Add(new MailModel() { Mail = "helo@gmail.com", Subject = "helo", Content = "Hello World!", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg"))});
            GV.Items.Add(new MailModel() { Mail = "nam@gmail.com", Subject = "Nam Cong", Content = "Hello World!", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg"))});
            GV.Items.Add(new MailModel() { Mail = "thanh@gmail.com", Subject = "Thanh Thien", Content = "Hello World!", Img = new BitmapImage(new Uri("https://dscnnwjxnwl3f.cloudfront.net/media/catalog/product/cache/584039753b87a8d227764e04fc461e3e/h/a/hawaii_burger_1_2.jpg"))});
        }

        protected override void OnNavigatedTo(NavigationEventArgs e) // hàm này thực thi khi có sự kiện navigate đến nó
        {
            MenuItem item = e.Parameter as MenuItem;
            Title.Text = item.Name;
        }
    }
}
