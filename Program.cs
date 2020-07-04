using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows_Package.paketebi;

namespace Windows_Package
{
    class Program
    {
        static void paketebis_gamotana() 
        {
            Console.Write("romeli paketi gnebavt??? \n 1- tu daawert mashin iqneba 125 lari " +
                         "\n 2- tu daawert 130lari \n" +
                         " 3 - tu daawert mashin iqneba 140 lari : ");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    one_Package one_Package = new one_Package();
                    one_Package.Print_One_Package();
                    Console.WriteLine();
                    break;
                case 2:
                    Two_Packet two_Packet = new Two_Packet();
                    two_Packet.Print_Two_Package();
                    Console.WriteLine();
                    break;
                case 3:
                    Three_Packet three_Packet = new Three_Packet();
                    three_Packet.Print_Three_Package();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("msgavsi paketi ararsebobs mara msgavsi programa tu gindat undat daamatot calke tanxa");
                    break;
            }

        }

        static void Main(string[] args)
        {
            paketebis_gamotana();
      

   
            Console.Read();
        }
    }
}
