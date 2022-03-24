namespace CalculateSquare
{
    public class Triangle : Figure
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            c = Math.Abs(c);

            if (a + b > c && b + c > a && c + a > b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Figure not triangle");
            }

        }
        public override double Square()
        {
            double semiPerimeter = (A + B + C) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }
        public bool IsRectangular()
        {
            if (CheckByTheorem(A, B, C) || CheckByTheorem(B, C, A) || CheckByTheorem(C, A, B))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool CheckByTheorem(double a, double b, double c)
        {
            return Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2);
        }
    }
}
