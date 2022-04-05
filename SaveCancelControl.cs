

#region using statements

using DataJuggler.UltimateHelper;
using System.ComponentModel;
using System;
using System.Windows.Forms;
using DataJuggler.Win.Controls.Enumerations;
using DataJuggler.Win.Controls.Interfaces;
using System.Drawing;

#endregion

namespace DataJuggler.Win.Controls
{

    #region class SaveCancelControl : UserControl
    /// <summary>
    /// This class is used to Save and Cancel in one control.
    /// </summary>
    public partial class SaveCancelControl : UserControl
    {
    
        #region Private variables
        private bool doneMode;
        private bool showSaveAndCloseButton;
        private bool showSaveButton;
        private bool enableSaveAndCloseButton;
        private bool enableSaveButton;
        private bool enableCancelSaveButton;
        private int saveAndCloseButtonWidth;
        private int saveButtonWidth;
        private int cancelButtonWidth;
        private Color disabledForeColor;                
        private ThemeEnum theme;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'SaveCancelControl' object.
        /// </summary>
        public SaveCancelControl()
        {
            // Create controls
            InitializeComponent();
            
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

            #region Button_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a button becomes enabled or disabled
            /// </summary>
            private void Button_EnabledChanged(object sender, EventArgs e)
            {
                // cast the sender as a button
                Button button = sender as Button;

                // If the button object exists
                if (NullHelper.Exists(button))
                {  
                    // if DarkTheme
                    if (Theme == ThemeEnum.Dark)
                    {
                        // if enabled
                        if (button.Enabled)
                        {
                            // Use the enabled background image
                            button.BackgroundImage = Properties.Resources.BlackButton;
                            button.ForeColor = Color.Black;
                        }
                        else
                        {
                            // Use the enabled background image
                            button.BackgroundImage = Properties.Resources.BlackButtonDisabled;
                            button.ForeColor = DisabledForeColor;
                        }
                    }
                    else
                    {
                        // Wood Theme

                        // if enabled
                        if (button.Enabled)
                        {
                            // Use the enabled background image
                            button.BackgroundImage = Properties.Resources.WoodButtonWidth640;
                            button.ForeColor = Color.Black;
                        }
                        else
                        {
                            // Use the enabled background image
                            button.BackgroundImage = Properties.Resources.WoodButtonWidth640Disabled;
                            button.ForeColor = DisabledForeColor;
                        }
                    }
                }
            }
            #endregion

            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
            #endregion
            
            #region CancelSave_Click(object sender, EventArgs e)
            /// <summary>
            /// The Cancel save button was clicked.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CancelSave_Click(object sender, EventArgs e)
            {
                // if the parent host exists
                if (HasParentHost)
                {
                    // notify the parent hoste to cancel
                    ParentHost.OnCancel();
                }
            }
            #endregion

            #region SaveAndCloseButton_Click(object sender, EventArgs e)
            /// <summary>
            /// The save and close button was clicked.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void SaveAndCloseButton_Click(object sender, EventArgs e)
            {
                // if the parent host exists
                if (HasParentHost)
                {
                    // notify the parent hoste to save
                    ParentHost.OnSave(true);
                }
            } 
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// The Save button was clicked.
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // if the parent host exists
                if (HasParentHost)
                {
                    // notify the parent hoste to save
                    ParentHost.OnSave(false);
                }
            }
            #endregion

        #endregion
        
        #region Methods

            #region FindParentHost()
            /// <summary>
            /// Keep searching objects for parents
            /// </summary>
            /// <returns></returns>
            private ISaveCancelHost FindParentHost()
            {
                // initial value
                ISaveCancelHost parentHost = null;
                
                // try the test
                parentHost = Parent as ISaveCancelHost;
                
                // get the control 
                Control control = Parent as Control;
                
                // if the parentHost has not been found yet
                if (parentHost == null)
                {
                    do
                    {
                        // if the control exists
                        if (control != null)
                        {
                            // test 
                            parentHost = control.Parent as ISaveCancelHost;
                            
                            // if the parent host is set
                            if (parentHost != null)
                            {
                                // break out of the loop
                                break;
                            }
                            
                            // set the new parent
                            control = control.Parent as Control;
                        }
                        else
                        {
                            // break out of loop
                            break;
                        }
                        
                    } while (true);
                }
                
                // return value
                return parentHost;
            } 
            #endregion
        
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // default to not a border style
                BorderStyle = BorderStyle.None;
                CancelSaveButton.Enabled = true;                
                DisabledForeColor = Color.DarkGray;
                Dock = DockStyle.Bottom;
                ShowSaveAndCloseButton = false;
                ShowSaveButton = true;                
                SaveAndCloseButton.TextAlign = ContentAlignment.MiddleCenter;
                SaveButton.TextAlign = ContentAlignment.MiddleCenter;
                CancelSaveButton.TextAlign = ContentAlignment.MiddleCenter;
                CancelButtonWidth = 88;
                SaveButtonWidth = 88;                
                SaveAndCloseButtonWidth = 140;

                // Setup the buttons
                UIEnable();
            }
            #endregion

            #region SetupSaveButton(string buttonText, int width, bool visible = true, bool enabled = true)
            /// <summary>
            /// This method is used to customize the SaveButton
            /// </summary>
            /// <param name="buttonText"></param>
            /// <param name="width"></param>
            public void SetupSaveButton(string buttonText, int width, bool visible = true, bool enabled = true)
            {
                // Setup the SaveButton
                SaveButton.Text = buttonText;
                SaveButton.Width = width;
                SaveButton.Visible = visible;
                SaveButton.Enabled = enabled;

                // Enable controls now that these properties have been set
                UIEnable();
            }
            #endregion

            #region SetupCancelButton(string buttonText, int width, bool visible = true, bool enabled = true)
            /// <summary>
            /// This method is used to customize the CancelButton
            /// </summary>
            /// <param name="buttonText"></param>
            /// <param name="width"></param>
            public void SetupCancelButton(string buttonText, int width, bool visible = true, bool enabled = true)
            {
                // Setup the CancelButton
                CancelSaveButton.Text = buttonText;
                CancelSaveButton.Width = width;
                CancelSaveButton.Visible = visible;
                CancelSaveButton.Enabled = enabled;

                // Enable controls now that these properties have been set
                UIEnable();
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// This method UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Call for each button
                if (ShowSaveAndCloseButton)
                {
                    // Set the SaveAndCloseButton
                    Button_EnabledChanged(SaveAndCloseButton, new EventArgs());
                }

                // if the value for ShowSaveButton is true
                if (ShowSaveButton)
                {
                    // Setup the SaveButton
                    Button_EnabledChanged(SaveButton, new EventArgs());
                }

                // Handle the Cancel / Done Button
                Button_EnabledChanged(CancelSaveButton, new EventArgs());
            }
            #endregion
            
        #endregion

        #region Properties
            
            #region CancelButtonTextAlign
            /// <summary>
            /// This property gets or sets the value for 'CancelButtonTextAlign'.
            /// </summary>
            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public ContentAlignment CancelButtonTextAlign
            {
                get 
                { 
                    // initial value
                    ContentAlignment cancelButtonTextAlign = ContentAlignment.MiddleCenter;

                    // if the CancelSave button exists
                    if (CancelSaveButton != null)
                    {
                        // set the return value
                        cancelButtonTextAlign = CancelSaveButton.TextAlign;
                    }

                    // return value
                    return cancelButtonTextAlign;
                }
                set 
                { 
                    // verify the button exists
                    if (CancelSaveButton != null)
                    {
                        // Set the value
                        CancelSaveButton.TextAlign = value;
                    }
                }
            }
            #endregion
            
            #region CancelButtonWidth
            /// <summary>
            /// This property gets or sets the value for 'CancelButtonWidth'.
            /// </summary>
            public int CancelButtonWidth
            {
                get { return cancelButtonWidth; }
                set 
                { 
                    // set the value
                    cancelButtonWidth = value; 

                    // size the button
                    CancelSaveButton.Width = value;
                }
            }
            #endregion
            
            #region DisabledForeColor
            /// <summary>
            /// This property gets or sets the value for 'DisabledForeColor'.
            /// </summary>
            public Color DisabledForeColor
            {
                get { return disabledForeColor; }
                set 
                { 
                    // set the value
                    disabledForeColor = value;

                    // Enable controls
                    UIEnable();
                }
            }
            #endregion
            
            #region DoneMode
            /// <summary>
            /// When DoneMode is true, the Cancel button changes the caption to Done.
            /// </summary>
            public bool DoneMode
            {
                get { return doneMode; }
                set 
                { 
                    // set the value
                    doneMode = value; 
                    
                    // if done mode
                    if (doneMode)
                    {
                        // set to Cancel
                        CancelSaveButton.Text = "Done";                        
                        CancelSaveButton.TextAlign = ContentAlignment.MiddleCenter;
                    }
                    else
                    {
                        // set to Cancel
                        CancelSaveButton.Text = "Cancel";

                        // Move to the right for the presence of the image
                        CancelSaveButton.TextAlign = ContentAlignment.MiddleRight;
                    }
                }
            } 
            #endregion

            #region EnableCancelSaveButton
            /// <summary>
            /// This property gets or sets the value for 'EnableCancelSaveButton'.
            /// </summary>
            public bool EnableCancelSaveButton
            {
                get { return enableCancelSaveButton; }
                set 
                { 
                    // set the value
                    enableCancelSaveButton = value;

                    // if the cancel button exists
                    if (NullHelper.Exists(CancelSaveButton))
                    {
                        // Set the value
                        CancelSaveButton.Enabled = value;
                    }
                }
            }
            #endregion
            
            #region EnableSaveAndCloseButton
            /// <summary>
            /// This property gets or sets the value for 'EnableSaveAndCloseButton'.
            /// </summary>
            public bool EnableSaveAndCloseButton
            {
                get { return enableSaveAndCloseButton; }
                set 
                { 
                    // set the value
                    enableSaveAndCloseButton = value; 

                    // If the SaveAndCloseButton object exists
                    if (NullHelper.Exists(SaveAndCloseButton))
                    {
                        SaveAndCloseButton.Enabled = value;
                    }
                }
            }
            #endregion
            
            #region EnableSaveButton
            /// <summary>
            /// This property gets or sets the value for 'EnableSaveButton'.
            /// </summary>
            public bool EnableSaveButton
            {
                get { return enableSaveButton; }
                set 
                { 
                    // set the value
                    enableSaveButton = value;

                    // If the SaveButton object exists
                    if (NullHelper.Exists(SaveButton))
                    {   
                        // enable or disable the button
                        SaveButton.Enabled = value;
                    }
                }
            }
            #endregion
            
            #region HasParentHost
            /// <summary>
            /// Does this object have a parent host
            /// </summary>
            public bool HasParentHost
            {
                get
                {
                    // initial value
                    bool hasParentHost = (ParentHost != null);

                    // return value
                    return hasParentHost;
                }
            }
            #endregion

            #region ParentHost
            /// <summary>
            /// The host of this control
            /// </summary>
            public ISaveCancelHost ParentHost
            {
                get
                {
                    // initial value
                    ISaveCancelHost parentHost = FindParentHost();
                    
                    // return value
                    return parentHost;
                }
            }
            #endregion

            #region SaveAndcloseButtonTextAlign
            /// <summary>
            /// This property gets or sets the value for 'SaveAndcloseButtonTextAlign'.
            /// </summary>
            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public ContentAlignment SaveAndcloseButtonTextAlign
            {
                get 
                { 
                    // initial value
                    ContentAlignment saveAndcloseButtonTextAlign = ContentAlignment.MiddleCenter;

                    // if the SaveAndCloseButton exists
                    if (SaveAndCloseButton != null)
                    {
                        // set the return value
                        saveAndcloseButtonTextAlign = SaveAndCloseButton.TextAlign;
                    }

                    // return value
                    return saveAndcloseButtonTextAlign;
                }
                set 
                {
                    // verify the button exists
                    if (SaveAndCloseButton != null)
                    {
                        // Set the value
                        SaveAndCloseButton.TextAlign = value;
                    }
                }
            }
            #endregion

            #region SaveAndCloseButtonWidth
            /// <summary>
            /// This property gets or sets the value for 'SaveAndCloseButtonWidth'.
            /// </summary>
            public int SaveAndCloseButtonWidth
            {
                get { return saveAndCloseButtonWidth; }
                set 
                { 
                    // set the value
                    saveAndCloseButtonWidth = value; 

                    // size the butotn
                    SaveAndCloseButton.Width = value;
                }
            }
            #endregion

            #region SaveButtonTextAlign
            /// <summary>
            /// This property gets or sets the value for 'SaveButtonTextAlign'.
            /// </summary>
            [Browsable(true)]
            [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)] 
            public ContentAlignment SaveButtonTextAlign
            {
                get 
                { 
                    // initial value
                    ContentAlignment saveButtonTextAlign = ContentAlignment.MiddleCenter;

                    // if the SaveButton exists
                    if (SaveButton != null)
                    {
                        // set the return value
                        saveButtonTextAlign = SaveButton.TextAlign;
                    }

                    // return value
                    return saveButtonTextAlign;
                }
                set 
                {
                    // verify the button exists
                    if (SaveButton != null)
                    {
                        // Set the value
                        SaveButton.TextAlign = value;
                    }
                }
            }
            #endregion
            
            #region SaveButtonWidth
            /// <summary>
            /// This property gets or sets the value for 'SaveButtonWidth'.
            /// </summary>
            public int SaveButtonWidth
            {
                get { return saveButtonWidth; }
                set 
                { 
                    // set the value
                    saveButtonWidth = value;

                    // set the width
                    SaveButton.Width = value;
                }
            }
            #endregion
            
            #region ShowSaveAndCloseButton
            /// <summary>
            /// This property gets or sets the value for 'ShowSaveAndCloseButton'.
            /// </summary>
            public bool ShowSaveAndCloseButton
            {
                get { return showSaveAndCloseButton; }
                set 
                { 
                    // set the value
                    showSaveAndCloseButton = value;

                    // Show the button if true
                    SaveAndCloseButton.Visible = value;
                }
            }
            #endregion
            
            #region ShowSaveButton
            /// <summary>
            /// This property gets or sets the value for 'ShowSaveButton'.
            /// </summary>
            public bool ShowSaveButton
            {
                get { return showSaveButton; }
                set 
                { 
                    // set the value
                    showSaveButton = value; 

                    // show the button if true
                    SaveButton.Visible = value;
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

                    // setup the buttons

                    // Enable controls
                    UIEnable();
                }                
            }
        #endregion

        #endregion

    } 
    #endregion
    
}
