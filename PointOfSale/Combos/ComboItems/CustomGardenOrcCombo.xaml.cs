///Author: Jesse Babcock
///File: CustomMarkarthMilk.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
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

namespace PointOfSale.Combos.ComboItems
{
    /// <summary>
    /// Interaction logic for CustomMarkarthMilk.xaml
    /// </summary>
    public partial class CustomGardenOrcCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        GardenOrcOmelette gard;
        CustomOmeletteCombo co;
        /// <summary>
        /// Initializes Markarth Milk customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomGardenOrcCombo(OrderComponent oc, GardenOrcOmelette orc, CustomOmeletteCombo combo)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Garden Orc Omelette";
            o = oc;
            co = combo;
            gard = orc;
            DataContext = gard;
        }

        /// <summary>
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
            gard = new GardenOrcOmelette();
            Swap();
        }

        /// <summary>
        /// Sets the order control UI back to the Menu screen
        /// </summary>
        void Swap()
        {
            this.RemoveLogicalChild(this);
            o.SwapToParent(co);
        }
    }
}
