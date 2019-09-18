using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
         
            canvas.Width = 800;
            canvas.Height = 800;

            //LINEINTHEMIDDLE
            //draw a red horizontal line to the canvas' middle.
            //draw a green vertical line to the canvas' middle.

            /*
            foxDraw.SetBackgroundColor(Colors.LightYellow);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Height / 2, canvas.Width, canvas.Height / 2);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width/2, 0, canvas.Width/2, canvas.Height);
            */

            //COLOREDBOX
            // Draw a box that has different colored lines on each edge.

            /*
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(300, 300, 700, 300);
            foxDraw.SetStrokeColor(Colors.Blue);
            foxDraw.DrawLine(700, 300, 700, 700);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(700, 700, 300, 700);
            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.DrawLine(300, 700, 300, 300);
            */

            //DIAGONALS
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            /*
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width, 0, 0, canvas.Height);
            */

            //TO THE CENTER
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Draw at least 3 lines with that function using a loop.

            /*
            int numberOfLines = 100;
            do
            {
                ToTheCenter(foxDraw, numberOfLines, 100);
                numberOfLines += 200;
            } while (numberOfLines<800);
            */

            //HORIZONTAL
            // Create a function that draws a single line and takes 3 parameters:
            // The x and y coordinates of the line's starting point and the foxDraw
            // and draws a 50 long horizontal line from that point.
            // Draw at least 3 lines with that function using a loop.

            /*
            int numberOfLines = 0;
            int x = 50;
            int y = 100;
            do
            {

                HorLine(foxDraw, x, y);
                numberOfLines++;
                x += 100;
                y += 50;

            } while (numberOfLines < 3);
            */

            // CENTEREDSQUARE
            // Draw a green 10x10 square to the canvas' center.

            /*
            foxDraw.DrawRectangle(Width / 2, Height / 2, 10, 10);
            */

            //FOURRECTANGLES
            // draw four different size and color rectangles.
            // avoid code duplication.

            /*
            var x = 20;
            for (int i = 0; i < 4; i++)
            {
                if (i<1)
                {
                    foxDraw.SetStrokeColor(Colors.DarkRed);
                    foxDraw.SetFillColor(Colors.DarkRed);
                }
                else if (i <2)
                {
                    foxDraw.SetStrokeColor(Colors.CornflowerBlue);
                    foxDraw.SetFillColor(Colors.CornflowerBlue);
                }
                else if (i < 3)
                {
                    foxDraw.SetStrokeColor(Colors.GreenYellow);
                    foxDraw.SetFillColor(Colors.GreenYellow);
                }
                else
                {
                    foxDraw.SetStrokeColor(Colors.Black);
                    foxDraw.SetFillColor(Colors.Black);
                }
                foxDraw.DrawRectangle(x, x, x, x);
                x += x;
            }
            */

            //POSITIONSQUARE
            // create a function that draws one square and takes 3 parameters:
            // the x and y coordinates of the square's top left corner
            // and the foxDraw and draws a 50x50 square from that point.
            // draw 3 squares with that function.
            // avoid code duplication.

            for (int i = 1; i < 4; i++)
            {
                SquareX50(foxDraw, i * 100, i * 100);
            }
        }

        public void SquareX50 (FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawRectangle(x, y, 50, 50);
        }


        public void ToTheCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, Width / 2, Height / 2);
        }

        public void  HorLine (FoxDraw foxDraw, int x, int y)
        {
            foxDraw.DrawLine(x, y, x + 50, y);
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
 