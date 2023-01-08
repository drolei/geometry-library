using geometry_library;

namespace TestGeometry.UnitTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void AreaTriangleWith3Sides_A3B6C7_Return8Dot94()
        {
            var result = Triangle.AreaTriangleWith3Sides(3,6,7);

            Assert.AreEqual(8.94, result);
        }

        [TestMethod]
        public void AreaTriangleWith3Sides_A0B0C0_Return0()
        {
            var result = Triangle.AreaTriangleWith3Sides(0,0,0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void IsRightAngleTriangle_TriangleIsRightAngle_ReturnTrue()
        {
            var result = Triangle.IsRightAngleTriangle(3,5,4);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsRightAngleTriangle_TriangleIsNotRightAngle_ReturnFalse()
        {
            var result = Triangle.IsRightAngleTriangle(3, 5, 0);

            Assert.IsFalse(result);
        }
    }
}
