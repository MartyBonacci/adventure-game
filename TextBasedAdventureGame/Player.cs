// Player.cs
/// <summary>
/// Represents the player character in the game
/// </summary>
public class Player
{
    #region Fields
    private readonly int _maxInventorySize;
    private List<GameObject> _inventory = new();
    private MapLocation _location;
    #endregion

    #region Properties
    /// <summary>
    /// Gets the player's current location
    /// </summary>
    public MapLocation Location
    {
        get => _location;
        set => _location = value ?? throw new ArgumentNullException(nameof(value));
    }

    /// <summary>
    /// Gets the player's inventory
    /// </summary>
    public IReadOnlyList<GameObject> Inventory => _inventory.AsReadOnly();

    /// <summary>
    /// Gets the maximum total size of items the player can carry
    /// </summary>
    public int MaxInventorySize => _maxInventorySize;
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for Player
    /// </summary>
    /// <param name="startingLocation">Initial location of the player</param>
    /// <param name="maxInventorySize">Maximum inventory capacity</param>
    public Player(MapLocation startingLocation, int maxInventorySize = 10)
    {
        Location = startingLocation;
        _maxInventorySize = maxInventorySize;
    }
    #endregion

    #region Methods
    /// <summary>
    /// Attempts to pick up an item from the current location
    /// </summary>
    /// <param name="item">Item to pick up</param>
    /// <returns>true if successful, false otherwise</returns>
    public bool PickUp(GameObject item)
    {
        if (!(item is IPortable portable))
            return false;

        Calc();

        if (currentInventorySize + portable.Size > _maxInventorySize)
            return false;

        Location.Items.Remove(item);
        _inventory.Add(item);
        return true;
    }

    /// <summary>
    /// Calculates the inventory size
    /// </summary>
    /// <param name="item">Item to drop</param>
    /// <returns>true if successful, false otherwise</returns>
    private int Calc()
    {
        int currentInventorySize = _inventory.Sum(i => i.size); //is IPortable p ? p.Size : 0);
        return currentInvetorySize;
    }
    /// <summary>
    /// Drops an item from inventory into current location
    /// </summary>
    /// <param name="item">Item to drop</param>
    /// <returns>true if successful, false otherwise</returns>
    public bool Drop(GameObject item)
    {
        if (!_inventory.Contains(item))
            return false;

        Location.Items.Add(item);
        _inventory.Remove(item);
        return true;
    }

    /// <summary>
    /// Searches a container for hidden items
    /// </summary>
    /// <param name="container">Container to search</param>
    /// <returns>Any hidden items found, or null if none</returns>
    public GameObject? Search(GameObject container)
    {
        if (!(container is IHidingPlace hidingPlace))
            return null;

        return hidingPlace.Search();
    }
    #endregion
}
