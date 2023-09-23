using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assisted12
{
    [TestFixture]
    public class TestClass2
    {
        [Test]
        public void StaticFack()
        {
            int x = 10, y = 20;
            var wrapper = new SCalcWrapper();
            Assert.That(wrapper.add(x, y), Is.EqualTo(x + y));
        }
    }
}