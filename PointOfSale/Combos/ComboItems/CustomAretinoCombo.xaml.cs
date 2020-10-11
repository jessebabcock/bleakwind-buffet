///Author: Jesse Babcock
///File: CustomAretinoCombo.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
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

namespace PointOfSale.Drinks
{
    /// <summary>
    /// Interaction logic for CustomAretinoCombo.xaml
    /// </summary>
    public partial class CustomAretinoCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;
        private AretinoAppleJuice juice;
        CustomDoubleTroubleTwo dtt;

        /// <summary>
        /// Initializes Aretino Apple Juice customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomAretinoCombo(OrderComponent oc, AretinoAppleJuice aaj, CustomDoubleTroubleTwo combo)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Aretino Apple Juice";
            o = oc;
            juice = aaj;
            dtt = combo;
            DataContext = aaj;
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

        /// <summary>
        /// Loads the size into radio button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SizeLoader(object sender, RoutedEventArgs e)
        {
            if(juice.Size == BleakwindBuffet.Data.Enums.Size.Small)
            {
                smallBox.IsChecked = true;
            }
            else if (juice.Size == BleakwindBuffet.Data.Enums.Size.Medium)
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
                juice.Size = BleakwindBuffet.Data.Enums.Size.Small;
                smallBox.IsChecked = true;
            }
            else if (mediumBox.IsChecked == true)
            {
                juice.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                mediumBox.IsChecked = true;
            }
            else if (largeBox.IsChecked == true)
            {
                juice.Size = BleakwindBuffet.Data.Enums.Size.Large;
                largeBox.IsChecked = true;
            }
        }

        /// <summary>
        /// Checks to make sure the user can only select one size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CheckIce(object sender, RoutedEventArgs e)
        {
            if (iceBox.IsChecked == true)
            {
                juice.Ice = true;
            }
        }
    }
}
