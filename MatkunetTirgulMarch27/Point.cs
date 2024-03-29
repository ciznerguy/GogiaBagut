using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatkunetTirgulMarch27
{
    internal class Point
    {
        private double x;
        private double y;

        public Point (double x, double y)
        {
            this.x = x;
            this.y = y;
        }   
        public double GetX()
        {
            return x;
        }
        public double GetY()
        {
            return y;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }

        public double Distance(Point other)
        {
            return x + y;
        }
    }
}
