# News

9.24.2023: The TabHostControl now has a ButtonLabelColor property must be passed in to the
AddTabButton method.

8.13.2023: DataJuggler.UltimateHelper was updated.

# DataJuggler.Win.Controls

DataJuggler.Win.Controls is a collection of C# WinForms user controls that make it simple
to build user interfaces.

# List of Classes

# Button

This button is an image button with a few themes.

# LabelCheckBoxControl

The LabelCheckBoxControl consists of a Label and a Checkbox. Set the LabelText, LabelColor and
LabelWidth properties to control its appearnce. 

# LabelComboBoxControl

The LabelComboBoxControl consists of a Label and a ComboBox. Set the LabelText, LabelColor and
LabelWidth properties to control its appearnce. The LoadItems method can load a list of objects or
an enumeration can be loaded.

# LabelLabelControl

The LabelLabelControl consists of a Label and a value Label. Both labels can be customized. 

# LabelTextBoxBrowserControl

The LabelTextBoxBrowserControl consists of a Label, a TextBox and a button.
Switch the BrowseType to File, Folder or Custom. 

# LabelTextBoxControl

 The LabelTextBoxControl consists of a Label and a TextBox. You can customize the appearance of
the Label and TextBox.

# ListEditorControl

The ListEditorControl is used to edit a list of objects. This control uses interfaces to create
methods for Add, Edit and Delete.

# SaveCancelControl

This control contains a Save button and a Cancel button.

# TabButton

Divide the interface up into Tabs, and use this button to change tabs.

# TabHostControl

9.25.2023: I made a short video on how to setup and use the TabHostControl

C# How to use the Tab Control of DataJuggler Win Controls
https://youtu.be/WFQcAlYt2F4

Instructions for use

Add NuGet package DataJuggler.Win.Controls to your project, and using statements to your form for:

    using DataJuggler.Win.Controls;
	using DataJuggler.Win.Controls.Interfaces;

Next, have your form implement ITabHostParent interface. To see a working example, visit this project:

Random USD (a work in progress, but the TabHostControl works).
https://github.com/DataJuggler/RandomUSD

After you add the interface for ITabHostParent to your project, right click and select 'Implement Interface', and
two events will be added to your project. Make sure to add your buttons in reverse order, as the way Dock.Left works
your buttons will display last first.

	private void TabHostControl_Load(object sender, EventArgs e)
    {
        // Setup the TabHostControl
        TabHostControl.AddTabButton(3, "Materials", 200, Color.Black, false);
        TabHostControl.AddTabButton(2, "Props", 200, Color.Black, false);
        TabHostControl.AddTabButton(1, "Scenes", 200, Color.Black, true);
        TabHostControl.TopMargin = 16;
        TabHostControl.LeftMargin = 8;

        // Setup the Parent
        TabHostControl.TabHostParent = this;
    }

	public void TabSelected(TabButton selectedButton)
    {
		// If the selectedButton object exists
        if (NullHelper.Exists(selectedButton))
        {
            switch (selectedButton.ButtonNumber)
            {
                case 1:

                    // setup for Scenes
                    UIVisibility(ScreenTypeEnum.Scenes);

                    // required
                    break;

                case 2:

                    // setup for Props
                    UIVisibility(ScreenTypeEnum.Props);

                    // required
                    break;

                case 3:
				
					// setup for Materials
                    UIVisibility(ScreenTypeEnum.Materials);

                    // required
                    break;
            }
        }
    }

# TabImagesControl (Needs to be updated probably)

This control is used to host an enabled state image and a disabled state image.

# TimerDisplay

The Timer Display is used to display time such as a count down timer.

# TimerDisplayHost

Contains some controls to setup the TimerDisplay control. 


