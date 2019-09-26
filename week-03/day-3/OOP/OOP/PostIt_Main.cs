using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            PostIt postIt1 = new PostIt();
            postIt1.BackgroundColor = "Orange";
            postIt1.Text = "Idea1";
            postIt1.TextColor = "Blue";

            PostIt postIt2 = new PostIt();
            postIt1.BackgroundColor = "Pink";
            postIt1.Text = "Awesome";
            postIt1.TextColor = "Black";

            PostIt postIt3 = new PostIt();
            postIt1.BackgroundColor = "Yellow";
            postIt1.Text = "Superb";
            postIt1.TextColor = "Green";
        }
    }
}
!