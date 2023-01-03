using System;
using System.Windows.Input;
using ReactiveUI;

namespace Cadence.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public string Greeting => "Welcome to Avalonia!";
        public ICommand StartTracking { get; }

        public MainWindowViewModel()
        {
            StartTracking = ReactiveCommand.Create(() =>
            {
                Console.WriteLine("Test");
            });
        }
    }
}
