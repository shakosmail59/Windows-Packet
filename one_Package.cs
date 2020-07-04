using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Package
{
    class one_Package : Package_Windows
    {
        public one_Package()
        {
            PackageName = "One Packet";
            Price = 125;
           
        }

        public void Print_One_Package() 
        {
            Console.WriteLine($"1) {PackageName} , {Price} , \n {PaCakgeRaodenoba[0]} ");
        }
    }
}
