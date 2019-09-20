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
            foxDraw.SetBackgroundColor(Colors.LightBlue);
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.SetStrokeThicknes(1);

            UpShape(foxDraw, (Width / 2), (Height / 2) - 140);  //first line

            for (int w = -30; w <= 30; w = w + 60)      // second line
            {
                UpShape(foxDraw, (Width / 2) + w, (Height / 2) - 120);
            }

            for (int w = -60; w <= 60; w = w + 60)      // third line copied multiple times
            {
                for (int h = -60; h <= 100; h = h + 40)
                {
                    UpShape(foxDraw, (Width / 2) + w, (Height / 2) - h);
                }
            }

            for (int h = -80; h < 80; h = h + 40)   //middle part
            {
                for (int w = -90; w <= 90; w = w + 60)
                {
                    UpShape(foxDraw, (Width / 2) + w, (Height / 2) + h);
                    DownShape(foxDraw, (Width / 2) + w, ((Height / 2) + h) + 40);
                }
            }

            for (int w = -60; w <= 60; w = w + 60)      // third to last
            {
                DownShape(foxDraw, (Width / 2) + w, (Height / 2) + 100);
            }

            for (int w = -30; w <= 30; w = w + 60)      // second to last
            {
                DownShape(foxDraw, (Width / 2) + w, (Height / 2) + 120);
            }

            DownShape(foxDraw, (Width / 2), (Height / 2) + 140);  //last line 
        }
        public void UpShape(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.DrawLine(x - 20, y + 20, x - 10, y);
            foxDraw.DrawLine(x + 10, y, x - 10, y);
            foxDraw.DrawLine(x + 10, y, x + 20, y + 20);

        }
        public void DownShape(FoxDraw foxDraw, double x, double y)
        {
            foxDraw.DrawLine(x - 20, y - 20, x - 10, y);
            foxDraw.DrawLine(x + 10, y, x - 10, y);
            foxDraw.DrawLine(x + 10, y, x + 20, y - 20);

        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

