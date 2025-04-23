// Marty Bonaccci and Jamie Gavina
// mbonacci@cnm.edu jgavina@cnm.edu
// TravelWindow.xaml.cs
// User interface that provides user capability to travel
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace TextBasedAdventureGame
{
    public partial class TravelWindow : Window
    {
        private Map game;
        private Player player;

        public TravelWindow()
        {
            InitializeComponent();
            game = new Map();
            player = new Player(game.Locations[0]);
            DisplayLocation();
        }

        private void DisplayLocation()
        {
            txbLocationDescription.Text = player.Location.Description;
            lbTravelOptions.ItemsSource = player.Location.TravelOptions;
            lbItems.ItemsSource = player.Location.Items;
            lbInventory.ItemsSource = player.Inventory;
        }

        private void lbTravelOptions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TravelOption to = (TravelOption)lbTravelOptions.SelectedItem;
            player.Location = to.Location;
            DisplayLocation();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if (lbItems.SelectedItem is IHidingPlace hidingPlace)
            {
                var foundObject = hidingPlace.Search();
                if (foundObject != null)
                {
                    player.Location.Items.Add(foundObject);
                    lbGameStatus.Items.Add($"You found: {foundObject.Description}");
                    lbInventory.Items.Refresh();
                    lbItems.Items.Refresh();
                }
                else
                {
                    lbGameStatus.Items.Add("Nothing was found.");
                }
                DisplayLocation();
            }
        }

        private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            if (lbItems.SelectedItem is IPortable portableItem)
            {
                if (player.PickUp(portableItem))
                {
                    player.Location.Items.Remove((GameObject)portableItem);
                    lbGameStatus.Items.Add($"You took: {portableItem.ToString()}");
                    lbInventory.Items.Refresh();
                    lbItems.Items.Refresh();
                }
                else
                {
                    lbGameStatus.Items.Add("Not enough space in inventory.");
                    lbGameStatus.Items.Refresh();
                }
                //DisplayLocation();
            }
            else if (lbItems.SelectedItem is GameObject gameObject)
            {
                lbGameStatus.Items.Add($"You cannot take {gameObject.ToString()}");
            }

        }

        private void btnDrop_Click(object sender, RoutedEventArgs e)
        {
            if (lbInventory.SelectedItem is IPortable portableItem)
            {
                player.Drop(portableItem);
                player.Location.Items.Add((GameObject)portableItem);
                lbGameStatus.Items.Add($"You dropped: {portableItem.ToString()}");
                lbInventory.Items.Refresh();
                lbItems.Items.Refresh();
                //DisplayLocation();
            }
        }
    }
}


