// HidingPlace.cs
/// <summary>
/// Represents objects that can hide other items
/// </summary>
public class HidingPlace : GameObject, IHidingPlace
{
    #region Fields
    private GameObject? _hiddenObject;
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for HidingPlace
    /// </summary>
    /// <param name="description">Description of the hiding place</param>
    public HidingPlace(string description)
        : base(description)
    {
    }
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

    /// <summary>
    /// Sets a new hidden object
    /// </summary>
    /// <param name="obj">Object to hide</param>
    public void HideObject(GameObject obj)
    {
        _hiddenObject = obj;
    }
    #endregion
}
