using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class SumOfAllTheMultiples3Or5Test
    {
        [Fact]
        public void Test1()
        {
            var sut = new SumOfAllTheMultiples3Or5();
            var result = sut.FindSum(5);
            Assert.Equal(8, result);
        }
        
        [Fact]
        public void Test2()
        {
            var sut = new SumOfAllTheMultiples3Or5();
            var result = sut.FindSum(10);
            Assert.Equal(33, result);
        }
    }
}