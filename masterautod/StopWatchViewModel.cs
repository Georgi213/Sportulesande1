using System;
using System.Diagnostics;
using System.Timers;
using System.ComponentModel;
using Xamarin.Forms;
using System.Threading;

namespace masterautod
{
    public class StopWatchViewModel : INotifyPropertyChanged
    {
        Stopwatch watch = new Stopwatch();
        public string StopWatchHoursStop, StopWatchMinutesStop, StopWatchSecondsStop;

        private string stopwatchhours_;

        
        public string StopWatchHours
        {
            get { return stopwatchhours_; }
            set
            {
                stopwatchhours_ = value;
                OnPropertyChanged("StopWatchHours");
            }
        }

        private string stopwatchminutes_;
        public string StopWatchMinutes
        {
            get { return stopwatchminutes_; }
            set
            {
                stopwatchminutes_ = value;
                OnPropertyChanged("StopWatchMinutes");
            }
        }

        private string stopwatchseconds_;
        public string StopWatchSeconds
        {
            get { return stopwatchseconds_; }
            set
            {
                stopwatchseconds_ = value;
                OnPropertyChanged("StopWatchSeconds");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public StopWatchViewModel(bool running)
        {
            if (running == true)
            {
                watch.Start();
                StopWatchHours = watch.Elapsed.Hours.ToString();
                StopWatchMinutes = watch.Elapsed.Minutes.ToString();
                StopWatchSeconds = watch.Elapsed.Seconds.ToString();

                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    StopWatchHours = watch.Elapsed.Hours.ToString();
                    StopWatchMinutes = watch.Elapsed.Minutes.ToString();
                    StopWatchSeconds = watch.Elapsed.Seconds.ToString();


                    StopWatchHoursStop = StopWatchHours;
                    StopWatchMinutesStop = StopWatchMinutes;
                    StopWatchSecondsStop = StopWatchSeconds;
                    return true;
                });
            }
            else
            {
                watch.Stop();
                StopWatchHours = StopWatchHoursStop;
                StopWatchMinutes = StopWatchMinutesStop;
                StopWatchSeconds = StopWatchSecondsStop;
            }
        }
    }
}
