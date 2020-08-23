using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemFLATSTYLE
{
    class RestaurantGear
    {
        static private int ID;
        static private string res;//餐廳        
        static private List<string> fooditems;
        static private List<int> price;
        static private string address;
        static private string phone;
        static private string kind;


        static public int IDaccess
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }




        static public string 餐廳
        {
            get
            {
                return res;
            }
            set
            {
                res = value;
            }
        }

        

       static public List<string> Items
       {
            get
            {
                return fooditems;
            }
            set
            {
                fooditems = value;
            }
       }

        static public List<int> Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }


        static public string Address 
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        static public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        static public string Kind
        {
            get
            {
                return kind;
            }
            set
            {
                kind = value;
            }
        }



       
    }
}
