using Post_Text.Entities;


namespace Post_Text
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1= new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(DateTime.Parse(
                "12/06/2022 13:06:44"),
                "Travelling to Brazil",
                "I'm going to visit this wonderful country!", 12);
            p1.addComment(c1);
            p1.addComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(DateTime.Parse(
                "28/07/2022 15:44:54"),
                "Good evening",
                "See'ya", 5);
            p2.addComment(c3);
            p2.addComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}