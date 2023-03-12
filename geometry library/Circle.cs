namespace geometry_library
{
    public static class Circle
    {   /// <summary>
        /// returns area of circle with radius
        /// </summary>
        /// <param name="radius"></param>
        /// <returns> double</returns>
        public static double AreaCircleWithRadius(double radius)
        {
            double p = 3.14159;
            double result = p * Math.Pow(radius,2);

            return Math.Round(result, 2);
        }

    }
}