// Marty Bonaccci and Jamie Gavina
// mbonacci@cnm.edu jgavina@cnm.edu
// IHidingPlace.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Interface for objects that can contain hidden items
/// </summary>
public interface IHidingPlace
{
    #region Properties
    /// <summary>
    /// The hidden object contained within
    /// </summary>
    GameObject HiddenObject { get; }
    #endregion

    #region Methods
    /// <summary>
    /// Searches for and returns any hidden object
    /// </summary>
    /// <returns>The hidden object, or null if none found</returns>
    GameObject Search();
    #endregion
}
