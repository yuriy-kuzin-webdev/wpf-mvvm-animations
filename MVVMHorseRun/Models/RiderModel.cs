namespace MVVMHorseRun.Models
{
    public class RiderModel : ObservableObject
    {
        private string _name;
        private double _time;
        private bool _isWinner;
        public string Name
        {
            get => _name;
            set => OnPropertyChanged(ref _name, value);
        }
        public double Time
        {
            get => _time;
            set => OnPropertyChanged(ref _time, value);
        }
        public bool IsWinner
        {
            get => _isWinner;
            set => OnPropertyChanged(ref _isWinner, value);
        }
    }
}
