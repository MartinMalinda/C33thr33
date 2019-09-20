    using Avalonia;
    using Avalonia.Controls;
    using Avalonia.Markup.Xaml;
    using GreenFox;
    using Avalonia.Media;
using System.Collections.Generic;

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
                foxDraw.SetStrokeColor(Colors.Black);
                foxDraw.SetFillColor(Colors.Transparent);

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

            /*
            for (int i = 1; i < 4; i++)
            {
                SquareX50(foxDraw, i * 100, i * 100);
            }
            */

            //CENTERBOXFUNCTION
            // create a function that draws one square and takes 2 parameters:
            // the square size and the foxDraw
            // and draws a square of that size to the center of the canvas.
            // draw 3 squares with that function.
            // avoid code duplication.

            /*
            for (int i = 1; i < 4; i++)
                {
                    CenteredSquare(foxDraw, 30 * i);
                }
            */

            //RAINBOWBOXFUNCTION
            // Create a square drawing function that takes 3 parameters:
            // The square size, and the fill color, foxDraw
            // and draws a square of that size and color to the center of the canvas.
            // Create a loop that fills the canvas with rainbow colored squares (red, orange, yellow, green, blue, indigo, violet).

            /*
            List<Color> barvy = new List<Color> { Colors.Red, Colors.Orange, Colors.Yellow,
                Colors.Green, Colors.Blue, Colors.Indigo, Colors.Violet };
            int x = 200;
            foreach (var barva in barvy)
            {
                Rainbow(foxDraw, x, barva);
                x -= 25;
            }
            */

            //PURPLESTEPS
            // Reproduce this:
            // [https://github.com/green-fox-academy/chama-cs-prg-syllabus/blob/master/workshop/drawing/assets/r3.png]

            /*
            var x = 20;
            for (int i = 0; i < 20; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(x, x, 20, 20);
                x +=20;
            }
            */

            //PURPLESTEPS3D
            // Reproduce this:
            // [https://github.com/green-fox-academy/chama-cs-prg-syllabus/blob/master/workshop/drawing/assets/r4.png]

            /*
            double x = 30;
            double y = 0;
            for (int i = 0; i < 6; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle(y, y, x, x);
                y += x;
                x += x / 4;
            }
            */

            //CHECKERBOARD
            // Fill the canvas with a checkerboard pattern.

            /*
             for (int rada = 0; rada <= 800; rada += 100)
             {
                for (int sloupec = 0; sloupec < 800; sloupec += 100)
                {
                    if (rada % 200 > 0)
                    {
                        if (sloupec % 200 > 0)
                        {
                            foxDraw.SetStrokeColor(Colors.White);
                            foxDraw.SetFillColor(Colors.White);
                            foxDraw.DrawRectangle(sloupec, rada, 100, 100);
                        }
                        else
                        {
                            foxDraw.SetStrokeColor(Colors.Black);
                            foxDraw.SetFillColor(Colors.Black);
                            foxDraw.DrawRectangle(sloupec, rada, 100, 100);
                        }
                    }
                    else
                    {
                        if (sloupec % 200 > 0)
                        {
                            foxDraw.SetStrokeColor(Colors.Black);
                            foxDraw.SetFillColor(Colors.Black);
                            foxDraw.DrawRectangle(sloupec, rada, 100, 100);
                        }
                        else
                        {
                            foxDraw.SetStrokeColor(Colors.White);
                            foxDraw.SetFillColor(Colors.White);
                            foxDraw.DrawRectangle(sloupec, rada, 100, 100);
                        }
                    }
                }
             }
            */

            //EVERYTHING GOES TO CENTER
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            /*
            for (int y = 0; y < 801; y += 20)
            {
                if (y == 0 || y == 800)
                {
                    for (int x = 0; x < 801; x += 20)
                    {
                        ToTheCenter(foxDraw, x, y);
                    }
                }
                else
                {
                    ToTheCenter(foxDraw, 0, y);
                    ToTheCenter(foxDraw, 800, y);

                }
            }
            */

            //CONNECT THE DOTS

            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            List<Point> dotsA = new List<Point> { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };
            List<Point> dotsB = new List<Point> {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90),
                new Point(100, 70),new Point(120, 100), new Point(85, 130), new Point(50, 100)};

            ConnectDots(foxDraw, dotsA);
            ConnectDots(foxDraw, dotsB);

        }
            public void ConnectDots (FoxDraw foxDraw, List<Point>dots)
            {
            for (int i = 0; i < dots.Count; i++)
            {
                if (i+1 >= dots.Count)
                {
                    foxDraw.DrawLine(dots[i], dots[0]);
                }
                else
                {
                    foxDraw.DrawLine(dots[i], dots[i + 1]);
                }
            }
            }
            
            public void Rainbow (FoxDraw foxDraw, int velikost, Color barva)
            {
                foxDraw.SetFillColor(barva);
                foxDraw.DrawRectangle((Width / 2) - (velikost / 2), (Height / 2) - (velikost / 2), velikost, velikost);
            }

            public void CenteredSquare (FoxDraw foxDraw , int x)
            {
                foxDraw.DrawRectangle((Width / 2) - (x / 2), (Height / 2) - (x / 2), x, x);
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
 