using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class LightPoint
    {

        Vector pos;
        public double intR, intG, intB;
        public double k1, k2, k3;

        public Vector Direction
        {
            get { return pos; }
            set { pos = value; }
        }

        public LightPoint(Vector apos, double aintR=1, double aintG=1, double aintB=1, double ak1=1, double ak2=0, double ak3=0)
        {
            pos = apos;
            intR = aintR;
            intG = aintG;
            intB = aintB;
            k1 = ak1;
            k2 = ak2;
            k3 = ak3;
        }

        public double calcIntensity(Vector v)
        {
            Vector buf = v.substract(pos);
            double len=buf.length;
            return 1.0/(k1+k2*len+k3*len*len);
        }
    }
}
