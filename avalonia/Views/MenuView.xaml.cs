using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace contact.ui.Views
{
    public class MenuView : UserControl
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}