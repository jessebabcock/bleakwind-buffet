///Author: Jesse Babcock
///File: CustomDraugrCombo.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;
using PointOfSale.Combos;
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
    /// Interaction logic for CustomDraugrCombo.xaml
    /// </summary>
    public partial class CustomDraugrCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        DoubleDraugr drau;

        CustomDoubleTroubleTwo dtt;

        /// <summary>
        /// Initializes Double Drauger customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomDraugrCombo(OrderComponent oc, DoubleDraugr dd, CustomDoubleTroubleTwo combo)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Double Drauger";
            o = oc;
            drau = dd;
            dtt = combo;
            DataContext = drau;
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
            drau = new DoubleDraugr();
            Swap();
        }

        /// <summary>
        /// Sets the order control UI back to the Menu screen
        /// </summary>
        void Swap()
        {
            this.RemoveLogicalChild(this);
            o.SwapToParent(dtt);
        }
    }
}
