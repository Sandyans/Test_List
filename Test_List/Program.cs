using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_List
{
    class Program
    {
        static void Main(string[] args)
        {
            GiveMyList cur;
            GiveMyList GM = new GiveMyList(0);
            cur = GM.setClass(1);
            for (int i = 2; i < 10; i++)
            {
                cur = cur.setClass(i);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(GM.i);
                GM = GM.GML;
            }
            Console.ReadKey();
        }
    }
}
