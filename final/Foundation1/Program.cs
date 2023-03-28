using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videoList = new List<Video>();
        Console.Clear();
        Video video1 = new Video("Nolan goes to the zoo", "Nolan Monnier", 237);
        Comment comment1 = new Comment("RudeMan65", "Please stop going to the zoo... It's annoying!");
        video1.AddComment(comment1);
        Comment comment2 = new Comment("CatGrandma54", "Nolan, you're doing great! I'm so proud to be your grandmother!");
        video1.AddComment(comment2);
        Comment comment3 = new Comment("NiceGuy97", "Great video!");
        video1.AddComment(comment3);
        Comment comment4 = new Comment("Anonymous", "The monkey at 32 seconds is hilarious! :')");
        video1.AddComment(comment4);
        _videoList.Add(video1);


        Video video2 = new Video("Stephany tries playing the piano", "Stephany Smith", 176);
        Comment comment5 = new Comment("AwesomeTeenager", "First!");
        video2.AddComment(comment5);
        Comment comment6 = new Comment("BrianneJ", "Playing without sheet music is not hard, playing with emotion is.");
        video2.AddComment(comment6);
        Comment comment7 = new Comment("HelloThere", "I'm so jealous of the passion she has for piano, you can feel it in the way she plays!");
        video2.AddComment(comment7);
        _videoList.Add(video2);


        Video video3 = new Video("Purrfectly Adorable: A Compilation of the Cutest Cat Moments", "Samantha Johnson", 452);
        Comment comment8 = new Comment("MeowMix", "I love how the orange cat is so playful and energetic! He's the star of the show.");
        video3.AddComment(comment8);
        Comment comment9 = new Comment("WhiskerWonderland", "Watching this video has definitely brightened up my day. Thanks for sharing!");
        video3.AddComment(comment9);
        Comment comment10 = new Comment("ClawSomeCats", "I can't get enough of these adorable furballs! They remind me of my own little feline family");
        video3.AddComment(comment10);
        Comment comment11 = new Comment("FurryFanatic", "I never thought I was a cat person until I saw this video. Now I want to adopt every single one of them!");
        video3.AddComment(comment11);
        _videoList.Add(video3);

        foreach (Video video in _videoList)
        {
            video.Display();
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
}