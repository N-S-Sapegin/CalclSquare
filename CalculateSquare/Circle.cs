namespace CalculateSquare
{
    public class Circle : Figure
    {
        double radius;
        double Radius
        {
            get { return radius; }
            set { radius = Math.Abs(value); }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Square()
        {
            return radius == 0 ? 0 : Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
