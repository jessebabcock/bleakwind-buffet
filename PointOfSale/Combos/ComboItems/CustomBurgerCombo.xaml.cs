///Author: Jesse Babcock
///File: CustomizationBriarheartBurger.cs
///Date: 9/27/2020
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
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

namespace PointOfSale.Combos.ComboItems
{
    /// <summary>
    /// Interaction logic for CustomizationBriarheartBurger.xaml
    /// </summary>
    public partial class CustomBurgerCombo : UserControl
    {
        /// <summary>
        /// Holder for the order control
        /// </summary>
        private OrderComponent o;

        BriarheartBurger burger;
        SailorSpecial combo;
        /// <summary>
        /// Initializes Briarheart Burger customization
        /// </summary>
        /// <param name="oc">Order control we are currently in</param>
        public CustomBurgerCombo(OrderComponent oc, BriarheartBurger burg, SailorSpecial ss)
        {
            InitializeComponent();
            orderItem.Text = "Customizing Briarheart Burger";
            o = oc;
            burger = burg;
            combo = ss;
            DataContext = burger;
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
            burger = new BriarheartBurger();
            Swap();
        }

        /// <summary>
        /// Sets the order control UI back to the Menu screen
        /// </summary>
        void Swap()
        {
            this.RemoveLogicalChild(this);
            o.SwapToParent(combo);
        }
    }
}
