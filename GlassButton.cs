

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

#endregion

namespace DataJuggler.Win.Controls
{

    #region class GlassButton
    /// <summary>
    /// This class is another button.
    /// </summary>
    public partial class GlassButton : UserControl
    {
        
        #region Private Variables
        private Color textColor;
        private Color hoverColor;
        private string buttonText;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'GlassButton' object.
        /// </summary>
        public GlassButton()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region Label_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Label _ Enter
            /// </summary>
            private void Label_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;

                // use hover color
                Label.ForeColor = HoverColor;
            }
            #endregion
            
            #region Label_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Label _ Leave
            /// </summary>
            private void Label_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;

                // use text color
                Label.ForeColor = TextColor;
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
                // Default Colors
                HoverColor = Color.LemonChiffon;
                TextColor = Color.GhostWhite;
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region ButtonText
            /// <summary>
            /// This property gets or sets the value for 'ButtonText'.
            /// </summary>
            public string ButtonText
            {
                get { return buttonText; }
                set 
                {
                    // set the value
                    buttonText = value;

                    // Set the LabelText
                    Label.Text = value;
                }
            }
            #endregion
            
            #region HoverColor
            /// <summary>
            /// This property gets or sets the value for 'HoverColor'.
            /// </summary>
            public Color HoverColor
            {
                get { return hoverColor; }
                set { hoverColor = value; }
            }
            #endregion
            
            #region TextColor
            /// <summary>
            /// This property gets or sets the value for 'TextColor'.
            /// </summary>
            public Color TextColor
            {
                get { return textColor; }
                set { textColor = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
