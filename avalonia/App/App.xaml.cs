using Avalonia;
using Avalonia.Markup.Xaml;

namespace contact.ui
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
   }
}