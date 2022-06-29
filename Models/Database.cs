namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public static class Database
    {
        public static ICollection<Course> Courses { get; set; }    
        public static ICollection<Instructor> Instructors { get; set; }
        public static int IdCounter { get; set; }

        public static void CreateCourse(string title)
        {
            Courses.Add(new Course(IdCounter++, title));
        }
        static Database()
        {
            Courses = new HashSet<Course>();
            Instructors = new HashSet<Instructor>();

            Course sd = new Course(IdCounter++, "Software Developer");
            Course weld = new Course(IdCounter++, "Welding");
            Course security = new Course(IdCounter++, "Network Security");
            Course aa = new Course(IdCounter++, "Administrative Assistant");
            Course childcare = new Course(IdCounter++, "Childcare");

            Courses.Add(sd);
            Courses.Add(weld);
            Courses.Add(security);
            Courses.Add(aa);
            Courses.Add(childcare);
        }
    }
}
