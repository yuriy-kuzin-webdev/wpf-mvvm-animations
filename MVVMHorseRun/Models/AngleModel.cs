using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMHorseRun.Models
{
    public class AngleModel : ObservableObject
    {
        private double _angle;
        public double Angle
        {
            get => _angle;
            set => OnPropertyChanged(ref _angle, value);
        }
    }
}
