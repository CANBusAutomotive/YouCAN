using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;

namespace CANShark.Desktop.ViewModels
{
    public class MainWindowViewModel : ReactiveObject, IScreen, IActivatableViewModel
    {
        public RoutingState Router { get; } = new RoutingState();

        public string Greeting => "Welcome to Avalonia!";

        public ViewModelActivator Activator { get; }

        public ObservableCollection<string> Data { get; set; } = new ObservableCollection<string> { "asd", "sdsd" };

        public ReactiveCommand<Unit, Unit> AddItem { get; }

        public MainWindowViewModel()
        {
            Activator = new ViewModelActivator();

            AddItem = ReactiveCommand
                .Create(() =>
                {
                    Console.WriteLine("Add item");
                    throw new InvalidOperationException();
                });

            AddItem.ThrownExceptions.Subscribe(e =>
            {
                Console.WriteLine(e.Message);
            });
        }
    }
}
