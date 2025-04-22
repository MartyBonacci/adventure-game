using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// IPortable.cs
/// <summary>
/// Interface for objects that can be carried in inventory
/// </summary>
public interface IPortable
{
    #region Properties
    /// <summary>
    /// Number of inventory slots this item occupies
    /// </summary>
    int Size { get; }
    #endregion
}