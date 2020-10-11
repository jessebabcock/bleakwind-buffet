///Author: Jesse Babcock
///File: CustomSailorSoda.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomCandlehearthCoffee.xaml
    /// </summary>
    public partial class CustomSailorSoda : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        SailorSoda soda;

        /// <summary>
        /// Initializes Sailor Soda customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomSailorSoda(OrderComponent oc, SailorSoda ss)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Sailor Soda";
            o = oc;
            soda = ss;
            DataContext = soda;
        }

        /// <summary>
        /// Done click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, RoutedEventArgs e)
        {
            if (o.DataContext is Order order)
            {
                order.Add(soda);
            }
            MenuScreen();
        }

        /// <summary>
        /// Cancel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            MenuScreen();
        }

        /// <summary>
        /// Sets the order control UI back to the Menu screen
        /// </summary>
        void MenuScreen()
        {
            o.SwapToMenu();
        }

        /// <summary>
        /// Loads the size into radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeLoader(object sender, RoutedEventArgs e)
        {
            if (soda.Size == BleakwindBuffet.Data.Enums.Size.Small)
            {
                smallBox.IsChecked = true;
            }
            else if (soda.Size == BleakwindBuffet.Data.Enums.Size.Medium)
            {
                mediumBox.IsChecked = true;
            }
            else
            {
                largeBox.IsChecked = true;
            }

            if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry)
            {
                blackberry.IsChecked = true;
            }
            else if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Cherry)
            {
                cherry.IsChecked = true;
            }
            else if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Lemon)
            {
                lemon.IsChecked = true;
            }
            else if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit)
            {
                grapefruit.IsChecked = true;
            }
            else if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Peach)
            {
                peach.IsChecked = true;
            }
            else if (soda.Flavor == BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon)
            {
                watermelon.IsChecked = true;
            }
        }

        /// <summary>
        /// Checks to make sure the user can only select one size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckSize(object sender, RoutedEventArgs e)
        {
            if (smallBox.IsChecked == true)
            {
                soda.Size = BleakwindBuffet.Data.Enums.Size.Small;
                smallBox.IsChecked = true;
            }
            else if (mediumBox.IsChecked == true)
            {
                soda.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                mediumBox.IsChecked = true;
            }
            else if (largeBox.IsChecked == true)
            {
                soda.Size = BleakwindBuffet.Data.Enums.Size.Large;
                largeBox.IsChecked = true;
            }
        }

        /// <summary>
        /// Checks to make sure the user can only select one flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckFlavor(object sender, RoutedEventArgs e)
        {
            if(blackberry.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
                blackberry.IsChecked = true;
            }
            else if (cherry.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                cherry.IsChecked = true;
            }
            else if (lemon.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
                lemon.IsChecked = true;
            }
            else if (grapefruit.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
                grapefruit.IsChecked = true;
            }
            else if (watermelon.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
                watermelon.IsChecked = true;
            }
            else if (peach.IsChecked == true)
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
                peach.IsChecked = true;
            }
            else
            {
                soda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
                cherry.IsChecked = true;
            }
        }
    }
}
