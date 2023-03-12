

namespace geometry_library
{
    public static class Triangle
    {
        /// <summary>
        /// returns Area of Triangle with 3 Sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns> double</returns>
        public static double AreaTriangleWith3Sides(double a, double b, double c)
        {
           double s = (a + b + c) / 2;

            double result = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return Math.Round(result, 2);
        }

        /// <summary>
        /// returns true if right angle triangle is right
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns> bool</returns>
        public static bool IsRightAngleTriangle(double a, double b, double c)
        {
            double[] numbers = {a,b,c };
            Array.Sort(numbers);
            Array.Reverse(numbers);

            double largestNumA = numbers[0];
            double numB = numbers[1];
            double numC = numbers[2];

            double largestNunA2 = Math.Pow(largestNumA,2);
            double numBC = Math.Pow(numB,2) + Math.Pow(numC,2);

            bool result = (largestNunA2 == numBC) ? true : false;
            return result;
        }
    }
}
