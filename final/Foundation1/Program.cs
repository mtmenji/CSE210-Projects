using System;
namespace Foundation1 {
class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cat Video", "Mr. Cat Guy", 120);
        video1.TerminalDisplay();
        Comment comment1 = new Comment("Rude Man", "This cat is ugly!");
        video1.AddCommentToVideo(comment1.GetFullComment());
        Comment comment2 = new Comment("Nice Guy", "Another great cat to smile at!");
        video1.AddCommentToVideo(comment2.GetFullComment());
        Comment comment3 = new Comment("Random Dude", "Cats are taking over the internet.");
        video1.AddCommentToVideo(comment2.GetFullComment());
        video1.DisplayComments();

        Video video2 = new Video("Quantum Computing Basics 101", "Dr. Josmith", 1020);
        video2.TerminalDisplay();
        Comment comment4 = new Comment("Diego", "Great concepts!");
        video2.AddCommentToVideo(comment4.GetFullComment());
        Comment comment5 = new Comment("Sally", "As a beginner, this is very helpful!");
        video2.AddCommentToVideo(comment5.GetFullComment());
        Comment comment6 = new Comment("Richard", "Why does the video say basics and 101? Seems redundant.");
        video2.AddCommentToVideo(comment6.GetFullComment());
        video2.DisplayComments();

        Video video3 = new Video("Crazy Minecraft Fort", "swifty1009204", 360);
        video3.TerminalDisplay();
        Comment comment7 = new Comment("trashketballer102", "I've seen better forts noob.");
        video3.AddCommentToVideo(comment7.GetFullComment());
        Comment comment8 = new Comment("unicornhearts422", "To all the haters in the comments, you guys should be nicer. Great build, swifty!");
        video3.AddCommentToVideo(comment8.GetFullComment());
        Comment comment9 = new Comment("iambobbyjimbo", "Lame. Get a real job.");
        video3.AddCommentToVideo(comment9.GetFullComment());
        video3.DisplayComments();
    }
}
}