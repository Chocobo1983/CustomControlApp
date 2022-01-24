using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using ManagedHelpers;

namespace MyControl
{
    public class MyControl : Control, INotifyPropertyChanged
    {
        public static readonly DependencyProperty CounterProperty;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int Counter
        {
            get { return (int)GetValue(CounterProperty); }
            set { SetValue(CounterProperty, value); }
        }
        static MyControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MyControl), new FrameworkPropertyMetadata(typeof(MyControl)));
            CounterProperty = DependencyProperty.Register("Counter", typeof(int), typeof(MyControl));
        }
        public MyControl()
        {
            IncrementCommand = new RelayCommand(Increment);
            DecrementCommand = new RelayCommand(Decrement, CanExecute, this); 
        }
        private bool CanExecute() => Counter > 0;
        private void Increment() {++Counter; DecrementCommand.RaiseCanExecuteChanged(); }
        private void Decrement() { --Counter; DecrementCommand.RaiseCanExecuteChanged(); }                       
        public RelayCommand IncrementCommand { get; private set; } 
        public RelayCommand DecrementCommand { get; private set; }
        
    }
}
