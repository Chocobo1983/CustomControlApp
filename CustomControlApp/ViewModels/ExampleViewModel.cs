using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CustomControlApp.ViewModels
{
    internal class ExampleViewModel : VMBase
    {
        int _counter = 0;
        double _angle = 0;
        public int Counter { get => _counter ;  set { _counter = value; OnPropertyChanged(nameof(Counter)); } }
        public double Angle { get => _angle; set { _angle = value; OnPropertyChanged(nameof(Angle)); } }
        public ICommand RandomAngleCommand => new RelayCommand((object o) => Angle = new Random().Next(0, 360));
    }
}
