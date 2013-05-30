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
    public class DateTimeExtensionsTests
    {
        [Test]
        public void ShouldBringDateToCurrentDayMidnight()
        {
            var aDate = new DateTime(2013, 05, 25, 13, 15, 00);

            var thisMidnight = aDate.ToMidnight();

            Assert.That(thisMidnight.Day,Is.EqualTo(aDate.Day));
            Assert.That(thisMidnight.Month, Is.EqualTo(aDate.Month));
            Assert.That(thisMidnight.Year, Is.EqualTo(aDate.Year));

            Assert.That(thisMidnight.Hour, Is.EqualTo(0));
            Assert.That(thisMidnight.Minute, Is.EqualTo(0));
            Assert.That(thisMidnight.Second, Is.EqualTo(0));
        }
    }
}
