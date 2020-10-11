///Author: Jesse Babcock
///File: CustomizationSmokehouse.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
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
    /// Interaction logic for CustomizationSmokehouse.xaml
    /// </summary>
    public partial class CustomizationSmokehouse : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        SmokehouseSkeleton skel;

        /// <summary>
        /// Initializes Smokehouse Skeleton customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomizationSmokehouse(OrderComponent oc, SmokehouseSkeleton ss)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Smokehouse Skeleton";
            o = oc;
            skel = ss;
            DataContext = o;
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
                order.Add(skel);
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
    }
}
