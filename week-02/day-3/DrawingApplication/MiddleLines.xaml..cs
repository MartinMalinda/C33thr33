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

            //LINEINTHEMIDDLE
            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.


            canvas.Width = 1000;
            canvas.Height = 1000;
            foxDraw.SetBackgroundColor(Colors.LightYellow);
            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(0, canvas.Height / 2, canvas.Width, canvas.Height / 2);
            foxDraw.SetStrokeColor(Colors.Green);
            foxDraw.DrawLine(canvas.Width/2, 0, canvas.Width/2, canvas.Height);
        }
            


       

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}