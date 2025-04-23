using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// HidingPlace.cs
/// <summary>
/// Represents objects that can hide other items
/// </summary>
public class HidingPlace : GameObject, IHidingPlace
{
    #region Fields
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for HidingPlace
    /// </summary>
    /// <param name="description">Description of the hiding place</param>
    public HidingPlace(string description, GameObject hiddenObject)
        : base(description)
    {
        HiddenObject = hiddenObject;
    }
    #endregion

    #region IHidingPlace Implementation
    /// <summary>
    /// Gets the currently hidden object
    /// </summary>
    public GameObject HiddenObject { get; private set; }

    /// <summary>
    /// Searches for and returns any hidden object
    /// </summary>
    /// <returns>The hidden object, or null if none found</returns>
    public GameObject Search()
    {
        var foundObject = HiddenObject;
        HiddenObject = null;
        return foundObject!;
    }

    /// <summary>
    /// Sets a new hidden object
    /// </summary>
    /// <param name="obj">Object to hide</param>
    public void HideObject(GameObject obj)
    {
        HiddenObject = obj;
    }
    #endregion
}
