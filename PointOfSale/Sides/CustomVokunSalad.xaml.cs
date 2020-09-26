///Author: Jesse Babcock
///File: CustomVokunSalad.cs
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
    /// Interaction logic for CustomVokunSalad.xaml
    /// </summary>
    public partial class CustomVokunSalad : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        /// <summary>
        /// Initializes Vokun Salad customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomVokunSalad(OrderComponent oc)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Vokun Salad";
            o = oc;
        }

        /// <summary>
        /// Done click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoneClick(object sender, EventArgs e)
        {
            MenuScreen();
        }

        /// <summary>
        /// Cancel click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelClick(object sender, EventArgs e)
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
