using System.Collections.Generic;
using System.Linq;
using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class ListFilteringTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new ListFiltering();
            var result = sut.GetIntegersFromList(new List<object>
            {
                1,
                2,
                "a",
                "b"
            });
            Assert.Equal(new List<int>{1, 2}, result.ToList());
        }
        
        [Fact]
        public void Test2()
        {
            var sut = new ListFiltering();
            var result = sut.GetIntegersFromList(new List<object>
                {1, 2, "a", "b", 0, 15});
            Assert.Equal(new List<int>{1, 2, 0, 15}, result.ToList());
        }
        
        [Fact]
        public void Test3()
        {
            var sut = new ListFiltering();
            var result = sut.GetIntegersFromList(new List<object>
            {
                1, 2, "a", "b", "aasf", "1", "123", 231
            });
            Assert.Equal(new List<int>{1, 2, 231}, result.ToList());
        }
    }
}