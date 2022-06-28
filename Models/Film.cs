namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Duration { get; set; }
        public double Budget { get; set; }
        public ICollection<Role> Roles { get; set; } = new HashSet<Role>();

        public Film(int id, string title, int year, int duration, double budget)
        {
            Id = id;
            Title = title;
            Year = year;
            Duration = duration;
            Budget = budget;
        }
    }
}
