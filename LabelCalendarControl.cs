

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
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;

#endregion

namespace DataJuggler.Win.Controls
{

    #region class LabelCalendarControl
    /// <summary>
    /// This control consists of a Label, A Textbox, and CalenderControl.
    /// </summary>
    public partial class LabelCalendarControl : LabelTextBoxControl, ITextChanged
    {
        
        #region Private Variables
        private DateTime date;
        private bool userCancelled;        
        private CalendarSelectionModeEnum selectionMode;        
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'LabelCalendarControl' object.
        /// </summary>
        public LabelCalendarControl()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Calendar_DateSelected(object sender, DateRangeEventArgs e)
            /// <summary>
            /// event is fired when Calendar _ Date Selected
            /// </summary>
            private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
            {
                // Set the Date
                this.Date = e.Start;
                TextBox.Text = Date.ToShortDateString();
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                try
                {
                    // Set the Date
                    Date = DateTime.Parse(text);

                    // Setup the Color
                    TextBox.BackColor = Color.White;
                }
                catch (Exception error)
                {
                    // log the error 
                    DebugHelper.WriteDebugError("OnTextChanged", "LabelCalendarControl", error);
                    TextBox.BackColor = Color.Tomato;
                }
            }
            #endregion

            #region SelectionButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SelectionButton' is clicked.
            /// </summary>
            private void SelectionButton_Click(object sender, EventArgs e)
            {
                //// Set the Location                               
                Calendar.Visible = true;                
                Height = 212;
                Calendar.SelectionStart = DateTime.Now;
            }
            #endregion

            #region TextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Text Box _ Text Changed
            /// </summary>
            private new void TextBox_TextChanged(object sender, EventArgs e)
            {
                // if the text starts with default VS named text
                if (TextBox.Text.StartsWith("labelTextBoxControl"))
                {
                    // do not allow default text
                    TextBox.Text = "";
                }

                // if the Listener exists
                if (this.HasOnTextChangedListener)
                {
                    // send the on text changed
                    this.OnTextChangedListener.OnTextChanged(this, this.Text);
                }
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
                // Make sure the size is correct
                SelectionButton.Size = new Size(48, 36);
                SelectionButton.Theme = ThemeEnum.Dark;
                TextBox.Text = "";
                Dock = DockStyle.None;
                Size = new Size(360, 34);
                Theme = ThemeEnum.Dark;
                LabelTextAlign = ContentAlignment.TopRight;
                
                // Wire up the listener
                base.OnTextChangedListener = this;

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {  
                // Enable the button if Selection Mode allows it.
                SelectionButton.Enabled =  ((SelectionMode == CalendarSelectionModeEnum.SelectionAndText) || (SelectionMode == CalendarSelectionModeEnum.SelectionOnly));
                TextBox.Enabled = ((SelectionMode == CalendarSelectionModeEnum.SelectionAndText) || (SelectionMode == CalendarSelectionModeEnum.TextOnly));                                
                Editable = ((SelectionMode == CalendarSelectionModeEnum.SelectionAndText) || (SelectionMode == CalendarSelectionModeEnum.TextOnly));                                
            }
        #endregion

        #endregion

        #region Properties

        #region Date
        /// <summary>
        /// This property gets or sets the value for 'Date'.
        /// </summary>
        [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }
            #endregion
            
            #region SelectionMode
            /// <summary>
            /// This property gets or sets the value for 'SelectionMode'.
            /// </summary>
            public CalendarSelectionModeEnum SelectionMode
            {
                get { return selectionMode; }
                set { selectionMode = value; }
            }
            #endregion
            
            #region UserCancelled
            /// <summary>
            /// This property gets or sets the value for 'UserCancelled'.
            /// </summary>
            public bool UserCancelled
            {
                get { return userCancelled; }
                set { userCancelled = value; }
            }
        #endregion

        #endregion

    }
    #endregion

}
