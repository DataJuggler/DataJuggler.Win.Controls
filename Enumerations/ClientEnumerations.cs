

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#endregion

namespace DataJuggler.Win.Controls.Enumerations
{

    #region BrowseTypeEnum : int 
    /// <summary>
    /// This enumeration is used to determine which type of an object is being browsed for
    /// </summary>
    public enum BrowseTypeEnum : int 
    {
        File = 0,
        Folder = 1,
        CustomOpen = 2
    }
    #endregion

    #region CalendarSelectionModeEnum : int
    /// <summary>
    /// This enum is what options are available in the LabelCalendarControl.
    /// </summary>
    public enum CalendarSelectionModeEnum : int
    {
        SelectionAndText = 0,
        SelectionOnly = 1,
        TextOnly = 2
    }
    #endregion

    #region EditModeEnum
    /// <summary>
    /// This mode is used to determine what type of an Edit is taking place.
    /// </summary>
    public enum EditModeEnum
    {
        ReadOnly = 0,
        Add = 1,
        Edit = 2
    }
    #endregion

    #region TimerStatusEnum : int
    /// <summary>
    /// This enum is used with the display timer to signal what state the timed event is.
    /// </summary>
    public enum TimerStatusEnum : int
    {
        NotStarted = 0,
        Started = 1,
        Paused = 2,
        Finished = 3
    }
    #endregion

    #region ThemeEnum
    /// <summary>
    /// This enumeration is for the type of theme to use.
    /// For now there are only two choices, Blue and Dark.
    /// </summary>
    public enum ThemeEnum : int
    {
        Dark = 0,
        Wood = 1,
        Black = 2,
        Glass = 3
    }
    #endregion

}
