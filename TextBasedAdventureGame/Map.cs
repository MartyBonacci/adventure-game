// Marty Bonaccci and Jamie Gavina
// mbonacci@cnm.edu jgavina@cnm.edu
// Map.sc

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace TextBasedAdventureGame
{
    /// <summary>
    /// Represents the game map, including locations and the player's position.
    /// </summary>
    public class Map
    {
        #region Properties
        /// <summary>
        /// Gets or sets the list of map locations.
        /// </summary>
        public List<MapLocation> Locations { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="Map"/> class and creates the game map.
        /// </summary>
        public Map()
        {
            // Create map locations
            Locations = new List<MapLocation>();

            // Add locations with items
            Locations.Add(new MapLocation("You are at the village entrance. A broken sign reads 'Beware'.")
            { Items = new List<GameObject> { new PortableHidingPlace("Rusty Lantern", 1) } });

            Locations.Add(new MapLocation("You are in the abandoned marketplace. Stalls are covered in dust.")
            { Items = new List<GameObject> { new PortableHidingPlace("Old Coin", 1) } });

            Locations.Add(new MapLocation("You are in the blacksmith's forge. Tools are scattered everywhere.")
            { Items = new List<GameObject> { new PortableHidingPlace("Toolbox", 2, new PortableHidingPlace("Ancient Key", 1)) } });

            Locations.Add(new MapLocation("You are in the village square. A fountain stands dry.")
            { Items = new List<GameObject> { new PortableHidingPlace("Fountain Stone", 5) } });

            Locations.Add(new MapLocation("You are in the library. Bookshelves are toppled over.")
            { Items = new List<GameObject> { new HidingPlace("Secret Compartment", new HidingPlace("Cursed Tome", null)) } });

            Locations.Add(new MapLocation("You are in the chapel. Candles are melted to stubs.")
            { Items = new List<GameObject> { new PortableHidingPlace("Silver Cross", 2) } });

            Locations.Add(new MapLocation("You are in the graveyard. Tombstones are cracked and overgrown.")
            { Items = new List<GameObject> { new PortableHidingPlace("Gravedigger's Shovel", 3, new PortableHidingPlace("Buried Amulet", 1)) } });

            Locations.Add(new MapLocation("You are in the watchtower. The view is obscured by fog.")
            { Items = new List<GameObject> { new PortableHidingPlace("Broken Telescope", 3) } });

            Locations.Add(new MapLocation("You are in the alchemist's lab. Strange potions bubble.")
            { Items = new List<GameObject> { new HidingPlace("Potion Cabinet", new PortableHidingPlace("Elixir of Life", 1)) } });

            Locations.Add(new MapLocation("You are in the cursed manor. Shadows move on their own.")
            { Items = new List<GameObject> { new PortableHidingPlace("Locked Chest", 3, new PortableHidingPlace("Family Heirloom", 1)) } });

            // Add travel options to each map location
            Locations[0].TravelOptions.Add(new TravelOption("The marketplace is to the north.", Locations[1]));
            Locations[1].TravelOptions.Add(new TravelOption("The village entrance is to the south.", Locations[0]));
            Locations[1].TravelOptions.Add(new TravelOption("The blacksmith's forge is to the east.", Locations[2]));
            Locations[2].TravelOptions.Add(new TravelOption("The marketplace is to the west.", Locations[1]));
            Locations[2].TravelOptions.Add(new TravelOption("The village square is to the north.", Locations[3]));
            Locations[3].TravelOptions.Add(new TravelOption("The forge is to the south.", Locations[2]));
            Locations[3].TravelOptions.Add(new TravelOption("The library is to the east.", Locations[4]));
            Locations[4].TravelOptions.Add(new TravelOption("The village square is to the west.", Locations[3]));
            Locations[4].TravelOptions.Add(new TravelOption("The chapel is to the north.", Locations[5]));
            Locations[5].TravelOptions.Add(new TravelOption("The library is to the south.", Locations[4]));
            Locations[5].TravelOptions.Add(new TravelOption("The graveyard is to the west.", Locations[6]));
            Locations[6].TravelOptions.Add(new TravelOption("The chapel is to the east.", Locations[5]));
            Locations[6].TravelOptions.Add(new TravelOption("The watchtower is to the north.", Locations[7]));
            Locations[7].TravelOptions.Add(new TravelOption("The graveyard is to the south.", Locations[6]));
            Locations[7].TravelOptions.Add(new TravelOption("The alchemist's lab is to the east.", Locations[8]));
            Locations[8].TravelOptions.Add(new TravelOption("The watchtower is to the west.", Locations[7]));
            Locations[8].TravelOptions.Add(new TravelOption("The cursed manor is to the north.", Locations[9]));
            Locations[9].TravelOptions.Add(new TravelOption("The alchemist's lab is to the south.", Locations[8]));
        }
        #endregion
    }
}
