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
            for (int i = 0; i < 20; i++)
            {
                foxDraw.DrawLine(i * 40, 800, (Width / 2) + (i * 40) / 2, i * 40);
                foxDraw.DrawLine(800 - (i * 40), 800, (Width / 2) - (i * 40) / 2, i * 40);
                foxDraw.DrawLine(0 + ((i * 40) / 2), 800 - (i * 40), 800 - ((i * 40) / 2), 800 - (i * 40));
            }
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

