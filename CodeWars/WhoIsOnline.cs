using System;
using System.Collections.Generic;
using System.Linq;
namespace CodeWars
{
    // Reference:
    public enum UserStatus
    {
        Online,
        Offline,
        Away
    }

    public class User
    {
        public string Username;
        public UserStatus Status;
        public int LastActivity;
        public User(string username, UserStatus status, int lastActivity)
        {
            Username = username;
            Status = status;
            LastActivity = lastActivity;
        }
    }
    
    public class WhoIsOnline
    {
        public Dictionary<UserStatus, IEnumerable<string>> WhosOnline(User[] friends)
        {
            var dictionary = new Dictionary<UserStatus, IEnumerable<string>>();
            var onlineFriends = friends.Where(friend => friend.LastActivity <= 10 && friend.Status == UserStatus.Online).ToList();
            if (onlineFriends.Any())
            {
                dictionary.Add(UserStatus.Online, onlineFriends.Select(user => user.Username).ToList());
            }

            var offlineFriends = friends.Where(friend => friend.Status == UserStatus.Offline).ToList();
            if (offlineFriends.Any())
            {
                dictionary.Add(UserStatus.Offline, offlineFriends.Select(user => user.Username).ToList());
            }
            
            var awayFriends = friends.Where(friend => friend.Status == UserStatus.Away).ToList();
            if (awayFriends.Any())
            {
                dictionary.Add(UserStatus.Away, awayFriends.Select(user => user.Username).ToList());
            }
            
            awayFriends.AddRange(friends.Where(friend => friend.LastActivity > 10 && friend.Status == UserStatus.Online).ToList());
            if (awayFriends.Any())
            {
                dictionary.Add(UserStatus.Away, awayFriends.Select(user => user.Username).ToList());
            }
            return dictionary;
        }
    }
}