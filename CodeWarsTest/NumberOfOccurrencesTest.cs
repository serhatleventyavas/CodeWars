using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class NumberOfOccurrencesTest
    {

        [Fact]
        public void Test1()
        {
            var sut = new NumberOfOccurrences();
            var samples = new[]
            {
                1, 0, 2, 2, 3
            };
            var occurrencesCount = sut.FindOccurrencesCount(0, samples);
            Assert.Equal(1, occurrencesCount);
        }
        
        [Fact]
        public void Test2()
        {
            var sut = new NumberOfOccurrences();
            var samples = new[]
            {
                1, 0, 2, 2, 3
            };
            var occurrencesCount = sut.FindOccurrencesCount(4, samples);
            Assert.Equal(0, occurrencesCount);
        }
        
        [Fact]
        public void Test3()
        {
            var sut = new NumberOfOccurrences();
            var samples = new[]
            {
                1, 0, 2, 2, 3
            };
            var occurrencesCount = sut.FindOccurrencesCount(2, samples);
            Assert.Equal(2, occurrencesCount);
        }
        
        [Fact]
        public void Test4()
        {
            var sut = new NumberOfOccurrences();
            var samples = new[]
            {
                1, 0, 2, 2, 3
            };
            var occurrencesCount = sut.FindOccurrencesCount(3, samples);
            Assert.Equal(1, occurrencesCount);
        }
    }
}