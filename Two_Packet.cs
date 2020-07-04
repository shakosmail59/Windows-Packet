using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Package
{
    public class Two_Packet : Package_Windows
    {
        public Two_Packet()
        {
            PackageName = "Two Packet";
            Price = 130;
            PaCakgeRaodenoba.Add(" Microsoft office 2016 , Adobe reader");
        }
      

        public void Print_Two_Package() 
        {
            Console.WriteLine($"2) {PackageName} , {Price} , \n {PaCakgeRaodenoba[0]} , {PaCakgeRaodenoba[1]} ");
        }
    }
}
