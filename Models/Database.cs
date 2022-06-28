namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public static class Database
    {
        public static ICollection<Film> Films { get; set; }
        public static ICollection<Role> Roles { get; set; }
        public static ICollection<Actor> Actors { get; set; }
        public static int IdCounter { get; set; }

        static Database()
        {
            Films = new HashSet<Film>();
            Roles = new HashSet<Role>();
            Actors = new HashSet<Actor>();

            Film topGun = new Film(IdCounter++, "Top Gun", 2022, 120, 30000000);
            Actor tomCruise = new Actor(IdCounter++, "Tom Cruise");
            Role maverick = new Role(IdCounter++, "Maverick", topGun, tomCruise);
            topGun.Roles.Add(maverick);
            tomCruise.Roles.Add(maverick);

            Films.Add(topGun);
            Roles.Add(maverick);
            Actors.Add(tomCruise);

            Actor jenniferConnelly = new Actor(IdCounter++, "Jennifer Connelly");
            Role penny = new Role(IdCounter++, "Penny", topGun, jenniferConnelly);
            jenniferConnelly.Roles.Add(penny);

            Actors.Add(jenniferConnelly);
            Roles.Add(penny);
            topGun.Roles.Add(penny);

            Actor milesTeller = new Actor(IdCounter++, "Miles Teller");
            Role rooster = new Role(IdCounter++, "Rooster", topGun, milesTeller);
            milesTeller.Roles.Add(rooster);
            topGun.Roles.Add(rooster);

            Actors.Add(milesTeller);
            Roles.Add(rooster);

            Film whiplash = new Film(IdCounter++, "Whiplash", 2014, 106, 200000000);

            Role andrew = new Role(IdCounter++, "Andrew", whiplash, milesTeller);
            whiplash.Roles.Add(andrew);
            milesTeller.Roles.Add(andrew);

            Films.Add(whiplash);
            Roles.Add(andrew);

            Film morbius = new Film(IdCounter++, "Morbius", 2022, 90, 300000000);
            Films.Add(morbius);

            Film lighthouse = new Film(IdCounter++, "The Lighthouse", 2019, 100, 20000000);
            Films.Add(lighthouse);

            Film babyDriver = new Film(IdCounter++, "Baby Driver", 2017, 110, 4000000);
            Films.Add(babyDriver);

            Film drStrange = new Film(IdCounter++, "Doctor Strange in the Multiverse of Madness", 2022, 126, 74987498349);
            Films.Add(drStrange);

        }
    }
}
