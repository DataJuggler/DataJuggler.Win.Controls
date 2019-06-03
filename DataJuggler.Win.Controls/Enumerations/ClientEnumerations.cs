

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

    #region ThemeEnum
    /// <summary>
    /// This enumeration is for the type of theme to use.
    /// For now there are only two choices, Blue and Dark.
    /// </summary>
    public enum ThemeEnum : int
    {
        Dark = 0,
        Blue = 1
    }
    #endregion

}
