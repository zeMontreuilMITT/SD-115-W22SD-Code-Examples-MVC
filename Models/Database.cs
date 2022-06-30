﻿namespace SD_115_W22SD_Code_Examples_MVC.Models
{
    public static class Database
    {
        public static ICollection<User> Users { get; set; } = new HashSet<User>();
        public static ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();
        public static ICollection<Post> Posts { get; set; } = new HashSet<Post>();
        public static int IdCounter { get; set; } = 1;

        public static Post CreatePost(string content)
        {
            Post newPost = new Post(IdCounter++, content);
            return newPost;
        }

        static Database()
        {
            User firstU = new User(IdCounter++, "AwesomeGamer9000");
            User secondU = new User(IdCounter++, "SpecialPerson12");
            User thirdU = new User(IdCounter++, "**ExtraMysterious**");
            User fourthU = new User(IdCounter++, "NumberOneGrandpa");

            Post firstPost = new Post(IdCounter++, "Get good scrub", firstU);
            firstU.Posts.Add(firstPost);

            Post secondPost = new Post(IdCounter++, "lol bad game", firstU);
            firstU.Posts.Add(secondPost);

            Post thirdPost = new Post(IdCounter++, "I am so proud of my grandchildren", fourthU);
            fourthU.Posts.Add(thirdPost);   
           
            Users.Add(firstU);
            Users.Add(secondU);
            Users.Add(thirdU);
            Users.Add(fourthU);

            Posts.Add(firstPost);
            Posts.Add(secondPost);
            Posts.Add(thirdPost);

            Reaction firstReaction = new Reaction(IdCounter++, false, firstPost, secondU);
            Reaction secondReaction = new Reaction(IdCounter++, false, firstPost, thirdU);

            firstPost.Reactions.Add(firstReaction);
            firstPost.Reactions.Add(secondReaction);

            secondU.Reactions.Add(firstReaction);
            thirdU.Reactions.Add(secondReaction);

            Reactions.Add(firstReaction);
            Reactions.Add(secondReaction);
        }
    }
}
