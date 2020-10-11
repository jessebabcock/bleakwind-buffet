﻿///Author: Jesse Babcock
///File: CustomMarkarthMilk.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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
    public partial class CustomVokunCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        VokunSalad sal;
        CustomOmeletteCombo co;
        /// <summary>
        /// Initializes Markarth Milk customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomVokunCombo(OrderComponent oc, VokunSalad vs, CustomOmeletteCombo combo)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Vokun Salad";
            o = oc;
            co = combo;
            sal = vs;
            DataContext = sal;
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
            sal = new VokunSalad();
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

        /// <summary>
        /// Loads the size into radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeLoader(object sender, RoutedEventArgs e)
        {
            if (sal.Size == BleakwindBuffet.Data.Enums.Size.Small)
            {
                smallBox.IsChecked = true;
            }
            else if (sal.Size == BleakwindBuffet.Data.Enums.Size.Medium)
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
                sal.Size = BleakwindBuffet.Data.Enums.Size.Small;
                smallBox.IsChecked = true;
            }
            else if (mediumBox.IsChecked == true)
            {
                sal.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                mediumBox.IsChecked = true;
            }
            else if (largeBox.IsChecked == true)
            {
                sal.Size = BleakwindBuffet.Data.Enums.Size.Large;
                largeBox.IsChecked = true;
            }
        }
    }
}
