using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestDay7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestDay7Tests.Model;
using FluentAssertions;
namespace UnitTestDay7.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void 透過Assert驗證參考型別()
        {
            //arrange
            Guid ID = Guid.NewGuid();
            var expected = new Member
            {
                ID = ID,
                Name = "Name"
            };

            //act
            var actual = new Member
            {
                ID = ID,
                Name = "Name"
            };

            //assert
            Assert.AreEqual(expected,actual);
        }

        [TestMethod]
        public void 透過Assert驗證參考型別2()
        {
            //arrange
            Guid ID = Guid.NewGuid();
            var expected = new Member
            {
                ID = ID,
                Name = "Name"
            };

            //act
            var actual = expected;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 透過FluentAssertions驗證參考型別()
        {
            //arrange
            Guid ID = Guid.NewGuid();
            var expected = new Member
            {
                ID = ID,
                Name = "Name"
            };

            //act
            var actual = new Member
            {
                ID = ID,
                Name = "Name"
            };

            //assert
            actual.ShouldBeEquivalentTo(expected);

        }

        [TestMethod]
        public void 透過FluentAssertions驗證不為Null()
        {
            //arrange
            
            //act
            var actual = new Member
            {
                ID = Guid.NewGuid(),
                Name = "Name"
            };

            //assert
            actual.Should().NotBeNull();
        }

        [TestMethod]
        public void 透過FluentAssertions驗證為Null()
        {
            //arrange

            //act
            Member actual = null;

            //assert
            actual.Should().BeNull();
        }

        [TestMethod]
        public void 透過FluentAssertions驗證數字()
        {
            //arrange

            //act
            int actual = 123;

            //assert
            actual.Should().Be(123);
        }

        [TestMethod]
        public void 透過FluentAssertions驗證趨近於()
        {
            //arrange
            var a = 1.3;
            var b = 0.1;
            //act
            double actual = a + b ;

            //assert
            //趨近於1.4 且如果誤差小於0.00001時視為一樣
            actual.Should().BeApproximately(1.4,0.00001);
        }

        [TestMethod]
        public void 透過FluentAssertions驗證升冪排序()
        {
            //arrange
            var parameter = new List<int> { 4, 7, 1, 3, 8 };
            //act
            var actual = parameter.OrderBy(x=>x);

            //assert
            actual.Should().BeInAscendingOrder();
        }

        [TestMethod]
        public void 透過FluentAssertions驗證降冪排序()
        {
            //arrange
            var parameter = new List<int> { 4, 7, 1, 3, 8 };
            //act
            var actual = parameter.OrderByDescending(x => x);

            //assert
            actual.Should().BeInDescendingOrder();
        }
    }
}