///Author: Jesse Babcock
///File: CustomDragonbornWaffleFries.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Side;
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

namespace PointOfSale.Sides
{
    /// <summary>
    /// Interaction logic for CustomDragonbornWaffleFries.xaml
    /// </summary>
    public partial class CustomDragonbornWaffleFries : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        DragonbornWaffleFries fries;

        /// <summary>
        /// Initializes Dragonborn Waffle Fries customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomDragonbornWaffleFries(OrderComponent oc, DragonbornWaffleFries dwf)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Dragonborn Waffle Fries";
            o = oc;
            fries = dwf;
            DataContext = fries;
        }

        /// <summary>
        /// Done click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, RoutedEventArgs e)
        {
            if(o.DataContext is Order order)
            {
                order.Add(fries);
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
            if (fries.Size == BleakwindBuffet.Data.Enums.Size.Small)
            {
                smallBox.IsChecked = true;
            }
            else if (fries.Size == BleakwindBuffet.Data.Enums.Size.Medium)
            {
                mediumBox.IsChecked = true;
            }
            else
            {
                largeBox.IsChecked = true;
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
                fries.Size = BleakwindBuffet.Data.Enums.Size.Small;
                smallBox.IsChecked = true;
            }
            else if (mediumBox.IsChecked == true)
            {
                fries.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                mediumBox.IsChecked = true;
            }
            else if (largeBox.IsChecked == true)
            {
                fries.Size = BleakwindBuffet.Data.Enums.Size.Large;
                largeBox.IsChecked = true;
            }
        }
    }
}
