using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Task2
{
    class Polygon
    {

        Vector fv0, fv1, fv2;
        public Color color;

        public Polygon(Vector av0, Vector av1, Vector av2, Color aColor)
        {
            fv0 = av0;
            fv1 = av1;
            fv2 = av2;
            color = aColor;
        }

        public Vector v0
        {
            get { return fv0; }
        }

        public Vector v1
        {
            get { return fv1; }
        }

        public Vector v2
        {
            get { return fv2; }
        }

        /// <summary>
        /// возвращает вектор нормали для плоскости
        /// </summary>
        public Vector normal
        {
            get { return v1.substract(v0).getVectorMult(v2.substract(v0)); }
        }

        public Vector normalCam
        {
            get { return v1.Vcam.substract(v0.Vcam).getVectorMult(v2.Vcam.substract(v0.Vcam)); }
        }
    }
}
