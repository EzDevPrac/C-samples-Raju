using System;
using Xunit;

namespace LazyInitialization.Test
{
    public class LazyTest
    {

        [Fact]
        public void LazyTests()
        {
            Kill kill = new Kill();
            int expected = kill.KillEnemy();
            Assert.Equal(5, expected);

        }
    }
}
