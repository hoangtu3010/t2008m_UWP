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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace t2008m_UWP.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MessageList : Page
    {
        List<string> listMail = new List<string>();

        public MessageList()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            listMail.Clear();

            listMail.Add(inputTitle.Text);
            listMail.Add(inputEmail.Text);
            listMail.Add(inputMessage.Text);

            for (var i = 0; i < listMail.Count; i++)
            {
                historyEmail.Text += listMail[i] + "\n";
            }
        }
    }
}
