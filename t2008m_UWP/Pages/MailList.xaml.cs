using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using t2008m_UWP.Models;
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
    public sealed partial class MailList : Page
    {
        List<MailModel> listMail = new List<MailModel>();

        public MailList()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //listMail.Clear();
            var sendDate = inputDate.SelectedDate.Value.DateTime; // lay duoc 1 object tu 1 datepicker

            var m = new MailModel() { Mail = inputEmail.Text, Subject = inputTitle.Text, Content = inputMessage.Text, SendTime = sendDate };

            //var txt = inputEmail.Text + " -- " + inputTitle.Text + " -- " + inputMessage.Text + "\n ---------------------------------";

            listMail.Add(m);

            PrintMail();

            inputEmail.Text = "";
            inputTitle.Text = "";
            inputMessage.Text = "";
        }

        private void PrintMail()
        {
            historyEmail.Text = "";

            foreach (MailModel m in listMail)
            {
                historyEmail.Text += m.Mail + " -- " + m.Subject + " -- " + m.Content + "\n" + m.SendTime + "\n ------------------------- \n";
            }
        }
    }
}
