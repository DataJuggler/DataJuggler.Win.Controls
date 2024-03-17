

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.UltimateHelper;
using DataJuggler.Win.Controls.Enumerations;
#endregion

namespace DataJuggler.Win.Controls
{

    #region class TimerDisplay
    /// <summary>
    /// This class is used to display time.
    /// </summary>
    public partial class TimerDisplay : UserControl
    {
        
        #region Private Variables
        private DateTime startTime;
        private DateTime endTime;
        private int lastSecond;  
        private bool reverse;
        private DateTime startAtTime;
        private TimerStatusEnum status;
        private bool stopAtZero;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'TimerDisplay' object.
        /// </summary>
        public TimerDisplay()
        {
            // Create Controls
            InitializeComponent();

            // Set the initial text
            TimerLabel.Text = "0:00:00";

            // Call size changed so it gets called at least once
            TimerLabel_SizeChanged(this, new EventArgs());
        }
        #endregion
        
        #region Events
            
            #region DisplayTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Display Timer _ Tick
            /// </summary>
            private void DisplayTimer_Tick(object sender, EventArgs e)
            {
                try
                {
                    // Get the current second
                    DateTime now = DateTime.Now;
                    
                    // needed for .NET8 Code
                    if (EndTime.Year > 1900)
                    {
                        // if we have passed the EndTime
                        if (now > EndTime)
                        {
                            // Stop the timer
                            DisplayTimer.Stop();
                        }
                    }
                
                    // get the current second
                    int second = now.Second;

                    // locals
                    TimeSpan elapsed;
                    double hours = 0;
                    int minutes = 0;
                    int seconds = 0;
                    string minutesText = "";
                    string secondsText = "";

                    // if the second changed
                    if (second != LastSecond)
                    {
                        // if the value for Reverse is true
                        if (Reverse)
                        {
                            // get the elapsed
                            elapsed = StartAtTime - now;
                        }
                        else
                        {
                            // Get the elapsed
                            elapsed = now - StartTime;
                        }

                        // now format the display
                        hours = Math.Floor(elapsed.TotalHours);
                        minutes = elapsed.Minutes;
                        seconds = elapsed.Seconds;

                        // Ensure minutes and seconds start with a 0
                        minutesText = minutes.ToString("00");
                        secondsText = seconds.ToString("00");

                        // Set the text
                        this.TimerLabel.Text = hours + ":" + minutesText + ":" + secondsText;

                        // Store the last second
                        LastSecond = second;
                    }
                }
                catch (Exception error)
                {
                    // for debugging
                    DebugHelper.WriteDebugError("DisplayTimer_Tick", "TimerDisplay", error);

                    string filePath = Path.Combine(Environment.CurrentDirectory, "log.txt");
                    File.AppendAllText(filePath, error.ToString());
                }
            }
            #endregion
            
            #region TimerDisplay_ForeColorChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Timer Display _ Fore Color Changed
            /// </summary>
            private void TimerDisplay_ForeColorChanged(object sender, EventArgs e)
            {
                
            }
        #endregion

            #region TimerLabel_SizeChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Timer Label _ Size Changed
            /// </summary>
            private void TimerLabel_SizeChanged(object sender, EventArgs e)
            {
               // Only bother if there's text.
                string text = TimerLabel.Text;

                // if there is text
                if (text.Length > 0)
                {
                    int best_size = 100;

                    // See how much room we have, allowing a bit
                    // for the Label's internal margin.
                    int wid = TimerLabel.DisplayRectangle.Width - 3;
                    int hgt = TimerLabel.DisplayRectangle.Height - 3;

                    // Make a Graphics object to measure the text.
                    using (Graphics gr = TimerLabel.CreateGraphics())
                    {
                        for (int i = 1; i <= 100; i++)
                        {
                            using (Font test_font =
                                new Font(TimerLabel.Font.FontFamily, i))
                            {
                                // See how much space the text would
                                // need, specifying a maximum width.
                                SizeF text_size =
                                    gr.MeasureString(text, test_font);
                                if ((text_size.Width > wid) ||
                                    (text_size.Height > hgt))
                                {
                                    best_size = i - 1;
                                    break;
                                }
                            }
                        }
                    }

                    // Use that font size.
                    TimerLabel.Font = new Font(TimerLabel.Font.FontFamily, best_size);
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region Start()
            /// <summary>
            /// returns the
            /// </summary>
            public void Start()
            {
                // now we are running
                Status = TimerStatusEnum.Started;

                // initial value
                StartTime = DateTime.Now;

                // Set the interval to 500
                DisplayTimer.Interval = 500;

                // Start the timer
                DisplayTimer.Start();                
            }
            #endregion
            
            #region Stop()
            /// <summary>
            /// Stops the timer
            /// </summary>
            public void Stop()
            {
                // Set EndTime
                EndTime = DateTime.Now;

                // Stop the timer
                DisplayTimer.Stop();
            }
            #endregion
            
        #endregion

        #region Properties

            #region Elapsed
            /// <summary>
            /// This read only property returns the amount of time (TimeSpan) since StartTime
            /// </summary>
            public TimeSpan Elapsed
            {
                get
                {
                    // return value
                    TimeSpan elapsed = new TimeSpan();
                    
                    // if started
                    if (Status != TimerStatusEnum.NotStarted)
                    {
                        // if finished
                        if (Status == TimerStatusEnum.Finished)
                        {
                            // get the elapsed time
                            elapsed = EndTime - StartTime;
                        }
                        else
                        {
                            // get the elapsed time so far
                            elapsed = DateTime.Now - StartTime;
                        }
                    }

                    // reutrn value
                    return elapsed;
                }
            }
            #endregion

            #region EndTime
            /// <summary>
            /// This property gets or sets the value for 'EndTime'.
            /// </summary>
            public DateTime EndTime
            {
                get { return endTime; }
                set { endTime = value; }
            }
            #endregion
            
            #region LastSecond
            /// <summary>
            /// This property gets or sets the value for 'LastSecond'.
            /// </summary>
            public int LastSecond
            {
                get { return lastSecond; }
                set { lastSecond = value; }
            }
            #endregion
            
            #region Reverse
            /// <summary>
            /// This property gets or sets the value for 'Reverse'.
            /// </summary>
            public bool Reverse
            {
                get { return reverse; }
                set { reverse = value; }
            }
            #endregion
            
            #region StartAtTime
            /// <summary>
            /// This property gets or sets the value for 'StartAtTime'.
            /// </summary>
            public DateTime StartAtTime
            {
                get { return startAtTime; }
                set { startAtTime = value; }
            }
            #endregion
            
            #region StartTime
            /// <summary>
            /// This property gets or sets the value for 'StartTime'.
            /// </summary>
            public DateTime StartTime
            {
                get { return startTime; }
                set { startTime = value; }
            }
            #endregion
            
            #region Status
            /// <summary>
            /// This property gets or sets the value for 'Status'.
            /// </summary>
            public TimerStatusEnum Status
            {
                get { return status; }
                set { status = value; }
            }
            #endregion
            
            #region StopAtZero
            /// <summary>
            /// This property gets or sets the value for 'StopAtZero'.
            /// This only applies when Reverse is true.
            /// </summary>
            public bool StopAtZero
            {
                get { return stopAtZero; }
                set { stopAtZero = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
