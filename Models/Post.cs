namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Post
    {
        // primary key
        public int Id { get; set; }
        public string Content { get; set; }
        public User User { get; set; }
        public ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();

        public Post(int id, string content)
        {
            Id = id;
            Content = content;
        }
        public Post(int id, string content, User user)
        {
            id = Id;
            Content = content;
            User = user;
        }
    }
}
