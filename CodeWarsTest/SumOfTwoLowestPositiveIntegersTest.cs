using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class SumOfTwoLowestPositiveIntegersTest
    {
        [Fact]
        public void Test1()
        {
            int[] numbers =  { 19, 5, 42, 2, 77 };
            var sut = new SumOfTwoLowestPositiveIntegers();
            var result = sut.SumTwoSmallestNumbers(numbers);
            Assert.Equal(7, result);
        }
        
        [Fact]
        public void Test2()
        {
            int[] numbers = {5, 8, 12, 19, 22};
            var sut = new SumOfTwoLowestPositiveIntegers();
            var result = sut.SumTwoSmallestNumbers(numbers);
            Assert.Equal(13, result);
        }
    }
}

