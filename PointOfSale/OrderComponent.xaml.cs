///Author: Jesse Babcock
///File: OrderComponent.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using PointOfSale.Entree;
using PointOfSale.Sides;
using PointOfSale.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Creates a Menu to be a reference when we traverse
        /// </summary>
        private MenuSelectionComponent Menu;

        /// <summary>
        /// Initialize order 
        /// </summary>
        private Order order;

        private OrderSum reciept;

        /// <summary>
        /// Initializes the order component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            order = new Order();
            this.DataContext = order;
            Menu = new MenuSelectionComponent(this);
            reciept = new OrderSum(this);
            pageDisplay.Child = Menu;
            orderSummary.Child = reciept;
        }

        public void SwapToMenu()
        {
            this.RemoveLogicalChild(this);
            pageDisplay.Child = new MenuSelectionComponent(this);
        }

        public void SwapToParent(DependencyObject target)
        {
            pageDisplay.Child = target as FrameworkElement;
        }
    }
}
