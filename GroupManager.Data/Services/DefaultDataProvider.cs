using GroupManager.Data.Models;
using GroupManager.Data.Services.Interfaces;

namespace GroupManager.Data.Services
{
    public sealed class DefaultDataProvider : IDataProvider
    {
        public ICollection<Group> GetGroups()
        {
            return new List<Group>()
            {
                new Group() { Id = 1, Name = "Grupa 1" },
                new Group() { Id = 2, Name = "Grupa 2" },
                new Group() { Id = 3, Name = "Grupa 3" },
                new Group() { Id = 4, Name = "Grupa 4" },
                new Group() { Id = 5, Name = "Grupa 5" },
            };
        }

        public ICollection<User> GetUsers()
        {
            return new List<User>()
            {
                new User() { Id = 1, Name = "Adam", Surename = "Kowalski", City = "Radom" },
                new User() { Id = 2, Name = "Piotr", Surename = "Piotrowski", City = "Radom" },
                new User() { Id = 3, Name = "Magda", Surename = "Nowakowska", City = "Warszawa" },
                new User() { Id = 4, Name = "Jan", Surename = "Nowak", City = "Radom" },
            };
        }
    }
}