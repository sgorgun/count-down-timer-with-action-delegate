using CustomTimer.Factories;

namespace CustomTimer
{
    /// <summary>
    /// A custom class for simulating a countdown clock, which implements the ability to send a messages and additional
    /// information about the Started, Tick and Stopped events to any types that are subscribing the specified events.
    ///
    /// - When creating an object of Timer class, it must be assigned:
    ///     - name (not null or empty string, otherwise ArgumentException will be thrown);
    ///     - the number of ticks (the number must be greater than 0, otherwise an exception will throw an ArgumentException).
    ///
    /// - After the timer has been created, it can fire the Started event, the event should contain information about
    /// the name of the timer and the number of ticks to start.
    ///
    /// - After starting the timer, it fires Tick events, which contain information about the name of the timer and
    /// the number of ticks left for triggering, there should be delays between Tick events, delays are modeled by Thread.Sleep.
    ///
    /// - After all Tick events are triggered, the timer should start the Stopped event, the event should contain information about
    /// the name of the timer.
    /// </summary>
    public class Timer
    {
        private readonly string name;
        private int ticks;

        public Timer(string name, int ticks)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Can't be null or empty.", nameof(name));
            }

            if (ticks <= 0)
            {
                throw new ArgumentException("The number must be greater than 0.", nameof(ticks));
            }

            this.name = name;
            this.ticks = ticks;
        }

        public event Action<string, int> Started;

        public event Action<string, int> Tick;

        public event Action<string> Stopped;

        public void Start()
        {
            this.OnStarted(this.name, this.ticks);

            while (this.ticks > 1)
            {
                this.ticks--;
                this.OnTick(this.name, this.ticks);
                Thread.Sleep(100);
            }

            this.OnStopped(this.name);
        }

        protected virtual void OnStarted(string name, int ticks) => this.Started?.Invoke(name, ticks);

        protected virtual void OnTick(string name, int ticks) => this.Tick?.Invoke(name, ticks);

        protected virtual void OnStopped(string name) => this.Stopped?.Invoke(name);
    }
}
