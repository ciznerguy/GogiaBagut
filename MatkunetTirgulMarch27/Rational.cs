using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatkunetTirgulMarch27
{
    public class Rational
    {
        private int x;//מונה
        private int y;// מכנה

        public Rational(int x, int y)  // לא יכול להיות 0
        {
            this.x = x;
            this.y = y;
        }
        public int GetNumerator()
        {
            return x;
        }
        public int GetDenom()
        {
            return y;
        }

        public void SetX(int x)
        {
            this.x = x;
        }
        public void SetY(int y)
        {
            this.y = y;
        }
        
    }
}
