using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Task2
{
    class Viewport
    {
        public Color brush;
        public Bitmap pic;
        public int height, width;
        public Camera cam;
        double del; //понадобится для того, чтобы пересчитывать трехмерные координаты в двумерные на экране
        public List<Vector> verts;
        public List<Polygon> polys;
        public LightPoint lightPoint;
        double[,] dep;

        public Viewport(int _height, int _width, Camera _camera, LightPoint _light, double par_length, double par_width, double par_height, double pyram1_h, double pyram2_h, Color Color)
        {
            height = _height;
            width = _width;
            brush = Color;
            pic = new Bitmap(this.width, this.height);
            verts = new List<Vector>();
            polys = new List<Polygon>();
            cam = _camera;
            del = 1 / Math.Tan(cam.angle / 2);
            lightPoint = _light;
            addBox(par_length, par_width, par_height, pyram1_h, pyram2_h);
        }

        public void addBox(double ax, double ay, double az, double h1, double h2)
        {
            int first = verts.Count;
            verts.Add(new Vector(0, 0, az));
            verts.Add(new Vector(0, ay, az));
            verts.Add(new Vector(ax, ay, az));
            verts.Add(new Vector(ax, 0, az));
            verts.Add(new Vector(0, 0, 0));
            verts.Add(new Vector(0, ay, 0));
            verts.Add(new Vector(ax, ay, 0));
            verts.Add(new Vector(ax, 0, 0));
            verts.Add(new Vector(-h1, ay/2, az/2));
            verts.Add(new Vector(ax+h2, ay/2, az/2));

            polys.Add(new Polygon(verts[8 + first], verts[0 + first], verts[1 + first], brush));
            polys.Add(new Polygon(verts[8 + first], verts[4 + first], verts[5 + first], brush));
            polys.Add(new Polygon(verts[8 + first], verts[4 + first], verts[0 + first], brush));
            polys.Add(new Polygon(verts[8 + first], verts[5 + first], verts[1 + first], brush));

            polys.Add(new Polygon(verts[9 + first], verts[2 + first], verts[3 + first], brush));
            polys.Add(new Polygon(verts[9 + first], verts[3 + first], verts[7 + first], brush));
            polys.Add(new Polygon(verts[9 + first], verts[6 + first], verts[7 + first], brush));
            polys.Add(new Polygon(verts[9 + first], verts[2 + first], verts[6 + first], brush));


            polys.Add(new Polygon(verts[5 + first], verts[4 + first], verts[0 + first], brush));
            polys.Add(new Polygon(verts[0 + first], verts[1 + first], verts[5 + first], brush));

            polys.Add(new Polygon(verts[0 + first], verts[4 + first], verts[7 + first], brush));
            polys.Add(new Polygon(verts[7 + first], verts[3 + first], verts[0 + first], brush));

            polys.Add(new Polygon(verts[7 + first], verts[4 + first], verts[5 + first], brush));
            polys.Add(new Polygon(verts[7 + first], verts[5 + first], verts[6 + first], brush));

            polys.Add(new Polygon(verts[2 + first], verts[1 + first], verts[0 + first], brush));
            polys.Add(new Polygon(verts[0 + first], verts[3 + first], verts[2 + first], brush));

            polys.Add(new Polygon(verts[2 + first], verts[3 + first], verts[7 + first], brush));
            polys.Add(new Polygon(verts[2 + first], verts[7 + first], verts[6 + first], brush));

            polys.Add(new Polygon(verts[1 + first], verts[2 + first], verts[5 + first], brush));
            polys.Add(new Polygon(verts[2 + first], verts[6 + first], verts[5 + first], brush));
        }

        public Point convertToScreenPoint(Vector v)
        {
            Point result = new Point();
            result.X = (int)Math.Round(v.Vcam.getX() / v.Vcam.getZ() * del * (double)width / 2 + (double)width / 2); //преобразовываем в координаты экрана
            result.Y = (int)Math.Round(v.Vcam.getY() / v.Vcam.getZ() * del * (double)width / 2 + (double)height / 2);
            return result;
        }

        public bool InScreen(Point p)
        {
            if (p.X < 0 || p.Y < 0)
                return false;

            if (p.X >= width || p.Y >= height)
                return false;

            return true;
        }

        /// <summary>
        /// проверяет, находится ли точка в треугольнике или нет
        /// </summary>
        /// <param name="pnt"></param>
        /// <param name="pnts"></param>
        /// <returns></returns>
        public bool CheckPoint(Point pnt, List<Point> pnts)
        {
            Vector v0, v1, v2;
            v0 = new Vector(pnt).substract(new Vector(pnts[0]));
            v1 = new Vector(pnts[1]).substract(new Vector(pnts[0]));
            v2 = new Vector(pnts[2]).substract(new Vector(pnts[0]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            v0 = new Vector(pnt).substract(new Vector(pnts[1]));
            v1 = new Vector(pnts[0]).substract(new Vector(pnts[1]));
            v2 = new Vector(pnts[2]).substract(new Vector(pnts[1]));
            if (Math.Abs(v2.findAngle(v1) - v2.findAngle(v0) - v1.findAngle(v0)) > 1e-3)
                return false;

            return true;
        }

        /// <summary>
        /// Находит точку на грани, которая смотрит в заданную точку на экране
        /// </summary>
        /// <param name="pnt"></param>
        /// <param name="poly"></param>
        /// <returns></returns>
        public Vector findVector(Point pnt, Polygon poly)
        {
            Vector onScreen = new Vector(0, 0, 1);
            double zn = (pnt.X - (double)width / 2) / (del * (double)width / 2);
            onScreen.X = zn;
            zn = (pnt.Y - (double)height / 2) / (del * (double)width / 2);
            onScreen.Y = zn;

            Vector norm = poly.normalCam;
            double A, B, C, D;
            A = norm.X;
            B = norm.Y;
            C = norm.Z;
            D = -(A * poly.v0.Vcam.getX() + B * poly.v0.Vcam.getY() + C * poly.v0.Vcam.getZ());

            double t = -D / (A * onScreen.getX() + B * onScreen.getY() + C * onScreen.getZ());
            return onScreen.scale(t);
        }

        public Color calcColor(Vector curV, Polygon poly)
        {
            double R, G, B;
            R = G = B = 0;

            double curR, curG, curB;

            curR = curG = curB = 0;

            Vector norm = poly.normalCam;
            Vector ray = lightPoint.pos.Vcam.substract(curV); //от точки до источника освещения
            if (ray.findAngle(norm) < Math.PI / 2)
            {
                double cos = Math.Cos(ray.findAngle(norm));
                double intens = lightPoint.calcIntensity(curV);
                cos = Math.Pow(cos, 0.5);
                curR += cos * intens * lightPoint.intR * poly.color.R;
                curG += cos * intens * lightPoint.intG * poly.color.G;
                curB += cos * intens * lightPoint.intB * poly.color.B;
            }
            R += curR;
            G += curG;
            B += curB;

            return Color.FromArgb(Math.Min((int)R, 255), Math.Min((int)G, 255), Math.Min((int)B, 255));
        }

        /// <summary>
        /// рисует полигон на экране
        /// </summary>
        /// <param name="poly"></param>
        public void DrawPolygon(Polygon poly)
        {
            List<Point> pnts = new List<Point>();
            pnts.Add(convertToScreenPoint(poly.v0));
            pnts.Add(convertToScreenPoint(poly.v1));
            pnts.Add(convertToScreenPoint(poly.v2));

            int minX, minY, maxX, maxY;
            minX = maxX = pnts[0].X;
            minY = maxY = pnts[0].Y;
            foreach (Point pnt in pnts)
            {
                minX = Math.Min(minX, pnt.X);
                maxX = Math.Max(maxX, pnt.X);
                minY = Math.Min(minY, pnt.Y);
                maxY = Math.Max(maxY, pnt.Y);
            }
            minX = Math.Max(minX, 0);
            minY = Math.Max(minY, 0);
            maxX = Math.Min(maxX, width - 1);
            maxY = Math.Min(maxY, height - 1);
            for (int X = minX; X <= maxX; X++)
                for (int Y = minY; Y <= maxY; Y++)
                {
                    Point curp = new Point(X, Y);
                    if (CheckPoint(curp, pnts))
                    {
                        Vector curV = findVector(curp, poly);
                        if (curV.getZ() < dep[X, Y])
                        {
                            dep[X, Y] = curV.getZ();
                            pic.SetPixel(X, Y, calcColor(curV, poly));
                        }
                    }
                }
        }

        public void Render()
        {
            if (cam != null)
            {
                //просчитываем относительные координаты для камеры
                foreach (Vector vr in verts)
                    vr.rotateForCam(cam);
                lightPoint.pos.rotateForCam(cam);
                Graphics gr = Graphics.FromImage(pic);
                gr.Clear(Color.White);
                dep = new double[width, height];
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < height; j++)
                        dep[i, j] = 10000;  //устанавливаем линию горизонта

                foreach (Polygon pl in polys)
                    if (pl.v0.substract(cam.pos).findAngle(pl.normal) > Math.PI / 2)  //если плоскость смотрит в сторону камеры
                        if (pl.v0.Vcam.getZ() > 0.2 && pl.v1.Vcam.getZ() > 0.2 && pl.v2.Vcam.getZ() > 0.2) //и если она не лежит за ней
                            DrawPolygon(pl);

            }
        }
    }
}
