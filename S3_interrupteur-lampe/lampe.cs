using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_interrupteur_lampe
{
    class lampe
    {
        string etat;
        ampoule ampoule1;
        ampoule ampoule2;
        ampoule ampoule3;
        ampoule ampoule4;

        static int nblampes = 0;

        //constructeur
        public lampe()
        {
            this.ampoule1 = new ampoule("ampoule1", 40, "bon", "off");
            this.ampoule2 = new ampoule("ampoule2", 60, "bon", "off");
            this.ampoule3 = new ampoule("ampoule3", 90, "bon", "off");
            this.ampoule4 = new ampoule("ampoule4", 30, "bon", "off");
            this.etat = "eteint";
            nblampes++;
            Console.WriteLine("const-lampe - nombre de lampes :" + nblampes);
            Console.WriteLine("const-lampe - etat :" + etat);
        }
        public lampe(string etat)
        {
            this.etat = "eteint";
            nblampes++;
            Console.WriteLine("const-lampe - nombre de lampes :" + nblampes);
            Console.WriteLine("const-lampe - etat :" + etat);
        }
        public void allume()
        {
            this.ampoule1.allume();
            this.ampoule2.allume();
            this.ampoule3.allume();
            this.ampoule4.allume();
            this.etat = "allumé";
            Console.WriteLine("allumage lampe");
        }
        public void eteint()
        {
            this.ampoule1.eteint();
            this.ampoule2.eteint();
            this.ampoule3.eteint();
            this.ampoule4.eteint();

            this.etat = "eteint";
            Console.WriteLine("on coupe la lampe");
        }


    }
    
}
