// Marty Bonaccci and Jamie Gavina
// mbonacci@cnm.edu jgavina@cnm.edu
// IPortable.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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