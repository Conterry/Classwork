using System;

namespace Struct_Exx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vectoor Co1 = new Vectoor(2, 4);
            Vectoor Co2 = new Vectoor(3, 6);
        }
    }

    struct Vectoor
    {
        private int X;
        private int Y;

        public Vectoor(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vectoor operator -(Vectoor a, Vectoor b)
        {

        }
    }
}
