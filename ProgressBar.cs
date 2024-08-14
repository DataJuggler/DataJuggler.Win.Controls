

#region using statements

using DataJuggler.Win.Controls.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace DataJuggler.Win.Controls
{

    #region class ProgressBar
    /// <summary>
    /// This class is a Windows Forms Proogress Bar that you can change the colors of.
    /// </summary>
    public partial class ProgressBar : UserControl
    {
        
        #region Private Variables
        private const int Mininum = 0;
        private int maximum;
        private int currentValue;
        private Color backgroundColor;
        private bool setOverflowToMax;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'ProgressBar' object.
        /// </summary>
        public ProgressBar()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region CalculateWidth(int currentValue, int maximumValue, int panelWidth)
            /// <summary>
            /// This method calcualtes the width to show
            /// </summary>
            /// <param name="currentValue"></param>
            /// <param name="maximumValue"></param>
            /// <param name="panelWidth"></param>
            /// <returns></returns>
            private int CalculateWidth(int currentValue, int maximumValue)
            {
                // iniitial value
                int width = 0;
                
                // Verify both values are not zero
                if ((this.Width > 0) && (currentValue > 0))
                {
                    // Set the Width
                    width = (this.Width * currentValue) / maximumValue;
                }

                // return value
                return width;
            }
            #endregion
            
            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion

            #region DisplayProgress()
            /// <summary>
            /// Display Progress
            /// </summary>
            public void DisplayProgress()
            {
                int width = CalculateWidth(currentValue, maximum);
                ValuePanel.Width = width;
                ValuePanel.ForeColor = this.ForeColor;
            }
            #endregion
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup for drawiing
                DoubleBuffered = true;
                SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
                SetStyle(ControlStyles.AllPaintingInWmPaint, true);
                SetStyle(ControlStyles.UserPaint, true);

                // Default Color
                ForeColor = Color.DodgerBlue;

                // Set the panel color
                ValuePanel.BackColor = ForeColor;

                // Initial values
                Maximum = 100;
                CurrentValue = 0;

                // Set the Background Color
                BackgroundColor = Color.DarkGray;

                // This defaults to will not error on overflow
                SetOverflowToMax = true;

                // Display Progress
                DisplayProgress();
            }
            #endregion
            
        #endregion

        #region Properties

            #region BackgroundColor
            /// <summary>
            /// This property gets or sets the value for 'BackgroundColor'.
            /// </summary>
            public Color BackgroundColor
            {
                get { return backgroundColor; }
                set { backgroundColor = value; }
            }
            #endregion
            
            #region CurrentValue
            public int CurrentValue
            {
                get { return currentValue; }
                set
                {
                    int newValue = value;
                    if (newValue < 0)
                    {
                        this.BackColor = Color.Tomato; // Indicate not valid value
                        currentValue = 0;
                    }
                    else if (newValue > maximum)
                    {
                        if (setOverflowToMax)
                        {
                            currentValue = maximum;
                        }
                        else
                        {
                            this.BackColor = Color.Tomato; // Indicate not valid value
                            currentValue = newValue;
                        }
                    }
                    else
                    {
                        // Reset
                        this.BackColor = BackgroundColor;
                        currentValue = newValue;
                    }
                    
                    // Redraw the control
                    DisplayProgress();
                }
            }
            #endregion
            
            #region Maximum
            /// <summary>
            /// This property gets or sets the Maximum value for this ProgressBar.
            /// </summary>
            public int Maximum
            {
                get { return maximum; }
                set
                {
                    if (value < 1)
                    {
                        this.BackColor = Color.Tomato; // Indicate not valid maximum
                        maximum = 1;
                    }
                    else
                    {
                        this.BackColor = BackgroundColor; // Reset to default color
                        maximum = value;
                    }

                    // Redraw the control
                    DisplayProgress();
                }
            }
            #endregion
            
            #region SetOverflowToMax
            /// <summary>
            /// This property gets or sets the value for 'SetOverflowToMax'.
            /// </summary>
            public bool SetOverflowToMax
            {
                get { return setOverflowToMax; }
                set { setOverflowToMax = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
