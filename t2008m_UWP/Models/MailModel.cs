using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace t2008m_UWP.Models
{
    class MailModel
    {
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime SendTime { get; set; }

        public BitmapImage Img { get; set; }
    }
}
