using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace contact.ui.Views
{
    public class MainWindow : Window
    {
        private bool _0Pressed, _1Pressed, _2Pressed;
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new System.EventHandler<Avalonia.Input.KeyEventArgs>(KeyPressHandler);
            this.KeyUp += new System.EventHandler<Avalonia.Input.KeyEventArgs>(KeyUpHandler);
        }

        void KeyPressHandler(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"{e.Key} down");
            switch (e.Key)
            {
                case Key.D0:
                case Key.NumPad0:
                    _0Pressed = true;
                    break;
                case Key.D1:
                case Key.NumPad1:
                    _1Pressed = true;
                    break;
                case Key.D2:
                case Key.NumPad2:
                    _2Pressed = true;
                    break;
            }

            if (_0Pressed && _1Pressed && _2Pressed)
            {
                Application.Current.Exit();
            }

            e.Handled = true;
        }

        void KeyUpHandler(object sender, KeyEventArgs e)
        {
            Console.WriteLine($"{e.Key} up");
            switch (e.Key)
            {
                case Key.D0:
                case Key.NumPad0:
                    _0Pressed = false;
                    break;
                case Key.D1:
                case Key.NumPad1:
                    _1Pressed = false;
                    break;
                case Key.D2:
                case Key.NumPad2:
                    _2Pressed = false;
                    break;
            }

            e.Handled = true;
        }

        private void InitializeComponent()
        {
            this.HasSystemDecorations = false;
            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            AvaloniaXamlLoader.Load(this);
        }
    }
}