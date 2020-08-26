using MVVMHorseRun.Models;

namespace MVVMHorseRun.ViewModels
{
    public class MainViewModel
    {
        public RidersViewModel Riders { get; set; }
        public AngleModel Angle { get; set; }
        public MainViewModel()
        {
            Riders = new RidersViewModel();
            Angle = new AngleModel();
        }
    }
}
