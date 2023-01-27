namespace ShapesLibrary
{
    public static class AreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }
}