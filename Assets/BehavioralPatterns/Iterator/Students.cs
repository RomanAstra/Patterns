using System.Linq;

namespace Iterator
{
    public sealed class Students
    {
        private User[] _users;

        public User[] GetUserForFemale()
        {
            return _users.Where(user => user.Gender == Gender.Male).ToArray();
        }
    }

    public class User
    {
        public Gender Gender;
    }

    public enum Gender
    {
        None   = 0,
        Male   = 1,
        Female = 2
    }
}
