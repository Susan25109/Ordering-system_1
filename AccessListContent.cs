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

        static public int insertresID
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
    }
}
