using MVVMHorseRun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace MVVMHorseRun.ViewModels
{
    public class RidersViewModel
    {
        public RiderModel LuckyBell { get; private set; }
        public RiderModel SweetFate { get; private set; }
        public RiderModel MrKentucky { get; private set; }
        public RiderModel FreshSpice { get; private set; }
        public RiderModel Bluegrass { get; private set; }

        

        public ICommand SetTimeCommand { get; }
        private List<RiderModel> riders;

        public RidersViewModel()
        {
            riders = new List<RiderModel>();

            LuckyBell   = new RiderModel { IsWinner = false, Name = "Lucky Bell" };
            riders.Add(LuckyBell);
            SweetFate   = new RiderModel { IsWinner = false, Name = "Sweet Fate" };
            riders.Add(SweetFate);
            MrKentucky  = new RiderModel { IsWinner = false, Name = "Mr. Kentucky" };
            riders.Add(MrKentucky);
            FreshSpice  = new RiderModel { IsWinner = false, Name = "Fresh Spice" };
            riders.Add(FreshSpice);
            Bluegrass   = new RiderModel { IsWinner = false, Name = "Bluegrass" };
            riders.Add(Bluegrass);

            SetTimeCommand = new RelayCommand(SetTime);

            SetTime();
        }
        private void SetTime()
        {
            int
                min = 2000,
                max = 5000;

            Random r = new Random(DateTime.Now.Second);

            foreach (RiderModel rider in riders)
            {
                rider.Time = r.Next(min, max);
                rider.IsWinner = false;
            }

            double winnerTime = riders.Min(rider => rider.Time);
            riders.First(rider => rider.Time == winnerTime).IsWinner = true;
        }
    }
}