using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WpfApp4
{
    public class TimerClass
    {
        #region Constants
        private string _initialValue = "00:00:00";
        private string _timeFormat = "hh\\:mm\\:ss";
        private Int32 _interval = 1000;
        #endregion

        private DateTime _startTime;
        private Timer _timer;

        internal string ElapsedTime { get;  set; }

        internal event EventHandler<GameTimerEventArgs> GameTimerEvent;

        /// <summary>
        /// Initializes a new instance of the GameTimer class.
        /// </summary>
        internal TimerClass()
        {
            ElapsedTime = _initialValue;                    // Initialize the elapsed time value
        }

        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ComputeElapsedTime();                   // Compute elapsed time
            RaiseEvent(ElapsedTime);                // Raise an event with the elapsed time
        }

        /// <summary>
        /// Start the timer.
        /// </summary>
        internal void StartTimer()
        {
            _startTime = DateTime.Now;                      // Save the start time to now
            if (_timer == null)                             // Is the timer variable null?
                _timer = new Timer(_interval);              // Yes, then instantiate a new timer instance and initialize the interval to 1 second
            _timer.Elapsed += _timer_Elapsed;               // Set the timer event handler
            _timer.AutoReset = true;                        // Set the autoreset property to true
            _timer.Enabled = true;                          // Start the timer
            RaiseEvent(_initialValue);                      // Raise the event
        }

        /// <summary>
        /// Stop the timer.
        /// </summary>
        internal void StopTimer()
        {
            try
            {
                if ((_timer != null) && (_timer.Enabled))   // Is the timer running?
                {
                    _timer.Enabled = false;                 // Stop it
                    ComputeElapsedTime();                   // Compute the elapsed time
                    RaiseEvent("");                         // Raise an event
                }
            }
            catch (Exception)
            {
                // TODO: What to do here?
            }
            finally
            {
                _timer = null;                              // Set the timer variable to null
            }
        }

        /// <summary>
        /// Pause the timer.
        /// </summary>
        internal void PauseTimer()
        {
            if ((_timer != null) && (_timer.Enabled))       // Is the timer running?
                _timer.Enabled = false;                     // Stop it
        }

        /// <summary>
        /// Resume the timer.
        /// </summary>
        internal void ReсsumeTimer()
        {
            if (_timer != null)                             // Is the timer variable null?
            {
                LoadPreviousTime();                         // No, then load the previously saved time
                _timer.Enabled = true;                      // Start the timer
            }
        }

        /// <summary>
        /// Load the previously saved time.
        /// </summary>
        internal void LoadPreviousTime()
        {
            TimeSpan diff = Properties.Settings.Default.ElapsedTime;    // Load the previously saved time
            _startTime = DateTime.Now - diff;                           // Compute the difference
        }

        /// <summary>
        /// Reset the timer.
        /// </summary>
        internal void ResetTimer()
        {
            if (_timer != null)                             // Is the timer variable null?
            {
                _timer.Enabled = false;                     // No, stop the timer
                _startTime = DateTime.Now;                  // Reset the start time to now
                _timer.Enabled = true;                      // Start the timer again
                RaiseEvent(_initialValue);                  // Raise an event
            }
        }

        #region . Methods: Private .

        private void ComputeElapsedTime()
        {
            try
            {
                TimeSpan diff = DateTime.Now - _startTime;      // Compute the difference between the start time and now.
                Properties.Settings.Default.ElapsedTime = diff; // Save it to the application configuration
                ElapsedTime = diff.ToString(_timeFormat);       // Save the elapsed time
            }
            catch (Exception)
            {
                ElapsedTime = _initialValue;                    // Error, initialize the elapsed time
            }
        }

        internal void ChangeElapsed(string elapsed)
        {
            try
            {
                //if ((_timer != null))   // Is the timer running?
                //{
                    _timer.Enabled = false;                 // Stop it
                    TimeSpan ts = TimeSpan.Parse(elapsed);
                    Properties.Settings.Default.ElapsedTime = ts; // Save it to the application 
                ElapsedTime = ts.ToString(_timeFormat);       // Save the elapsed time
                _initialValue = ElapsedTime;
                //_timer.Enabled = true;
                TimeSpan diff = Properties.Settings.Default.ElapsedTime;    // Load the previously saved time
                _startTime = DateTime.Now - diff;                           // Compute the difference
                _timer.Enabled = true;
                RaiseEvent(_initialValue);                  // Raise an event
                //RaiseEvent(elapsed);  
                // Raise an event
                //}
            }
            catch (Exception)
            {
                // TODO: What to do here?
            }
           
        }

        protected virtual void RaiseEvent(string value)
        {
            EventHandler<GameTimerEventArgs> handler = GameTimerEvent;
            if (handler != null)
            {
                GameTimerEventArgs e = new GameTimerEventArgs(value);
                handler(this, e);
            }
        }

        #endregion

    }
}
