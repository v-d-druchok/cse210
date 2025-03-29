using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> vids = new List<Video>();

        Video vid1 = new Video("Iount Care", "Douglas Shortend Twice", 810);
        
        Comment comment1 = new Comment("Pagani", "He's just like me fr");
        Comment comment2 = new Comment("worm", "Bro spitting facts");
        Comment comment3 = new Comment("Omniman", "Are you sure?");
        Comment comment4 = new Comment("pablogonzales2009", "I agree on all levels");
        Comment comment16 = new Comment("Edge Nation Official ✓", "Did you know? REAL professional edgers use tape :)!!");
        Comment comment19 = new Comment("ArtificalHumanoidJeremy", "Watch me do my teacher noise... ninininibidubiriruri");
        Comment comment20 = new Comment("ProudCroat", "Croatia Number 1!!!!!!!");

        vid1.AddComment(comment4);
        vid1.AddComment(comment3);
        vid1.AddComment(comment2);
        vid1.AddComment(comment1);
        vid1.AddComment(comment16);
        vid1.AddComment(comment19);
        vid1.AddComment(comment20);

        vids.Add(vid1);

        Video vid2 = new Video("I care now", "Douglas Shortend Twice", 2200);
        
        Comment comment5 = new Comment("Pagani", "I dont");
        Comment comment6 = new Comment("Oxlong, Mike", "Couldnt be me");
        Comment comment7 = new Comment("Omniman", "Are you sure?");
        Comment comment8 = new Comment("pablogonzales2009", "Bro fell off");
        Comment comment13 = new Comment("Brian Swords of York", "I like rats");
        Comment comment14 = new Comment("Jordan Peterson", "@BrianSwordsofYork me too ;)");
        Comment comment15 = new Comment("Lester, Moe", "@JordanPeterson wanna swap names??");
        Comment comment21 = new Comment("ProudAlbanian", "Albania Number 1!!!!!!!");

        vid2.AddComment(comment5);
        vid2.AddComment(comment6);
        vid2.AddComment(comment7);
        vid2.AddComment(comment8);
        vid2.AddComment(comment13);
        vid2.AddComment(comment14);
        vid2.AddComment(comment15);
        vid2.AddComment(comment21);

        vids.Add(vid2);

        Video vid3 = new Video("You all suck and i quit", "Douglas Shortend Twice", 300);
        
        Comment comment9 = new Comment("Pagani", "Sucks to suck bro aint no one gon miss you");
        Comment comment10 = new Comment("Oxlong, Mike", "weak");
        Comment comment11 = new Comment("Omniman", "Are you sure?");
        Comment comment12 = new Comment("pablogonzales2009", "Gottem");
        Comment comment17 = new Comment("Real Person", "■■■■■ ■■ ■■■");
        Comment comment18 = new Comment("pablogonzales2009", "@RealPerson today is oposite day... on that note. LOVE YOURSELF NOW!!!!");
        Comment comment22 = new Comment("ProudAlbanian", "Albania Number 1!!!!!!!");
        Comment comment23 = new Comment("ProudCroat", "Croatia Number 1!!!!!!!");
        Comment comment24 = new Comment("ProudAlbanian", "@ProudCroat no Albania is Number 1 get out of here!");
        Comment comment25 = new Comment("ProudCroat", "@ProudAlbanian Get out of here we all know Croatia is best of all time always!!!!1!11!!");

        vid3.AddComment(comment9);
        vid3.AddComment(comment10);
        vid3.AddComment(comment11);
        vid3.AddComment(comment12);
        vid3.AddComment(comment17);
        vid3.AddComment(comment18);
        vid3.AddComment(comment22);
        vid3.AddComment(comment23);
        vid3.AddComment(comment24);
        vid3.AddComment(comment25);

        vids.Add(vid3);
        
        foreach(Video vid in vids)
        {
            Console.WriteLine(vid.GetDisplayText());
        }
    }
}