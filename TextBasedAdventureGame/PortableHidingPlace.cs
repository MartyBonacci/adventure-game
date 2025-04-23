using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// PortableHidingPlace.cs
/// <summary>
/// Represents portable containers that can hold items
/// Implements both IPortable and IHidingPlace interfaces
/// </summary>
public class PortableHidingPlace : GameObject, IPortable, IHidingPlace
{
    #region Fields
    private readonly int _size;
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for PortableHidingPlace
    /// </summary>
    /// <param name="description">Description of the container</param>
    /// <param name="size">Number of inventory slots occupied</param>
    /// <param name="initialContents">Initial hidden object</param>
    public PortableHidingPlace(string description, int size, GameObject initialContents = null)
        : base(description)
    {
        _size = size;
        HiddenObject = initialContents;
    }
    #endregion

    #region IPortable Implementation
    /// <summary>
    /// Gets the number of inventory slots this item occupies
    /// </summary>
    public int Size => _size;
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
    #endregion
}
