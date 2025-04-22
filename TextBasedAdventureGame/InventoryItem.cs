using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// InventoryItem.cs
/// <summary>
/// Represents items that can be picked up and stored in inventory
/// </summary>
public class InventoryItem : GameObject, IPortable
{
    #region Fields
    private readonly int _size;
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for InventoryItem
    /// </summary>
    /// <param name="description">Description of the item</param>
    /// <param name="size">Number of inventory slots occupied</param>
    public InventoryItem(string description, int size)
        : base(description)
    {
        _size = size;
    }
    #endregion

    #region IPortable Implementation
    /// <summary>
    /// Gets the number of inventory slots this item occupies
    /// </summary>
    public int Size => _size;
    #endregion
}
