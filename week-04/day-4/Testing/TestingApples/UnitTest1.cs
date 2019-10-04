using System;
using Xunit;
using Testing;
using System.Collections.Generic;

namespace TestingApples
{
    public class TestForApples
    {
        [Fact]
        public void DoIGetApples()
        {
            Apple iPhone = new Apple();
            Assert.Equal("Apple", iPhone.GetApple());
        }
    }
    public class TestForSumClass
    {
        List<int> oneElementList = new List<int> { 5 };
        List<int> multipleElementList = new List<int> { 4, 8, 15, 16, 23, 42 };
        List<int> nullList = null;

        [Fact]
        public void SumTestOne()
        {
            Assert.Equal(0, Sum.SumItUp(Program.emptyList));
        }
        [Fact]
        public void SumTestTwo()
        {
            Assert.Equal(5, Sum.SumItUp(oneElementList));
        }
        [Fact]
        public void SumTestThree()
        {
            Assert.Equal(108, Sum.SumItUp(multipleElementList));
        }
        [Fact]
        public void SumTestFour()
        {
            Assert.Equal(, Sum.SumItUp(nullList));
        }




    }
}
