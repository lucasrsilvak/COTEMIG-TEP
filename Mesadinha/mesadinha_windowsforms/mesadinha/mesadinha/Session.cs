using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesadinha
{
    class Session
    {
        public static string _id;

        public static string Id
        {
            get { return Session._id; }
            set { Session._id = value; }
         }
    }
}
