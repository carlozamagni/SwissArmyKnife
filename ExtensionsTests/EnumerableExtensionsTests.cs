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
    public class EnumerableExtensionsTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void Should_Detect_If_Null_Or_Empty()
        {
            List<int> nullList = null;
            List<int> emptyList = new List<int>();
            List<int> notNullNorEmptyList = new List<int> {0, 1, 2, 3};

            Assert.That(nullList.IsNullOrEmpty());
            Assert.That(emptyList.IsNullOrEmpty());

            Assert.That(notNullNorEmptyList.IsNullOrEmpty(), Is.False);
        }

        //[Test]
        //public void Should_Shuffle_List()
        //{
        //    var baseList = new List<int> { 0, 1, 2, 3 };
            
        //    var subjectList = new List<int> { 0, 1, 2, 3 };
        //    subjectList.Shuffle();

        //}
    }
}
