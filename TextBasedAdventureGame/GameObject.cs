using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// GameObject.cs
/// <summary>
/// Base class for all objects in the game world
/// </summary>
public abstract class GameObject
{
    #region Fields
    private string _description;
    #endregion

    #region Properties
    /// <summary>
    /// Description of the object
    /// </summary>
    public virtual string Description
    {
        get => _description;
        protected set => _description = value;
    }
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor for GameObject
    /// </summary>
    /// <param name="description">Description of the object</param>
    protected GameObject(string description)
    {
        _description = description ?? throw new ArgumentNullException(nameof(description));
    }
    #endregion

    #region Methods
    /// <summary>
    /// Returns a string representation of the object
    /// </summary>
    /// <returns>String representation</returns>
    public override string ToString() => Description;
    #endregion
}