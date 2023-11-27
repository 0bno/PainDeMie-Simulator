using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Maladie
    {
        public int type = 0;
        public string nom = "0";
        public string nom_maladie = "";
        public bool equa, trop, suba, pola = false;
        public bool temp = true;
        public bool toux = true;
        public bool fiev, vomi, diar, parano, dii, 
            erup, hemo, paraly, foli, coma, necr, orga = false;
        public double taux_cont = 1;
        public double taux_mort = 0;
        public double taux_guér = 0;
        public float taux_guer;
        public void Init()
        {
            switch (type)
            {
                case 1:
                    nom_maladie = "Virus";
                    break;
                case 2:
                    nom_maladie = "Bactérie";
                    break;
                case 3:
                    nom_maladie = "Ver";
                    break;
                default:
                    break;
            }


        }
        public double Taux_Cont_Calc(Zone z, double p)
        {
            taux_cont = 1;

            if (z.saison == "Hiver") taux_cont -= 0.04;
            else if(z.saison == "Été") taux_cont += 0.04;

            if (p > 80) taux_cont -= 0.1;
            else if (p > 60) taux_cont -= 0.075;
            else if (p > 40) taux_cont -= 0.05;
            else if (p > 20) taux_cont -= 0.025;
            



            switch (z.climat)
            {
                case 0:
                    if (temp)
                    {
                        taux_cont += 30.03;
                    }break;
                case 1:
                    if (trop)
                    {
                        taux_cont += 0.03;
                    }
                    break;
                case 2:
                    if (equa)
                    {
                        taux_cont += 0.03;
                        
                    }
                    break;
                case -1:
                    if (suba)
                    {
                        taux_cont += 0.03;
                    }
                    break;
                case -2:
                    if (pola)
                    {
                        taux_cont += 0.03;
                    }
                    break;
                default:
                    break;
            }

            if (z.pourcentage <= 2)
            {
                return 0.015 * taux_cont;
            }
            else if(z.pourcentage <=15)
            {
                return 0.010 * taux_cont;
            }
            else if (z.pourcentage <= 25)
            {
                return 0.005 * taux_cont;
            }
            else if (z.pourcentage <= 40)
            {
                return 0.003 * taux_cont;
            }
            else if (z.pourcentage <= 60)
            {
                return 0.002 * taux_cont;
            }
            else if (z.pourcentage <= 60)
            {
                return 0.0008 * taux_cont;
            }
            else if (z.pourcentage <= 90)
            {
                return 0.0005 * taux_cont;
            }
            else
            {
                return 0.0002 * taux_cont;
            }
            
        }
        public double Taux_Mort_Calc(Zone z)
        {
            taux_mort = 0;
            /*if (symptome.Contains("Difficultés respiratoires")) taux_mort += 0.00001;
            if (symptome.Contains("Hémoragies")) taux_mort += 0.00001;
            if (symptome.Contains("Paralysie")) taux_mort += 0.00001;
            if (symptome.Contains("Folie")) taux_mort += 0.00001;
            if (symptome.Contains("Coma")) taux_mort += 0.00003;
            if (symptome.Contains("Nécrose")) taux_mort += 0.00005;
            if (symptome.Contains("Arrêt des Organes")) taux_mort += 0.0001;*/
            if (coma) taux_mort += 0.001;



            return taux_mort;
        }
        public double Taux_Guer_Calc(Zone z)
        {

            taux_guér = 0;
            return taux_guér;
        }
    }
}
