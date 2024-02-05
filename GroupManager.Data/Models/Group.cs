namespace GroupManager.Data.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<User> Users { get; set; }

        public Group()
        {
            Name = string.Empty;
            Users = new List<User>();
        }
    }
}