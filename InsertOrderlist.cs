using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystemFLATSTYLE
{
    class InsertOrderlist
    {
        static private string InsertOID;
        static private int InsertResID;
        static private string insertRMan;
        static private string InsertRName;
        static private string InsertDate;
        static private string InsertPhone;
        static private string InsertClass;


        static public string insertclass
        {
            get
            {
                return InsertClass;
            }
            set
            {
                InsertClass = value;
            }
        }

        static public string insertPhone
        {
            get
            {
                return InsertPhone;
            }
            set
            {
                InsertPhone = value;
            }
        }

        static public string insertdate
        {
            get
            {
                return InsertDate;
            }
            set
            {
                InsertDate = value;
            }
        }

        static public string insertRName
        {
            get
            {
                return InsertRName;
            }
            set
            {
                InsertRName = value;
            }
        }



        static public string insertOid
        {
            get
            {
                return InsertOID;
            }
            set
            {
                InsertOID = value;
            }
        } 

        static public int insertResID
        {
            get
            {
                return InsertResID;
            }
            set
            {
                InsertResID = value;
            }
        }

        static public string Rman
        {
            get
            {
                return insertRMan;
            }
            set
            {
                insertRMan = value;
            }
        }
    }
}
