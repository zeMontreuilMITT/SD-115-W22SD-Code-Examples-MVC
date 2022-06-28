namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Role> Roles { get; set; } = new HashSet<Role>();

        public Actor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
