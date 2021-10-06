using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2008m_UWP.Adapters
{
    class FoodGroup
    {
        private readonly string baseUrl = "http://foodgroup.herokuapp.com";
        //singleton pattern
        private static FoodGroup instance;

        private FoodGroup()
        {

        }

        public static FoodGroup GetInstance()
        {
            if(instance == null)
            {
                instance = new FoodGroup();
            }
            return instance;
        }

        // api list categories
        public string ApiMenu
        {
            get => string.Format(baseUrl + "/api/menu");
        }

        public string CategoryDetail(string id)
        {
            return string.Format(baseUrl + "/api/category/" + id);
        }
    }
}
