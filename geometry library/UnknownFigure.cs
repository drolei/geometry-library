using geometry_library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry_library
{
    public class UnknownFigure
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;

        public UnknownFigure(double a) {
            this.a = a;
        }
        public UnknownFigure(double a, double b, double c) {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        ///  returns Area of Triangle with 3 Sides or
        ///  area of circle with radius
        /// </summary>
        /// <returns> class Figure</returns>
        public Figure CalculateSomeArea()
        {
            if (b == 0 && c == 0)
            {
                var sum = Circle.AreaCircleWithRadius(a);
                var result = new Figure()
                {
                    Sum = sum,
                    FigureEnums = FigureEnum.Circle
                };

                return result;
            }
            else {

                var sum = Triangle.AreaTriangleWith3Sides(a, b, c);
                var result = new Figure()
                {
                    Sum = sum,
                    FigureEnums = FigureEnum.Triangle
                };
                return result;
            }
        }
    }
}
