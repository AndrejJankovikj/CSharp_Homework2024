using TimeTracking.Domain;

namespace TimeTracking.Repository.DataBase
{
    public class UserDb
    {
        public List<User> Users = new List<User>()
        {
            new User("Viktor","Zdravkovski",22,"Viktor123","Viktor123"),
            new User("Andrej","Jankovikj",42,"Janko123","Janko123"),
            new User("Dimitar","Vlahov",65,"Dimche123","Dimche123"),
            new User("Pero","Tosev",65,"Pero123","Pero123")
        };
    }
}
