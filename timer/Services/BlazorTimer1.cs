namespace Services
{
    using System;
    using System.Timers;
    internal class BlazorTimer
    {
        private Timer _timer;

        public void SetTimer(double interval)
        {
            _timer = new Timer(interval); // Permet d'initialiser un timer 
            _timer.Elapsed += NotifyTimerElapsed;
            _timer.AutoReset = true;
            _timer.Enabled = true;      
        }

        public event Action OnElapsed; //Permet d'arrêter le Timer

        public void StopTimer()
        {
            _timer.Stop(); //Quand l'intervalle rentré en paramètre dans la fonction SetTimer() est terminé déclenche l'event OnElapsed  public event Action OnElapsed;

        }
    private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
        }
    }
}