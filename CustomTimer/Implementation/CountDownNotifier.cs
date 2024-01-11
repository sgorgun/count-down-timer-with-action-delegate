using System;
using CustomTimer.Interfaces;

namespace CustomTimer.Implementation
{
    /// <inheritdoc/>
    public class CountDownNotifier : ICountDownNotifier
    {
        private readonly Timer timer;

        public CountDownNotifier(Timer timer) => this.timer = timer;

        /// <inheritdoc/>
        public void Init(Action<string, int> startDelegate, Action<string> stopDelegate, Action<string, int> tickDelegate)
        {
            if (startDelegate != null)
            {
                this.timer.Started += startDelegate;
            }

            if (stopDelegate != null)
            {
                this.timer.Stopped += stopDelegate;
            }

            if (tickDelegate != null)
            {
                this.timer.Tick += tickDelegate;
            }
        }

        /// <inheritdoc/>
        public void Run() => this.timer.Start();
    }
}
