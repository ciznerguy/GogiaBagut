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

        // החזרת מונה
        public int GetNumerator()
        {
            return x;
        }

        // החזרת מכנה
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

        public void Add(Rational other)
        {
            if (this.y == other.y)
            {
                // If denominators are equal, just add the numerators.
                this.x += other.x;
            }
            else
            {
                // If denominators are different, cross-multiply to add the fractions.
                this.x = this.x * other.y + other.x * this.y;
                this.y = this.y * other.y;
            }
        }


        public void Simplify()
        {
            int gcd = GreatestCommonDivisor(x, y);
            x /= gcd;
            y /= gcd;

            // If the result can be a whole number, adjust the fraction.
          
        }

        private int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public bool IsLargerThan(Rational other)
        {
            // Compare by cross-multiplication to avoid floating-point inaccuracies.
            return this.x * other.y > other.x * this.y;
        }

        public override string ToString()
        {
            int wholePart = x / y; // This calculates the whole number part.
            int fractionalNumerator = x % y; // This calculates the fractional part's numerator.

            if (wholePart > 0 && fractionalNumerator > 0)
            {
                // If there is both a whole number and a fractional part, format as "wholePart fractionalPart".
                return $"{wholePart} {fractionalNumerator}/{y}";
            }
            else if (wholePart > 0)
            {
                // If the fraction simplifies to a whole number, return just the whole number.
                return $"{wholePart}";
            }
            else
            {
                // If there is no whole number part, return the fraction.
                return $"{fractionalNumerator}/{y}";
            }
        }




    }
}
