using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OrderingSystemFLATSTYLE
{
    class ClassMytools
    {
        static private string is_who;
        static private string stname;        
        private string PW;//密碼//以電話預設
        private string stphone;
        private string email;
        static private string stclass;//班級
        static private string stid;
       
        



        static public string Who
        {
            get
            {
                return is_who;
            }
            set
            {
                is_who = value;
            }
            
        }

        static public string Class
        {
            get
            {
                return stclass;
            }
            set
            {
                stclass = value;
            }
        }

        public string Phone
        {
            get
            {
                return stphone;
            }
            set
            {
                stphone = value;
            }
        }


        static public string ID
        {
            get
            {
                return stid;
            }
            set
            {
                stid = value;
            }
        }

        static public string Name
        {
            get
            {
                return stname;
            }
            set
            {
                stname = value;
            }
        }
       

        public string mail
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return PW;
            }
            set
            {
                PW = value;
            }
        }

        
       
        





    }
}
