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
using t2008m_UWP.Models.practical;
using Windows.Storage;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2008m_UWP.Pages.practical
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductManagement : Page
    {

        public ProductManagement()
        {
            this.InitializeComponent();
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var inputItem = new ProductManagerModel() { Image = inputImage.SelectedItem.ToString(), ProductName = inputProduct.Text, Description = inputDescription.Text };
            ProductList.Items.Add(inputItem);
        }

        private void ProductList_Loaded(object sender, RoutedEventArgs e)
        {
            var item = new ProductManagerModel() { Image = "/Assets/picture-box-1.jpg", ProductName = "Burger", Description = "This is Burger" };
            var item2 = new ProductManagerModel() { Image = "/Assets/picture-box-1.jpg", ProductName = "Burger", Description = "This is Burger" };

            ProductList.Items.Add(item);
            ProductList.Items.Add(item);
            ProductList.Items.Add(item);
        }

        private void inputImage_Loaded(object sender, RoutedEventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(@"./Assets/");

            FileInfo[] files = dir.GetFiles();

            

            foreach(FileInfo file in files)
            {
                var FileName = Path.GetFileName(file.ToString());
                inputImage.Items.Add("/Assets/" + FileName);
            }
        }
    }
}
