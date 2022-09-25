using Mindbox;

namespace TestShape
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void AreaTriangle_6_Side_3_4_5()
        {
            double sideAB = 3;
            double sideBC = 4;
            double sideAC = 5;
            double expencted = 6;

            Triangle areaTriangle = new Triangle(3, 4, 5);
            double actual = areaTriangle.Area();

            Assert.AreEqual(expencted, actual);
        }
    }
}
