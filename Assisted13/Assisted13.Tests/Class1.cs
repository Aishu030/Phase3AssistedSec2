using System;
using Assisted13;
using Moq;
using NUnit.Framework;

namespace DynamicFakesTest
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void DynamicFake()
        {
            int x = 10, y = 20;
            Mock<IDynamicCalc> mockCalc = new Mock<IDynamicCalc>();
            var result = new
            {
                V = Convert.ToInt32(x + y)
            };
            mockCalc.Setup(c => c.add(It.IsAny<object>(), It.IsAny<object>())).Returns(result);
        }

    }
}