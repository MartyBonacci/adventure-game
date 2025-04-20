# TODO

## General Requirements
- [ ] Add our names, email addresses, and the file name as comments at the top of all source code files.
- [ ] Set our names and program title in the Text Property of the Form.
- [ ] Ensure good C# programming style and formatting.
- [ ] Add appropriate comments, including XML comments for all public members.
- [ ] Use `#region` and `#endregion` tags to group fields, properties, methods, and constructors.

## User Stories
- [ ] Allow game designers to place game objects in game locations.
- [ ] Allow game designers to place hidden game objects into other game objects in the scene.
- [ ] Allow game designers to designate some items as inventory items that can be picked up.
- [ ] Allow players to pick up game objects and place them in an inventory.
- [ ] Allow players to drop items from their inventory and leave them in the current game location.
- [ ] Allow players to search game objects to see if they contain other game objects.

## Classes to Implement
- [ ] **GameObject Class**
  - [ ] Add `Description` property.
  - [ ] Implement `ToString()` method.

- [ ] **IHidingPlace Interface**
  - [ ] Add `HiddenObject` property.
  - [ ] Add `Search()` method.

- [ ] **HidingPlace Class**
  - [ ] Inherit from `GameObject` and implement `IHidingPlace`.
  - [ ] Add `Search()` method to return and remove the hidden object.

- [ ] **IPortable Interface**
  - [ ] Add `Size` property.

- [ ] **InventoryItem Class**
  - [ ] Implement `IPortable` interface.

- [ ] **PortableHidingPlace Class**
  - [ ] Inherit from `GameObject` and implement both `IHidingPlace` and `IPortable`.

- [ ] **Player Class**
  - [ ] Add `Inventory` property (List of `IPortable`).
  - [ ] Add `Location` property (MapLocation).
  - [ ] Add `MaxInventory` property.
  - [ ] Implement methods: `AddInventoryItem`, `RemoveInventoryItem`, and `Calc`.

## Map Enhancements
- [ ] Modify `MapLocation` class to include a `List<GameObject>` for items.
- [ ] Create a map with at least 5 locations and interesting travel options.
- [ ] Add at least 7 objects to the map:
  - [ ] At least one non-pickable hiding place containing a pickable object.
  - [ ] At least one pickable hiding place containing another object.
  - [ ] At least one pickable object that is not a hiding place.

## TravelWindow Enhancements
- [ ] Add a Location Description TextBox to display the current location.
- [ ] Add an Items ListBox to list items at the location.
- [ ] Add a Travel Options ListBox for travel options.
- [ ] Add a Game Status ListBox for game status messages.
- [ ] Add an Inventory ListBox for player inventory.
- [ ] Add a Search button to search selected items.
- [ ] Add a Take button to pick up selected items.
- [ ] Add a Drop button to drop items from inventory.

## Testing
- [ ] Ensure all implemented features work as expected.
- [ ] Verify the map meets the requirements and is engaging.
- [ ] Test all user stories for functionality.
