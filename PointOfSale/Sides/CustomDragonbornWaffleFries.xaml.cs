///Author: Jesse Babcock
///File: CustomDragonbornWaffleFries.cs
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

        /// <summary>
        /// Initializes Dragonborn Waffle Fries customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomDragonbornWaffleFries(OrderComponent oc)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Dragonborn Waffle Fries";
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
    }
}
