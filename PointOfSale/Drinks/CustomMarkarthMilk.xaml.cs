///Author: Jesse Babcock
///File: CustomMarkarthMilk.cs
///Date: 9/27/2020
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
    /// Interaction logic for CustomMarkarthMilk.xaml
    /// </summary>
    public partial class CustomMarkarthMilk : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        /// <summary>
        /// Initializes Markarth Milk customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomMarkarthMilk(OrderComponent oc)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Markarth Milk";
            o = oc;
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
    }
}
