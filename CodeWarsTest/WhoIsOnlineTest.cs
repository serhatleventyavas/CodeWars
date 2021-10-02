using System.Collections.Generic;
using CodeWars;
using Xunit;
namespace CodeWarsTest
{
    public class WhoIsOnlineTest
    {
        private User[] _users =
        {
            new User("David", UserStatus.Online, 10),
            new User("Lucy", UserStatus.Offline, 22),
            new User("Bob", UserStatus.Online, 104)
        };

        [Fact]
        public void Test1()
        {
            var sut = new WhoIsOnline();
            var result = sut.WhosOnline(_users);
            var expected = new Dictionary<UserStatus, IEnumerable<string>>
            {
                {UserStatus.Online, new[] {"David"}},
                {UserStatus.Offline, new[] {"Lucy"}},
                {UserStatus.Away, new[] {"Bob"}}
            };
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void Test2()
        {
            var friends = new[] 
            {
                new User("Lucy", UserStatus.Offline, 22),
                new User("Bob", UserStatus.Online, 104)
            };
            var sut = new WhoIsOnline();
            var result = sut.WhosOnline(friends);
            var expected = new Dictionary<UserStatus, IEnumerable<string>>
            {
                {UserStatus.Offline, new[] {"Lucy"}},
                {UserStatus.Away, new[] {"Bob"}}
            };
            Assert.Equal(expected, result);
        }
    }
}