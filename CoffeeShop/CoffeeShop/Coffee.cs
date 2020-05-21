using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Coffee
    {
        public Coffee()
        {
            newlatte = 0.0;
            newcappu = 0.0;
            newespr = 0.0;
            newmochac = 0.0;
            newfilterCoff = 0.0;
            newirishCoff = 0.0;
            newflatCoff = 0.0;
            newaffogato = 0.0;

            newbbqBurg=0.0;
            newdelightBurg=0.0;
            newcrispyBurg=0.0;
            newclubSan=0.0;
            newcheeseSan=0.0;
            newchiFry=0.0;
            newnachos=0.0;
            newfreFries=0.0;
        }

        
        public Coffee(double latte_c, double cappu_c, double espr_c, double mochac_c, double filterCoff_c, 
            double irishCoff_c, double flatCoff_c, double affogato_c, double bbqBurg_o, double delightBurg_o, 
            double crispyBurg_o, double clubSan_o, double cheeseSan_o, double chiFry_o, double nachos_o, 
            double freFries_o)
        {
            newlatte = latte_c;
            newcappu = cappu_c;
            newespr = espr_c;
            newmochac = mochac_c;
            newfilterCoff = filterCoff_c;
            newirishCoff = irishCoff_c;
            newflatCoff = flatCoff_c;
            newaffogato = affogato_c;

            newbbqBurg = bbqBurg_o;
            newdelightBurg = delightBurg_o;
            newcrispyBurg = crispyBurg_o;
            newclubSan = clubSan_o;
            newcheeseSan = cheeseSan_o;
            newchiFry = chiFry_o;
            newnachos = nachos_o;
            newfreFries = freFries_o; 

        }

        public double getlatte_c() { return newlatte; }
        public double getcappu_c() { return newcappu; }
        public double getespr_c() { return newespr; }
        public double getmochac_c() { return newmochac; }
        public double getfilterCoff_c() { return newfilterCoff; }
        public double getirishCoff_c() { return newirishCoff; }
        public double getflatCoff_c() { return newflatCoff; }
        public double getaffogato_c() { return newaffogato; }
        public double getbbqBurg_o() { return newbbqBurg; }
        public double getdelightBurg_o() { return newdelightBurg; }
        public double getcrispyBurg_o() { return newcrispyBurg; }
        public double getclubSan_o() { return newclubSan; }
        public double getcheeseSan_o() { return newcheeseSan; }
        public double getchiFry_o() { return newchiFry; }
        public double getnachos_o() { return newnachos; }
        public double getfreFries_o() { return newfreFries; }

        //Member variables for Coffee
        private double newlatte;
        private double newcappu;
        private double newespr;
        private double newmochac;
        private double newfilterCoff;
        private double newirishCoff;
        private double newflatCoff;
        private double newaffogato;

        //Member variables for Others
        private double newbbqBurg;  
        private double newdelightBurg;
        private double newcrispyBurg;
        private double newclubSan;
        private double newcheeseSan;
        private double newchiFry;
        private double newnachos;
        private double newfreFries;
    }
}
