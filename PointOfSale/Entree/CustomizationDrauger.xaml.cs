///Author: Jesse Babcock
///File: CustomizationDrauger.cs
///Date: 9/27/2020
using BleakwindBuffet.Data.Entree;
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

namespace PointOfSale.Entree
{
    /// <summary>
    /// Interaction logic for CustomizationDrauger.xaml
    /// </summary>
    public partial class CustomizationDrauger : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        /// <summary>
        /// Initializes Double Drauger customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomizationDrauger(OrderComponent oc, DoubleDraugr dd)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Double Drauger";
            o = oc;
            DataContext = dd;
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
    }
}
