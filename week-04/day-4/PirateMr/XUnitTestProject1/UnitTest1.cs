using System;
using Xunit;
using PirateMr;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        private Pirate pirate;

        public UnitTest1()
        {
            pirate = new Pirate();
        }


        [Fact]
        void Test1()
        {
            Assert.Equal(10, pirate.HP);
        }
        [Fact]
        void TestLoop()
        {
            for (int i = 0; i < 11; i++)
            {

            }
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 3)]
        [InlineData(3, 3)]
        void NonLeathalDamage(int damage, int times)
        {
            var originalHp = pirate.HP;
            for (int i = 0; i < times; i++)
            {
                pirate.GotHit(damage);
            }


            Assert.True(pirate.HP > 0);
            Assert.Equal(pirate.HP, originalHp - damage * times);
            Assert.False(pirate.IsDead);
        }
    }
}
