///Author: Jesse Babcock
///File: CustomVokunSalad.cs
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
    /// Interaction logic for CustomVokunSalad.xaml
    /// </summary>
    public partial class CustomVokunSalad : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        VokunSalad salad;

        /// <summary>
        /// Initializes Vokun Salad customization.
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomVokunSalad(OrderComponent oc, VokunSalad vs)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Vokun Salad";
            o = oc;
            salad = vs;
            DataContext = salad;
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
                order.Add(salad);
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
            if (salad.Size == BleakwindBuffet.Data.Enums.Size.Small)
            {
                smallBox.IsChecked = true;
            }
            else if (salad.Size == BleakwindBuffet.Data.Enums.Size.Medium)
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
                salad.Size = BleakwindBuffet.Data.Enums.Size.Small;
                smallBox.IsChecked = true;
            }
            else if (mediumBox.IsChecked == true)
            {
                salad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                mediumBox.IsChecked = true;
            }
            else if (largeBox.IsChecked == true)
            {
                salad.Size = BleakwindBuffet.Data.Enums.Size.Large;
                largeBox.IsChecked = true;
            }
        }
    }
}
