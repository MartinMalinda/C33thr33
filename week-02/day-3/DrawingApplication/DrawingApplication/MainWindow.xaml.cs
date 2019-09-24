using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GreenFox;
using Avalonia.Media;
using System.Collections.Generic;
using System;

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
            string timeNow = DateTime.Now.ToString("HH:mm");
            Random random = new Random();
            string hours = string.Join("", timeNow[0], timeNow[1]);
           // int hour = int.Parse(hours);       // getting current time into integer
           int hour = 23;                       // sets time manually
            if (hour > 7 && hour < 20)
            {
                foxDraw.SetBackgroundColor(Colors.LightBlue);
                if (hour <= 13)
                {
                    DrawSun(foxDraw, 100 + ((hour - 7) * 50), 500 - ((hour - 7) * 50));

                }
                else
                {
                    DrawSun(foxDraw, 100 + ((hour - 7) * 50), 100 + ((hour - 13) * 50));
                }


            }
            else
            {
                foxDraw.SetBackgroundColor(Colors.Black);
                for (int i = 0; i < random.Next(100,200); i++)
                {
                    foxDraw.SetStrokeColor(Colors.Yellow);
                    foxDraw.DrawRectangle(random.Next(0, 800), random.Next(0, 800), 3, 3);
                }
                foxDraw.SetStrokeColor(Colors.Transparent);

                if (hour >= 20 && hour <= 23)
                {
                    DrawMoon(foxDraw, 100 + ((hour - 19) * 50), 500 - ((hour - 19) * 50));

                }
                else if (hour < 2)
                {
                    DrawMoon(foxDraw, 100 + ((hour + 5) * 50), 500 - ((hour + 5) * 50));
                }
                else
                {
                    DrawMoon(foxDraw, 100 + ((hour + 5) * 50), 100 + ((hour - 1) * 50));
                }

            }
            if (true)
            {

            }


        }
        public void DrawSun(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetStrokeColor(Colors.Yellow);
            foxDraw.SetFillColor(Colors.Yellow);
            foxDraw.DrawEllipse(x - 50, y - 50, 100, 100);
            foxDraw.DrawLine(x - 80, y, x + 80, y);
            foxDraw.DrawLine(x, y + 80, x, y - 80);
            foxDraw.DrawLine(x - 65, y + 65, x + 65, y - 65);
            foxDraw.DrawLine(x - 65, y - 65, x + 65, y + 65);

        }
        public void DrawMoon(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetStrokeColor(Colors.Silver);
            foxDraw.SetFillColor(Colors.Silver);
            foxDraw.DrawEllipse(x - 50, y - 50, 100, 100);
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.SetFillColor(Colors.Black);
            foxDraw.DrawEllipse(x - 100, y - 60, 120, 120);
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

