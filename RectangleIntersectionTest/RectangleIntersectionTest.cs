using NUnit.Framework;
using RectangleIntersection;

namespace RectangleIntersectionTest
{
    [TestFixture]
    public class RectangleIntersectionTest
    {
        [Test]
        public void TestIntersection()
        {
            int area = RectangleIntersect.Solution(0, 2, 5, 10, 3, 1, 20, 15);
            Assert.AreEqual(area, 16);
        }
    }
}
