namespace ShapesLibrary
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public double Area()
        {
            double p = (_a + _b + _c) / 2;

            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightAngled()
        {
            return 
            Math.Pow(_a, 2) + Math.Pow(_b, 2) - Math.Pow(_c, 2) == 0 ||
            Math.Pow(_a, 2) + Math.Pow(_c, 2) - Math.Pow(_b, 2) == 0 ||
            Math.Pow(_b, 2) + Math.Pow(_c, 2) - Math.Pow(_a, 2) == 0;
        }
    }
}