using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video1 = new Video("Nolan goes to the zoo", "Nolan Monnier", 237);
        video1.AddComment("RudeMan65", "Please stop going to the zoo... It's annoying!");
        video1.AddComment("CatGrandma54", "Nolan, you're doing great! I'm so proud to be your grandmother!");
        video1.AddComment("NiceGuy97", "Great video!");
        video1.AddComment("Anonymous", "The monkey at 32 seconds is hilarious! :')");
        video1.Display();
        System.Console.WriteLine();
        System.Console.WriteLine();

        Video video2 = new Video("Stephany tries playing the piano", "Stephany Smith", 176);
        video2.AddComment("AwesomeTeenager", "First!");
        video2.AddComment("BrianneJ", "Playing without sheet music is not hard, playing with emotion is.");
        video2.AddComment("HelloThere", "I'm so jealous of the passion she has for piano, you can feel it in the way she plays!");
        video2.Display();
        System.Console.WriteLine();
        System.Console.WriteLine();

        Video video3 = new Video("Purrfectly Adorable: A Compilation of the Cutest Cat Moments", "Samantha Johnson", 176);
        video3.AddComment("MeowMix", "I love how the orange cat is so playful and energetic! He's the star of the show.");
        video3.AddComment("WhiskerWonderland", "Watching this video has definitely brightened up my day. Thanks for sharing!");
        video3.AddComment("ClawSomeCats", "I can't get enough of these adorable furballs! They remind me of my own little feline family");
        video3.AddComment("FurryFanatic", "I never thought I was a cat person until I saw this video. Now I want to adopt every single one of them!");
        video3.Display();
    }
}