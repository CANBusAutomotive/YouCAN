using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using CANShark.Desktop.ViewModels;
using ReactiveUI;

namespace CANShark.Desktop.Views
{
    public class MainWindowView : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindowView()
        {
            this.InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            this.WhenActivated(d => { });

            AvaloniaXamlLoader.Load(this);
        }
    }
}
