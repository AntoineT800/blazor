namespace Services
{
    using System;
    using System.Timers;
    internal class BlazorTimer
    {
        private Timer _timer;

        public void SetTimer(double interval)
        {
            _timer = new Timer(interval);
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        public event Action OnElapsed;

        public void StopTimer()
        {
            _timer.Stop();
        }
        private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
        }
    }
}