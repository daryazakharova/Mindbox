using Mindbox;

namespace TestShape
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void AreaCircle_12_56_Raduis_2()
        {
            double radius = 2;
            double expencted = 12.56;

            Circle circle = new Circle(radius);
            double actual = circle.Area();

            Assert.AreEqual(expencted, actual);
        }
    }
}