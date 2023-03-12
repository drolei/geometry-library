
using geometry_library;
using geometry_library.Models;
using Nancy.Json;

namespace TestGeometry.UnitTests
{
    [TestClass]
    public class UnknownFigureTests
    {
        [TestMethod]
        public void CalculateSomeArea_A3B6C7_ReturnsTriangleAnd8Dot94()
        {
            var unknownFigure = new UnknownFigure(3, 6, 7);

            var result = unknownFigure.CalculateSomeArea();

            var expectedResult = new Figure()
            {
                Sum = 8.94,
                FigureEnums = FigureEnum.Triangle
            };
            var js = new JavaScriptSerializer();


            Assert.AreEqual(js.Serialize(expectedResult), js.Serialize(result));
        }

        [TestMethod]
        public void CalculateSomeArea_A10_ReturnCircleAnd314Dot16()
        {
            var unknownFigure = new UnknownFigure(10);

            var result = unknownFigure.CalculateSomeArea();

            var expectedResult = new Figure()
            {
                Sum = 314.16,
                FigureEnums = FigureEnum.Circle
            };
            var js = new JavaScriptSerializer();


            Assert.AreEqual(js.Serialize(expectedResult), js.Serialize(result));
        }

    }

}
