using System;

namespace Struct_Ex
{
    class Program
    {
            static void Main(string[] args)
            {
                FractionExample();
            }

            static void FractionExample()
            {
                Fraction x = new Fraction(1, 2);
                Fraction y = new Fraction(1, 3);

                //Fraction z = new Fraction(0, 0);

                Fraction sum = x + y;

                Console.WriteLine(sum);
                Console.WriteLine(sum.ToString());
                var d = sum + 2; // implicit
                Console.WriteLine(d);

                int holePart = (int)sum;
            }
    }
    struct Fraction
    {
        private int Enumerator;
        private int Denomerator;

        public Fraction(int Enumerator, int Denomerator)
        {
            if (Denomerator == 0)
                throw new ArgumentOutOfRangeException("denom. cannot be zero");

            if (Denomerator < 0)
            {
                Denomerator *= -1;
                Enumerator *= -1;
            }

            this.Enumerator = Enumerator;
            this.Denomerator = Denomerator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result;
            result.Enumerator = a.Enumerator * b.Denomerator + a.Denomerator * b.Enumerator;
            result.Denomerator = a.Denomerator * b.Denomerator;
            return result;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction result;
            result.Enumerator = a.Enumerator * b.Denomerator - a.Denomerator * b.Enumerator;
            result.Denomerator = a.Denomerator * b.Denomerator;
            return result;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction result;
            result.Enumerator = a.Enumerator * b.Denomerator;
            result.Denomerator = a.Denomerator * b.Enumerator;
            return result;
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result;
            result.Enumerator = a.Enumerator * b.Enumerator;
            result.Denomerator = a.Denomerator * b.Denomerator;
            return result;
        }

        // * - /

        public override string ToString()
        {
            return $"{Enumerator}/{Denomerator}";
        }

        public static implicit operator double(Fraction f)
        {
            return ((double)(f.Enumerator)) / f.Denomerator;
        }

        public static explicit operator int(Fraction f)
        {
            return f.Enumerator / f.Denomerator;
        }
    }
}
