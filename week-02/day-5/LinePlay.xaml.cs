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
            for (int i = 1; i < 16; i++)
            {
                foxDraw.DrawLine(0, 200 + (i * 40), i * 40, 800);
            }
            foxDraw.SetStrokeColor(Colors.Purple);
            for (int j = 1; j < 16; j++)
            {
                foxDraw.DrawLine(200 + (j * 40), 0, 800, j * 40);
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

