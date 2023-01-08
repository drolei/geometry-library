namespace geometry_library
{
    public static class Circle
    {
        public static double AreaCircleWithDiameter(double radius)
        {
            double p = 3.14159;
            double result = p * Math.Pow(radius,2);

            return Math.Round(result, 2);
        }

    }
}