namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Instructor Instructor { get; set; }

        public Course(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
