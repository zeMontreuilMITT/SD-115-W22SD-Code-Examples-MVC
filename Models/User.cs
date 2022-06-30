namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class User
    {
        // primary key
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
