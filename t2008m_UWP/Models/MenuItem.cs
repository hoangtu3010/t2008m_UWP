using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2008m_UWP.Models
{
    class MenuItem
    {
        public string Name { get; set; } //abstract property
        public string MenuPage { get; set; }
        public string Icon { get; set; }
        public Category Category { get; set; }
    }
}
