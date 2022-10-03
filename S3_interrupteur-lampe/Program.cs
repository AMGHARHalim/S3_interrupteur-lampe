using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_interrupteur_lampe
{
    class Program
    {
        static void Main(string[] args)
        {
            var living = new lampe();
            living.allume();
            living.eteint();
            

            var interrupteurliving = new interrupteur(living);
            Console.WriteLine("----------------------------------------");

            interrupteurliving.on();
            Console.WriteLine("------------------------------------");

            interrupteurliving.off();
            Console.WriteLine("------------------------------------");
            Console.ReadLine();

            var bureau = new lampe();
            var interrupteurbureau = new lampe();
        }
    }
}
