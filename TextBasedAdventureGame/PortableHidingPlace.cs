// PortableHidingPlace.cs
/// <summary>
/// Represents portable containers that can hold items
/// Implements both IPortable and IHidingPlace interfaces
/// </summary>
public class PortableHidingPlace : GameObject, IPortable, IHidingPlace
{
    #region Fields
    private readonly int _size;
    private GameObject? _hiddenObject;
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
        _hiddenObject = initialContents;
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
    public GameObject HiddenObject => _hiddenObject;

    /// <summary>
    /// Searches for and returns any hidden object
    /// </summary>
    /// <returns>The hidden object, or null if none found</returns>
    public GameObject Search()
    {
        var foundObject = _hiddenObject;
        _hiddenObject = null;
        return foundObject!;
    }
    #endregion
}
