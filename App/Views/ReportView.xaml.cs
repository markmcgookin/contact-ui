using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace contact.ui.Views
{
    public class ReportView : UserControl
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}