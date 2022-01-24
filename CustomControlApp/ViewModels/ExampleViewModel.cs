using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using ManagedHelpers;

namespace CustomControlApp.ViewModels
{
    internal class ExampleViewModel : ObservableObject 
    {
        int _counter = 0;
        double _angle = 0;
        public int Counter { get => _counter; set { SetProperty(ref _counter, value); } }
        public double Angle { get => _angle; set { SetProperty(ref _angle, value); } }

        public ExampleViewModel()
        {
            RandomAngleCommand = new RelayCommand(() => Angle = new Random().Next(0, 360));
        }

        public ICommand RandomAngleCommand { get; private set; }  
    }
}
