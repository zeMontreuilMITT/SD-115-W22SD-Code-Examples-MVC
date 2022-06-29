namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; } = new HashSet<Course>();

        public Instructor(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
