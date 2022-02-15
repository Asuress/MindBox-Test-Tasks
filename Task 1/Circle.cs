namespace MindBox_Test_Tasks
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value < 0)
                {
                    _radius = 0;
                    return;
                }
                _radius = value;
            }
        }
        private double _area;
        public override double Area
        {
            get
            {
                return Radius * Radius * Constants.PI;
            }
        }
        public override double Perimeter
        {
            get
            {
                return 2 * Constants.PI * Radius;
            }
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}
