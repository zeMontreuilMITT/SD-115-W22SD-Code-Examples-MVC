namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Reaction
    {
        // primary key
        public int Id { get; set; }
        public bool IsPositive { get; set; }
        public Post Post { get; set; }
        public User User { get; set; }

        public Reaction(int id, bool isPositive, Post post, User user)
        {
            Id = id;
            IsPositive = isPositive;
            Post = post;
            User = user;
        }
    }
}
