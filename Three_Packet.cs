using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Package.paketebi
{
    public class Three_Packet : Package_Windows
    {
        public Three_Packet()
        {
            PackageName = "Three Packet";
            Price = 140;
            PaCakgeRaodenoba.Add(" Microsoft office 2019, Adobe reader");
        }

        public void Print_Three_Package()
        {
            Console.WriteLine($"3){PackageName} , {Price} , \n {PaCakgeRaodenoba[0]} , {PaCakgeRaodenoba[1]} ");
        }

    }
}
