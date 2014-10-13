using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Camera
    {
        Vector fpos; //позиция камеры
        Vector fdirection;  //направление камеры
        double fangle; //угол обзора камеры в радианах
        public Matrix toRotate;

        public Camera(Vector apos, Vector adirection, double aangle)
        {
            fpos = apos;
            fdirection = adirection;
            if (direction.length == 0)
            {
                direction.applyMatrix(Matrix.getShiftMatr(0, 0, 1)); //если вектор направления нулевой, то мы его в сторону оси z направляем
            }
            fangle = (aangle / 360) * 2 * Math.PI; //переводим угол обзора из градусов в радианы
            calcMatrixToRotate();
        }

        public double angle
        {
            get { return fangle; }
        }

        public Vector pos
        {
            get { return fpos; }
        }

        public Vector direction
        {
            get { return fdirection; }
        }

        /// <summary>
        /// Процедура высчитывает матрицу преобразования координатных осей так, чтобы ось Z смотрела в направлении камеры
        /// </summary>
        void calcMatrixToRotate()
        {
            //берем проекцию на ось XOY, поворачиваем так, чтобы ось Y смотрела в ту же сторону
            //далее поворачиваем по оси X так, чтобы Z совпала с направлением камеры
            //матрица=переместили,повернули, повернули
            Matrix shift = Matrix.getShiftMatr(-pos.getX(), -pos.getY(), -pos.getZ());
            Vector proj = new Vector(direction.getX(), direction.getY(), 0);
            double ang = proj.findAngle(new Vector(0, 1, 0));
            if (proj.getX() < 0)
                ang = -ang;
            Matrix rotZ = Matrix.getRorateZMatr(ang); //так как поворот идет против часовой стрелки
            Matrix rotX = Matrix.getRorateXMatr(direction.findAngle(new Vector(0, 0, 1))); //а это матрица поворота, чтобы Z совпало с направлением камеры
            toRotate = shift.mulMatrs(rotZ.mulMatrs(rotX));
        }
    }
}
