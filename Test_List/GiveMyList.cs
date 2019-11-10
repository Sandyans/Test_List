using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_List
{
    class GiveMyList
    {
        public GiveMyList GML;
        public int i;

        public GiveMyList(int i)
        {
            this.i = i;
        }

        public GiveMyList setClass(int i)
        {
           return  GML = new GiveMyList(i); 
        }
    }
}
