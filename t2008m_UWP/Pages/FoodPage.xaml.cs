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
using t2008m_UWP.Services;
using t2008m_UWP.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2008m_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FoodPage : Page
    {
        public FoodPage()
        {
            this.InitializeComponent();
        }

        private Models.Food food;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            food = e.Parameter as Models.Food;
            Title.Text = food.name;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CartService cart = new CartService();
            CartItem item = new CartItem()
            {
                Id = food.id,
                Name = food.name,
                Image = food.image,
                Price = food.price,
                Qty = 1
            };
            cart.AddToCart(item);
            //var list = cart.GetCarts();
        }
    }
}
