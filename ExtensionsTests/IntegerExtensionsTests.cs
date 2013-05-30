using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SwissArmyKnife.Extensions;

namespace ExtensionsTests
{
    [TestFixture]
    public class IntegerExtensionsTests
    {
        [Test]
        public void Should_Tell_If_In_List()
        {
            const int index = 42;

            var container1 = new List<int> { 0, 1, 2, 42, 55, 64, 24, 4, 2 };
            var container2 = new List<int> { 0, 1, 2, 42, 42, 64, 24, 4, 2 };

            Assert.That(index.In(container1));
            Assert.That(index.In(container2));
        }
    }
}
