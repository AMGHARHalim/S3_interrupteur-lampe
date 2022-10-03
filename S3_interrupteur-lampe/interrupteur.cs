using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_interrupteur_lampe
{
    class interrupteur
    {
        lampe lampeallumer;
        string onoff;
        public interrupteur(lampe lampefournie)
        {
            this.lampeallumer = lampefournie;
            onoff = "off";

        }
        public void on()
        {
            onoff = "on";
            this.lampeallumer.allume();
            Console.WriteLine("interrepteur-allume la lampe : ");

        }
        public void off()
        {
            onoff = "off";
            this.lampeallumer.eteint();
            Console.WriteLine("interrepteur-eteint la lampe : ");

        }
    }
}
