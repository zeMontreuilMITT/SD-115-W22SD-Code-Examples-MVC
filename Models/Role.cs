namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Credit { get; set; }
        public Film Film { get; set; }
        public Actor Actor { get; set; }

        public Role(int id, string credit, Film film, Actor actor)
        {
            Id = id;
            Credit = credit;
            Film = film;
            Actor = actor;
        }
    }
}
