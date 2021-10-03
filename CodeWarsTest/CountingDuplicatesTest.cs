using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class CountingDuplicatesTest
    {

        [Fact]
        public void Test1()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("");
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Test2()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("abcde");
            Assert.Equal(0, result);
        }
        
        [Fact]
        public void Test3()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("aabbcde");
            Assert.Equal(2, result);
        }
        
        [Fact]
        public void Test4()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("aabBcde");
            Assert.Equal(2, result);   
        }
        
        [Fact]
        public void Test5()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("Indivisibility");
            Assert.Equal(1, result);
        }
        
        [Fact]
        public void Test6()
        {
            var sut = new CountingDuplicates();
            var result = sut.DuplicateCount("Indivisibilities");
            Assert.Equal(2, result);
        }
    }
}