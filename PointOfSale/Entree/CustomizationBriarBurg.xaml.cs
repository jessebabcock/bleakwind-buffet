///Author: Jesse Babcock
///File: CustomizationMenu.cs
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

namespace PointOfSale.Entree
{
    /// <summary>
    /// Interaction logic for CustomizationMenu.xaml
    /// </summary>
    public partial class CustomizationMenu : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        /// <summary>
        /// Initializes Briarheart Burger customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomizationMenu(OrderComponent oc)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Briarheart Burger";
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
        /// Sets the order control UI back to the menu screen
        /// </summary>
        void MenuScreen()
        {
            o.pageDisplay.Child = o.menu;
        }
    }
}
