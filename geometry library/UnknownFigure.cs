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

        /// <summary>
        /// returns area of circle with radius
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public Figure CalculateSomeArea(double a)
        {

                var sum = Circle.AreaCircleWithRadius(a);
                var result = new Figure()
                {
                    Sum = sum,
                    FigureEnums = FigureEnum.Circle
                };

                return result;
            
        }

        /// <summary>
        /// returns Area of Triangle with 3 Sides
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public Figure CalculateSomeArea(double a, double b, double c)
        {

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
