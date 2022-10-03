using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3_interrupteur_lampe
{
    class ampoule
    {
        public string nom;
        public int watt;
        public string etat;
        public string onoff;

        public ampoule (string nom, int watt, string etat, string onoff)
        {
            this.nom = nom;
            this.watt = watt;
            this.etat = etat;
            this.onoff = onoff;
            Console.WriteLine("dans ampile - creation-" + this.nom, "-" ,+ this.watt);
        }
        public void allume()
        { this.onoff = "on";
            Console.WriteLine("dans ampile - creation-" + this.nom, "-" ,+ this.watt);

        }
        public void eteint()
        {
            this.onoff = "off";
            Console.WriteLine("dans ampile - creation-" + this.nom, "-", + this.watt);

        }

    }
}
