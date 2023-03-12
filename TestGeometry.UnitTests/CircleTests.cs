using geometry_library;

namespace TestGeometry.UnitTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void AreaCircleWithRadius_Radius10_Return314Dot16()
        {

           var result = Circle.AreaCircleWithRadius(10);

            Assert.AreEqual(314.16, result);
        }

        [TestMethod]
        public void AreaCircleWithRadius_Radius9999999Dot99_Return314158999371682()
        {

            var result = Circle.AreaCircleWithRadius(9999999.99);

            Assert.AreEqual(314158999371682, result);
        }

        [TestMethod]
        public void AreaCircleWithRadius_Radius0_Return0()
        {

            var result = Circle.AreaCircleWithRadius(0);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void AreaCircleWithRadius_RadiusMinus10_Return314Dot16()
        {
            var result = Circle.AreaCircleWithRadius(-10);

            Assert.AreEqual(314.16, result);
        }
    }
}