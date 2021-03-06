﻿///Author: Jesse Babcock
///File: CustomSailorCombo.cs
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

namespace PointOfSale.Combos.ComboItems
{
    /// <summary>
    /// Interaction logic for CustomSailorCombo.xaml
    /// </summary>
    public partial class CustomSailorCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        SailorSoda soda;
        SailorSpecial combo;

        /// <summary>
        /// Initializes Sailor Soda customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomSailorCombo(OrderComponent oc, SailorSoda ss, SailorSpecial special)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Sailor Soda";
            o = oc;
            soda = ss;
            combo = special;
            DataContext = soda;
        }

        /// <summary>
        /// Done click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, RoutedEventArgs e)
        {
            Swap();
        }

        /// <summary>
        /// Cancel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, RoutedEventArgs e)
        {
            soda = new SailorSoda();
            Swap();
        }

        /// <summary>
        /// Sets the order control UI back to the Menu screen
        /// </summary>
        void Swap()
        {
            this.RemoveLogicalChild(this);
            o.SwapToParent(combo);
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
            if (blackberry.IsChecked == true)
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
