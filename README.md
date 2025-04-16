# adventure-game
CIS 1280 C# / .NET I 
# Text-Based Adventure Game 
# Objectives


5.1.	Explain and demonstrate how to declare and abstract classes and methods.
5.3.	Explain and demonstrate how to build constructors in derived classes.
5.4.	Explain and demonstrate how to use the is and as operators.
5.5.	Explain and demonstrate polymorphism.
Many others.

## Turn in requirements:
	Please name your Program LastnameP7, such as NelsonP7.

## Program Requirements:
	1.	3 pts Write your name, email address and file name at the top of your source code in a comment.
	2.	5 pts. Put your name and program title in the Text Property of the Form.
	3.	5 pts Use good C# programming style and formatting for your program.
	4.	5 pts Use appropriate comments to explain what you are doing. All public members of your class should use XML commenting (triple slashes). Group all your fields, properties, methods and constructors under #region/#endregion tags. 
	
You have just joined a company called Retro-Games R Us. RGRU tries to recapture the magic of early computer games using newer technology. They have decided to create an engine for building text based adventure games reminiscent of games like Adventure and Zork. You are going to use object oriented principles to build this engine.

To help get you started you have been provided a starter file that already has capability to create a hard-coded map that the player can explore. The programmer that completed the work so far has left RGRU to become a community college instructor. If you have questions about their code maybe you can find their email address in the comments in the code…

## The following classes have been already created for you:
![Map, MapLocation and Travel Option Classes](map-location-travel-option-classes.png)

## Existing MapLocation Class
The MapLocation class has a Description property which describes the location setting this is what will be displayed in the Description TextBox. MapLocation also has a TravelOptions property which is a List of TravelOption objects. MapLocation also has a ToString() method that just returns the Description property. 

The MapLocation’s class has a single parameter constructor that takes a string that will be used to initialize description.

## Existing TravelOption Class
The TravelOption class has a Description property which describes where that travel option leads to. It also has a Location property that is the MapLocation object that that travel option leads to. Again, notice this is not an integer! This is an object reference to the actual MapLocation the travel option leads to. If this doesn’t make sense to you ask me to clarify when you get to that part of your code.

The TravelOption class has a two parameter constructor that will take a string description and a MapLocation object.

## Existing Map Class
The Map class has a Map property that consists of a List of MapLocations. The Map class will also have a property that represents the players MapLocation. Notice we are not using an integer! PlayerLocation is a MapLocation object that is a reference to the MapLocation object in the Map. 

The Map class will have a parameterless constructor that initializes the map. Code to initialize the map will look like:

```csharp
Map = new List<MapLocation>();           
Map.Add(new MapLocation("You are on a road leading to a town."));
	//Etc.
	//Road outside town
Map[0].TravelOptions.Add(new TravelOption("A town is to the west of you.",Map[1]));
	//Etc.
```

## Existing TravelWindow
The TravelWindow has a text box to show a description of the player’s location and a list box to show travel options. It instantiates a new Map object in the TravelWindow() constructor. It then displays the current player location and travel options. The ListBox’s MouseDoubleClick event changes the player location: the code changes the player’s location to the selected travel options MapLocation then just assigns the ListBox’s ItemsSource property to the new Player Location’s TravelOptions list.
![Travel Window](travel-window.png)

## New Code For You to Implement:
### User Stories to Implement:
Your task is to add more capability to this game. Your dev admin asks you to implement the following user stories:
- As a game designer I would like to be able to place game objects in game locations.
- As a game designer I would like to be able to place hidden game objects into other game objects in the scene. 
- As a game designer I would like to be able to designate some items as inventory items that can be picked up.
- As a player I would like to be able to pick up game objects and place them in an inventory.
- As a player I would like to be able to drop items from my inventory a leave them in the current game location.
- As a player I would like to be able to search game objects to see if they contain other game objects.

## You will write the following classes:
![Game Object, IPortable, InventoryItem, IHidingPlace, HidingPlace and PortableHidingPlace Classes](more-classes.png)]

### Game Object:
This is the base class for all objects in the game. All items must have a Description. All items contained in a MapLocation’s items list or in the player inventory should be of this class or inherit from this class. Note that not all GameObjects can be taken into the user’s inventory.

### IPortable Interface:
The IPortable interface must be implemented by objects that can be taken into the player’s inventory. It requires the implementing class to have a Size property that consists of an int that indicates the number of inventory slots taken by the item.

### InventoryItem:
InventoryItem implements the IPortable interface and is basically used for generic items that can be taken into a player’s inventory. Things that might become InventoryItems could be things like pocket lint, backpack, broken rifle etc.

### IHidingPlace: 
Classes implementing IHidingPlace must have a HiddenObject property that contains a GameObject. They also must have a search method that yields the HiddenObject (either randomly or right away).

### HiddingPlace: 
This class inherits from GameObject and implements IHidingPlace. HiddingPlace’s Search method just returns hiddenObject then sets hiddenObject to null.

### Portable Hiding Place:
This class inherits from GameObject and implements both IHidingPlace and IPortable. 

### Player:
![Player Class](player-class.png)]
The player class takes some of the functionality built into the existing form and moves it into a class. The player class has an Inventory property has a List of GameObjects. The class has a MaxInventory property. The sum of the sizes of the elements in inventory should never exceed this property. The player has a Location property which points to a MapLocation. 

The player’s constructor takes one parameter, a MapLocation which is used to set the player’s starting location. The constructor should set starting values for all remaining properties.

### Map, MapLocation and TravelOptions Classes:
These classes are the same as the ones you created in the previous assignment, slightly modified.  
![Map, MapLocation and TravelOption Classes](modified-classes.png)

Be sure to change the namespace if you move them to the new project.  Change the MapLocation class so that it has a List of GameObject Items. 

```csharp
public List<GameObject> Items { get; set; }  
```

Use this class in the map to place objects in the map using code similar to the following:

```csharp
//Add some items. 
Locations[0].Items.Add(new InventoryItem("Broken Rifle"));
            
HidingPlace rock = new HidingPlace("Large Rock");
rock.HiddenObject = new InventoryItem("Snow Globe");
Locations[1].Items.Add(rock);

Locations[2].Items.Add(new PortableHidingPlace("Backpack",1,new InventoryItem("Peanut butter and jelly sandwich")));
```

# IMPORTANT PROGRAM REQUIREMENT:
Your map should have at least 5 locations. Each location should have travel options that move to another. You map should not just be a line - make it interesting. You should have at least 7 objects in your scene. At least one should be a game object that you cannot pick up that is a hiding place that has another game object you can pick up and place in your inventory (implements IHidingPlace but not IPortable). At least one should be a game object you can pick up that also is a hiding place that contains another game object (Implements IHidingPlace and IPortable). At least one should be an inventory item that is not a hiding place (Implements IPortable but not IHidingPlace).
TravelWindow:  
![Travel Window](travel-window-large.png)

Items on the form include:
A Location Description TextBox that describes your current location.
An Items ListBox that lists the items at that location you can take or search.
A Travel Options ListBox displaying the travel options from that location.  Make this large enough so you won’t need two-way scroll bars to read the options.
A Game Status ListBox displaying Game Status messages.
An Inventory ListBox displaying the items in the player’s Inventory.
A search button which allows the player to search the item selected in the Items ListBox.
A take button which allows the player to take the items selected in the Items ListBox and add them to their inventory.
A drop button which allows the player to drop items from their inventory (they will then show up in the Items ListBox for the location.
