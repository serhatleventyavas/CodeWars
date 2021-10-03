using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class DirectionsReductionTest
    {
        [Fact]
        public void Test1()
        {
            string[] directions = {"NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST"};
            string[] expected = {"WEST"};

            var sut = new DirectionsReduction();
            var result = sut.DirReduc(directions);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test2()
        {
            string[] directions = {"NORTH", "WEST", "SOUTH", "EAST"};
            string[] expected = {"NORTH", "WEST", "SOUTH", "EAST"};
            var sut = new DirectionsReduction();
            var result = sut.DirReduc(directions);
            Assert.Equal(expected, result);
        }
    }
}