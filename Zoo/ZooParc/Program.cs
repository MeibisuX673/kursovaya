using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooParc_Lib.Controler;

namespace ZooParc
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexController c1 = new ComplexController("Complex_1", 2, true, false, 4);
            c1.SaveTxt(@"C:\Users\student\Desktop\");
        }
    }
}
