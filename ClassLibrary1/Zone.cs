using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace ClassLibrary1
{

    public class Zone
    {

        Random rand = new Random();
        Maladie mal = new Maladie();
        public UInt64 habs = 0;
        public double indemne_pour = 0;
        public UInt64 habs_base = 1;
        public UInt64 nb_morts;
        public uint M_morts;
        public UInt64 nb_malades=0;
        public UInt64 malade_temp;
        public UInt64 nb_guéris=0;
        public double pourcentage;
        public double remede = 0;
        public string nom = "0";
        public int climat = 0;
        public Point[] hitbox = { new Point(0, 0) };
        public List<Zone> Voisins = new List<Zone>();
        public List<Zone> Voisins_mar = new List<Zone>();
        public List<string> cap = new List<string> { "premier","50%", "contamined", "termniné" };
        public bool frontiere = true;
        public string hemisphere = "nord";
        public string saison = "Printemps";
        public double taux_g, taux_c, taux_m = 0;

        public Zone(UInt64 a, string n, int c, string h)
        {
            habs = a;
            habs_base = habs;
            nom = n;
            climat = c;
            hemisphere = h;
            saison = "Automne";
        }

        public Zone(UInt64 a, string n, int c)
        {
            
            habs = a;
            habs_base = habs;
            nom = n;
            climat = c;
        }

        public Zone(UInt64 a, string n)
        {
            habs = a;
            habs_base = habs;
            nom = n;
        }

        public Zone(UInt64 a)
        {
            habs = a;
            habs_base = habs;
        }

        public string Nom_Climat()
        {
            switch (climat)
            {
                case 0:
                    return "Tempéré";
                case 1:
                    return "Tropical";
                case 2:
                    return "Equatorial";
                case -1:
                    return "Subarctique";
                case -2:
                    return "Polaire";
                default:
                    return "Général";

                

            }
        }

        public void Refresh_Tick(int d, DateTime date)
        {
            
            foreach (Zone v in Voisins)
            {
                if ((nb_malades == 0 && (v.pourcentage > 5 || v.nb_malades>1000000))) 
                {
                    if (rand.Next(10000) < v.pourcentage*20  )
                    {
                        nb_malades = 1;
                    }
                }
            }
            foreach (Zone v in Voisins_mar)
            {
                if (nb_malades == 0 && v.pourcentage > 40 && frontiere)
                {
                    if (rand.Next(1000000) < v.pourcentage * 10)
                    {
                        nb_malades = 1;
                    }
                }
            }



            uint raf = 10000; ///////// ///////

            malade_temp = nb_malades;
            if (nb_malades < raf)
            {
                for (uint i = 0; i < malade_temp; i++)
                {
                    if (rand.NextDouble() <= taux_c)
                    {
                        nb_malades += 1;
                    }
                }
            }
            else
            {
                for (uint i = 0; i < raf; i++)
                {
                    if (rand.NextDouble() <= taux_c)
                    {
                        nb_malades += Convert.ToUInt32(malade_temp / raf);
                    }
                }
            }





            for (uint i = 0; i < raf; i++)
            {
                if (rand.NextDouble() <= taux_m)
                {
                    nb_morts += nb_malades / raf;
                    nb_malades -= nb_malades / raf;
                }
            }

            habs = habs_base - nb_morts;

            for (uint i = 0; i < raf; i++)
            {
                if (rand.NextDouble() <= taux_g)
                {
                    nb_guéris += nb_malades / raf;
                    nb_malades -= nb_guéris / raf;
                }
            }




            

            if (nb_malades > habs-nb_guéris)
            {
                nb_malades = habs-nb_guéris;
                pourcentage = 100;
            }
            else pourcentage = (nb_malades * 1.0 / habs_base) * 100.0;

            

            
            habs = habs_base - nb_morts;


        }


        public void Refresh_Day(Maladie m, int d, DateTime date, double p)
        {
            taux_c = mal.Taux_Cont_Calc(this,p);
            taux_m = mal.Taux_Mort_Calc(this);
            taux_g = mal.Taux_Guer_Calc(this);

            if (hemisphere == "nord")
            {
                if (date.Day == 20 && date.Month == 6)
                {
                    saison = "Été";
                }
                if (date.Day == 22 && date.Month == 9)
                {
                    saison = "Automne";
                }
                if (date.Day == 21 && date.Month == 12)
                {
                    saison = "Hiver";
                }
                if (date.Day == 20 && date.Month == 3)
                {
                    saison = "Printemps";
                }
            }
            else
            {
                if (date.Day == 20 && date.Month == 6)
                {
                    saison = "Hiver";
                }
                if (date.Day == 22 && date.Month == 9)
                {
                    saison = "Printemps";
                }
                if (date.Day == 21 && date.Month == 12)
                {
                    saison = "Été";
                }
                if (date.Day == 20 && date.Month == 3)
                {
                    saison = "Automne";
                }
            }
        }

        


    };
}
