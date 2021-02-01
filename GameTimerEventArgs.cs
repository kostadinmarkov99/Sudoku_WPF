﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp4
{
    class GameTimerEventArgs : EventArgs
    {
        #region . Constructors .

        /// <summary>
        /// Initializes a new instance of the GameTimerEventArgs class.
        /// </summary>
        /// <param name="value">Formatted string repesenting the time elapsed since the timer started.</param>
        internal GameTimerEventArgs(string value)
        {
            ElapsedTime = value;                    // Save the input parameter.
        }

        #endregion

        #region . Properties: Public Read-only .

        /// <summary>
        /// Gets the formatted string representing the time elapsed since the timer started.
        /// </summary>
        internal string ElapsedTime { get; private set; }

        #endregion
    }
}
