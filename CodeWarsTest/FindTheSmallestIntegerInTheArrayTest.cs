using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class FindTheSmallestIntegerInTheArrayTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[]
            {
                34, 15, 88, 2
            };
            var sut = new FindTheSmallestIntegerInTheArray();
            var result = sut.FindSmallestInt(array);
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void Test2()
        {
            var array = new[]
            {
                34, -345, -1, 100
            };
            var sut = new FindTheSmallestIntegerInTheArray();
            var result = sut.FindSmallestInt(array);
            Assert.Equal(-345, result);
        }
        
        [Fact]
        public void Test3()
        {
            var array = new[]
            {
                78,56,232,12,11,43
            };
            var sut = new FindTheSmallestIntegerInTheArray();
            var result = sut.FindSmallestInt(array);
            Assert.Equal(11, result);
        }
        
        [Fact]
        public void Test4()
        {
            var array = new[]
            {
                78,56,-2,12,8,-33
            };
            var sut = new FindTheSmallestIntegerInTheArray();
            var result = sut.FindSmallestInt(array);
            Assert.Equal(-33, result);
        }
    }
}