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
         
            canvas.Width = 1000;
            canvas.Height = 1000;

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

            
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(0, 0, canvas.Width, canvas.Height);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(canvas.Width, 0, 0, canvas.Height);
        }





        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
 