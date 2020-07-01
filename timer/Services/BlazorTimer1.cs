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
            /* Paramètre : Intervalle en ms 
         * Description : Permet d'initialiser un timer 
         * Retourne rien
         */
        }

        public event Action OnElapsed; //Quand l'intervalle rentré en paramètre dans la fonction SetTimer() est terminé déclenche l'event OnElapsed

        public void StopTimer()
        {
            _timer.Stop(); //Permet d'arrêter le Timer

        }
    private void NotifyTimerElapsed(Object source, ElapsedEventArgs e)
        {
            OnElapsed?.Invoke();
        }
    }
}