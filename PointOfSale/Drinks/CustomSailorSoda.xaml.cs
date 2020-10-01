///Author: Jesse Babcock
///File: CustomSailorSoda.cs
///Date: 9/27/2020
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

        /// <summary>
        /// Initializes Sailor Soda customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomSailorSoda(OrderComponent oc, SailorSoda ss)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Sailor Soda";
            o = oc;
            DataContext = ss;
        }

        /// <summary>
        /// Done click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, RoutedEventArgs e)
        {
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
            o.pageDisplay.Child = o.Menu;
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
                mediumBox.IsEnabled = false;
                largeBox.IsEnabled = false;
            }
            else if (mediumBox.IsChecked == true)
            {
                smallBox.IsEnabled = false;
                largeBox.IsEnabled = false;
            }
            else if (largeBox.IsChecked == true)
            {
                smallBox.IsEnabled = false;
                mediumBox.IsEnabled = false;
            }
            else
            {
                smallBox.IsEnabled = true;
                mediumBox.IsEnabled = true;
                largeBox.IsEnabled = true;
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
                grapefruit.IsEnabled = false;
                lemon.IsEnabled = false;
                peach.IsEnabled = false;
                watermelon.IsEnabled = false;
                cherry.IsEnabled = false;
            }
            else if (cherry.IsChecked == true)
            {
                grapefruit.IsEnabled = false;
                lemon.IsEnabled = false;
                peach.IsEnabled = false;
                watermelon.IsEnabled = false;
                blackberry.IsEnabled = false;
            }
            else if (lemon.IsChecked == true)
            {
                grapefruit.IsEnabled = false;
                blackberry.IsEnabled = false;
                peach.IsEnabled = false;
                watermelon.IsEnabled = false;
                cherry.IsEnabled = false;
            }
            else if (grapefruit.IsChecked == true)
            {
                blackberry.IsEnabled = false;
                lemon.IsEnabled = false;
                peach.IsEnabled = false;
                watermelon.IsEnabled = false;
                cherry.IsEnabled = false;
            }
            else if (watermelon.IsChecked == true)
            {
                grapefruit.IsEnabled = false;
                lemon.IsEnabled = false;
                peach.IsEnabled = false;
                blackberry.IsEnabled = false;
                cherry.IsEnabled = false;
            }
            else if (peach.IsChecked == true)
            {
                grapefruit.IsEnabled = false;
                lemon.IsEnabled = false;
                blackberry.IsEnabled = false;
                watermelon.IsEnabled = false;
                cherry.IsEnabled = false;
            }
            else
            {
                peach.IsEnabled = true;
                grapefruit.IsEnabled = true;
                lemon.IsEnabled = true;
                blackberry.IsEnabled = true;
                watermelon.IsEnabled = true;
                cherry.IsEnabled = true;
            }
        }
    }
}
