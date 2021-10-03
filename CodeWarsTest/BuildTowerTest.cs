using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class BuildTowerTest
    {
        [Fact]
        public void Test1()
        {
            var sut = new BuildTower();
            var result = sut.TowerBuilder(1);
            Assert.Equal(new[] { "*" }, result);
        }
        
        [Fact]
        public void Test2()
        {
            var sut = new BuildTower();
            var result = sut.TowerBuilder(3);
            Assert.Equal(new[]
            {
                "  *  ", 
                " *** ", 
                "*****"
            }, result);
        }
        
        [Fact]
        public void Test3()
        {
            var sut = new BuildTower();
            var result = sut.TowerBuilder(4);
            Assert.Equal(new[]
            {
                "   *   ", 
                "  ***  ", 
                " ***** ",
                "*******"
            }, result);
        }
    }
}