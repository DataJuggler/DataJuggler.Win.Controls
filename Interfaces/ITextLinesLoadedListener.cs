

#region using statements

using System.Windows.Forms;
using System.Collections.Generic;
using DataJuggler.UltimateHelper.Objects;

#endregion

namespace DataJuggler.Win.Controls.Interfaces
{

    #region interface ITextLinesLoadedListener
    /// <summary>
    /// This is used by apps that load the FileBrowserForm.
    /// </summary>
    public interface ITextLinesLoadedListener
    {

        #region Methods

            #region OnTextChanged(Control sender, string text);
            /// <summary>
            /// The Selected has changed.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="textLines">The text lines that were loaded. Could be null or empty.</param>
            void OnTextLinesLoaded(Control sender, List<TextLine> textLines);
            #endregion

        #endregion

    } 
    #endregion
    
}
