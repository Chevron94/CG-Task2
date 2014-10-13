using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Task2
{
    class Vector
    {

        public double X, Y, Z;
        public double W;
        public Vector Vcam;

        public Vector(double aX, double aY, double aZ, double aW)
        {
            X = aX;
            Y = aY;
            Z = aZ;
            W = aW;
            Vcam = null;
        }

        public Vector(double aX, double aY, double aZ)
        {
            X = aX;
            Y = aY;
            Z = aZ;
            W = 1;
            Vcam = null;
        }

        public Vector(Point pnt)
        {
            X = pnt.X;
            Y = pnt.Y;
            Z = 0;
            W = 1;
            Vcam = null;
        }

        public double getX()
        {
            return X / W;
        }

        public double getY()
        {
            return Y / W;
        }

        public double getZ()
        {
            return Z / W;
        }

        public double getW()
        {
            return W;
        }

        public void makeWone()
        {
            X = getX();
            Y = getY();
            Z = getZ();
            W = 1;
        }

        public double length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        public void Normalize()
        {
            double len = length;
            X = X / len;
            Y = Y / len;
            Z = Z / len;
        }

        /// <summary>
        /// Векторное произведение на вектор v2
        /// </summary>
        /// <param name="v2"></param>
        /// <returns></returns>
        public Vector getVectorMult(Vector v2)
        {
            double ax, ay, az;
            ax = getY() * v2.getZ() - getZ() * v2.getY();
            ay = getZ() * v2.getX() - getX() * v2.getZ();
            az = getX() * v2.getY() - getY() * v2.getX();
            return new Vector(ax, ay, az);
        }

        public Vector applyMatrix(Matrix matr)
        {
            Vector result = new Vector(0,0,0,0);
            double[] input = { X, Y, Z, W };
            //double[] output = { 0, 0, 0, 0 };
            for (int i = 0; i < 4; i++)
            {
                result.X += input[i] * matr.fields[i, 0];
                result.Y += input[i] * matr.fields[i, 1];
                result.Z += input[i] * matr.fields[i, 2];
                result.W += input[i] * matr.fields[i, 3];
            }
            return result;
        }

        /// <summary>
        /// Находит угол между двумя веторами
        /// </summary>
        /// <param name="v2"></param>
        /// <returns></returns>
        public double findAngle(Vector v2)
        {
            if (length == 0 || v2.length == 0)
                return 0;
            double cos=(getX()*v2.getX()+getY()*v2.getY()+getZ()*v2.getZ())/(length*v2.length);
            return Math.Acos(cos);
        }

        /// <summary>
        /// Считаем координаты точки относительно камеры
        /// </summary>
        /// <param name="cam"></param>
        public void rotateForCam(Camera cam)
        {
            Vcam = applyMatrix(cam.toRotate);
        }

        public Vector substract(Vector v2)
        {
            return new Vector(getX() - v2.getX(), getY() - v2.getY(), getZ() - v2.getZ());
        }

        public Vector add(Vector v2)
        {
            return new Vector(getX() + v2.getX(), getY() + v2.getY(), getZ() + v2.getZ());
        }

        public Vector scale(double zn)
        {
            return new Vector(getX() * zn, getY() * zn, getZ() * zn);
        }
    }
}
