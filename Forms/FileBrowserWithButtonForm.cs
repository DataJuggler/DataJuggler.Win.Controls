

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
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using System.IO;

#endregion

namespace DataJuggler.Win.Controls.Forms
{

    #region class FileBrowserWithButtonForm
    /// <summary>
    /// This is a WindowsForm with a LabelTextBoxControl and a button.
    /// </summary>
    public partial class FileBrowserWithButtonForm : Form, ITextChanged
    {
        
        #region Private Variables
        private string filePath;
        private List<TextLine> textLines;
        private ITextLinesLoadedListener textLinesLoadedListener;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'FileBrowserWithButtonForm' object.
        /// </summary>
        public FileBrowserWithButtonForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // setup the value
                FilePath = text;

                // Enable or disable controls
                UIEnable();
            }
            #endregion

            #region ProcessFileButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ProcessFileButton' is clicked.
            /// </summary>
            private void ProcessFileButton_Click(object sender, EventArgs e)
            {
                // if the value for HasFilePath is true
                if (HasFilePath)
                {
                    // Add file processing here

                    // get the text of the file
                    string fileText = File.ReadAllText(FilePath);

                    // load the text lines
                    List<TextLine> lines = TextHelper.GetTextLines(fileText);

                    // Setup the lines
                    this.TextLines = lines;

                    // if the Listener exists
                    if (HasTextLinesLoadedListener)
                    {
                        // Notify the listener
                        TextLinesLoadedListener.OnTextLinesLoaded(this, lines);
                    }
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the OnTextChanged event
                FileBrowserControl.OnTextChangedListener = this;
                FileBrowserControl.Editable = true;
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// Enables or disables the button.
            /// </summary>
            public void UIEnable()
            {
                // Enable the button
                ProcessFileButton.Enabled = HasFilePath;
            }
            #endregion
            
        #endregion

        #region Properties
            
            #region FilePath
            /// <summary>
            /// This property gets or sets the value for 'FilePath'.
            /// </summary>
            public string FilePath
            {
                get { return filePath; }
                set { filePath = value; }
            }
            #endregion
            
            #region HasFilePath
            /// <summary>
            /// This property returns true if the 'FilePath' exists.
            /// </summary>
            public bool HasFilePath
            {
                get
                {
                    // initial value
                    bool hasFilePath = (!String.IsNullOrEmpty(this.FilePath));
                    
                    // return value
                    return hasFilePath;
                }
            }
        #endregion

            #region HasTextLinesLoadedListener
            /// <summary>
            /// This property returns true if this object has a 'TextLinesLoadedListener'.
            /// </summary>
            public bool HasTextLinesLoadedListener
            {
                get
                {
                    // initial value
                    bool hasTextLinesLoadedListener = (this.TextLinesLoadedListener != null);
                    
                    // return value
                    return hasTextLinesLoadedListener;
                }
            }
            #endregion
            
            #region TextLines
            /// <summary>
            /// This property gets or sets the value for 'TextLines'.
            /// </summary>
            public List<TextLine> TextLines
            {
                get { return textLines; }
                set { textLines = value; }
            }
            #endregion
            
            #region TextLinesLoadedListener
            /// <summary>
            /// This property gets or sets the value for 'TextLinesLoadedListener'.
            /// </summary>
            public ITextLinesLoadedListener TextLinesLoadedListener
            {
                get { return textLinesLoadedListener; }
                set { textLinesLoadedListener = value; }
            }
            #endregion
            
        #endregion
    }
    #endregion

}
