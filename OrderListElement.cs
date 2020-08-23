using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemFLATSTYLE
{
    class OrderListElement
    {
        static public List<ArrayList> OrderDetail = new List<ArrayList>();
        static private string phone;
        static private string 負責人;
        static private string OrederID;




        static public string O_ID
        {
            get
            {
                return OrederID;
            }
            set
            {
                OrederID = value;
            }
        }

        static public string ResponsibleMan
        {
            get
            {
                return 負責人;
            }
            set
            {
                負責人 = value;
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







       
    }
}
