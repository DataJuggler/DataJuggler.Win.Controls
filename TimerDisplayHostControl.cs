

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Win.Controls.Enumerations;
using DataJuggler.UltimateHelper;
using DataJuggler.Win.Controls.Interfaces;

#endregion

namespace DataJuggler.Win.Controls
{

    #region class TimerDisplayHostControl
    /// <summary>
    /// This control is used to host a TimerDisplayControl, and exposes properties
    /// to make it simple to just drop on a form or user control and press start.
    /// </summary>
    public partial class TimerDisplayHostControl : UserControl, ICheckChangedListener
    {
        
        #region Private Variables
        private ThemeEnum theme;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'TimerDisplayHostControl' object.
        /// </summary>
        public TimerDisplayHostControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            /// <summary>
            /// event is fired when On Check Changed
            /// </summary>
            public void OnCheckChanged(LabelCheckBoxControl sender, bool isChecked)
            {
                // if isChecked
                if (isChecked)
                {
                    // location is needed
                    StartAtLabel.Location = new Point(100, 124);

                    // zero out
                    HoursControl.Text = "0";
                    MinutesControl.Text = "0";
                    SecondsControl.Text = "0";

                    // show start at controls
                    StartAtLabel.Visible = true;
                    HoursControl.Visible = true;
                    MinutesControl.Visible = true;
                    SecondsControl.Visible = true;
                }
                else
                {
                    // show start at controls
                    StartAtLabel.Visible = false;
                    HoursControl.Visible = false;
                    MinutesControl.Visible = false;
                    SecondsControl.Visible = false;
                }
            }
            #endregion
            
            #region StartButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'StartButton' is clicked.
            /// </summary>
            private void StartButton_Click(object sender, EventArgs e)
            {
                // if reverse is true
                if (Reverse)
                {
                    // get the current time
                    DateTime now = DateTime.Now;

                    // Set the 
                    DisplayTimer.StartAtTime = now.AddHours(HoursControl.IntValue);
                    DisplayTimer.StartAtTime = now.AddHours(HoursControl.IntValue);
                }

                // Start the timer
                DisplayTimer.Start();
            }
            #endregion
            
            #region StopButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'StopButton' is clicked.
            /// </summary>
            private void StopButton_Click(object sender, EventArgs e)
            {
                // Start the timer
                DisplayTimer.Stop();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Default to Dark Theme
                Theme = ThemeEnum.Dark;

                // Wire up the listener
                ReverseCheckBox.CheckChangedListener = this;

                // not checked
                ReverseCheckBox.Checked = false;

                // Set the location
                StartAtLabel.Location = new Point(100, 124);
            }
            #endregion
        
        #endregion

        #region Properties

            #region Reverse
            /// <summary>
            /// This property gets or sets the value for 'Reverse'.
            /// </summary>
            public bool Reverse
            {
                get
                {
                    // initial value
                    bool reverse = false;
                    
                    // If the ReverseCheckBox object exists
                    if (NullHelper.Exists(ReverseCheckBox))
                    {
                        // set the return value
                        reverse = ReverseCheckBox.Checked;
                    }
                    
                    // return value
                    return reverse;
                }
            }
            #endregion
            
            #region StartTime
            /// <summary>
            /// This read only property returns the value for 'StartTime'.
            /// </summary>
            public DateTime StartTime
            {
                get
                {
                    // initial value
                    DateTime startTime = new DateTime(1, 1, 1900);
                    
                    // If the DisplayTimer object exists
                    if (NullHelper.Exists(DisplayTimer))
                    {
                        // return value
                        startTime = DisplayTimer.StartTime;
                    }
                    
                    // return value
                    return startTime;
                }
            }
            #endregion

            #region ElapsedTime
            /// <summary>
            /// This read only property returns the value for 'ElapsedTime'.
            /// </summary>
            public TimeSpan ElapsedTime
            {
                get
                {
                    // initial value
                    TimeSpan elapsedTime = new TimeSpan();
                    
                    // If the DisplayTimer object exists
                    if (NullHelper.Exists(DisplayTimer))
                    {
                        // return value
                        elapsedTime = DisplayTimer.Elapsed;
                    }
                    
                    // return value
                    return elapsedTime;
                }
            }
            #endregion

            #region EndTime
            /// <summary>
            /// This read only property returns the value for 'EndTime'.
            /// </summary>
            public DateTime EndTime
            {
                get
                {
                    // initial value
                    DateTime endTime = new DateTime(1, 1, 1900);
                    
                    // If the DisplayTimer object exists
                    if (NullHelper.Exists(DisplayTimer))
                    {
                        // return value
                        endTime = DisplayTimer.EndTime;
                    }
                    
                    // return value
                    return endTime;
                }
            }
            #endregion
            
            #region Theme
            /// <summary>
            /// This property gets or sets the value for 'Theme'.
            /// </summary>
            public ThemeEnum Theme
            {
                get { return theme; }
                set 
                {
                    // set the value
                    theme = value;

                    // now set the child properties
                    ReverseCheckBox.Theme = value;
                    HoursControl.Theme = value;
                    MinutesControl.Theme = value;
                    SecondsControl.Theme = value;
                    StartButton.Theme = theme;
                    StopButton.Theme = theme;
                    
                    // label has to be set manually
                    if (theme == ThemeEnum.Dark)
                    {
                        // yellow
                        StartAtLabel.ForeColor = Color.LemonChiffon;
                    }
                    else
                    {   
                        // black
                        StartAtLabel.ForeColor = Color.Black;
                    }
                }
            }
        #endregion

        #endregion

    }
    #endregion

}
