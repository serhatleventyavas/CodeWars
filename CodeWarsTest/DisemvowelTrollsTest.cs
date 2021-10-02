using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class DisemvowelTrollsTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new DisemvowelTrolls();
            var result = sut.Disemvowel("This website is for losers LOL!");
            Assert.Equal("Ths wbst s fr lsrs LL!", result);
        }
    }
}