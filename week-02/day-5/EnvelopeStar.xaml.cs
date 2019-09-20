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

            foxDraw.SetStrokeColor(Colors.Green);
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(Width/2, 0 + (i*20), (Width/2)-(i*20),Height/2);
                foxDraw.DrawLine(Width/2, 0 + (i*20), (Width/2)+(i*20),Height/2);
                foxDraw.DrawLine(Width/2, 800 - (i*20), (Width/2)-(i*20),Height/2);
                foxDraw.DrawLine(Width/2, 800 - (i*20), (Width/2)+(i*20),Height/2);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

