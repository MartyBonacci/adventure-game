   M S B A M L   `   `   `  ����   TextBasedAdventureGame)    #TextBasedAdventureGame.TravelWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$1  +Marty and Jamie's Text Based Adventure Game��$	��500��$	��600��.���  � ColumnDefinitions �� $
��191* ��� $
��409* �.+��� $��Location Description:��$
��Left=�$��	10,10,0,0q�$	��Top=��� -    ��Name$ txbLocationDescription��$
��Left=�$��35��$��	10,30,0,0q�$
��Wrap=�$	��Top=�$	��560��$��2���� $'��!Select an item to search or take.��$
��Left=�$��	10,71,0,0q�$	��Top=��� -    ��Name$ lbItems��$
��Left=�$��69��$��	10,91,0,0q�$	��Top=�$	��270��$��2���� $5��/Click on an option to travel in that direction:��$
��Left=�$��
10,182,0,0q�$	��Top=�$��2���� -   $ lbTravelOptions��$
��Left=�$��69��$��
10,202,0,0q�$	��Top=�$	��270��$��2���� $��Game Status:��$
��Left=�$��
12,305,0,0q�$	��Top=��� -   $ lbGameStatus��$
��Left=�$	��100��$��
10,336,0,0q�$	��Top=�$	��560��$��2���� $%��Inventory: Select item to drop.��$
��Left=�$��
199,66,0,0q�$	��Top=�$��1���� -   $ lbInventory��$
��Left=�$	��180��$��
199,91,0,0q�$	��Top=�$	��176��$��1���� -   $��Search��$
��Left=�$��
109,91,0,0q�$	��Top=�$��80��$��1���� -   $��Take-->��$
��Left=�$��109,133,0,0q�$	��Top=�$��80��$��1���� -   $��<--Drop��$
��Left=�$��109,175,0,0q�$	��Top=�$��80��$��1��