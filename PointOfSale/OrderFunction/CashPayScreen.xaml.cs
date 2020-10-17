///Author: Jesse Babcock
///File: CashPayScreen.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace PointOfSale.OrderFunction
{
    /// <summary>
    /// Interaction logic for CashPayScreen.xaml
    /// </summary>
    public partial class CashPayScreen : UserControl
    {
        /// <summary>
        /// Private variables for holding
        /// </summary>
        OrderComponent o;
        Order order;
        PrintReciept reciept;

        /// <summary>
        /// Initializes the CashPayScreen 
        /// </summary>
        /// <param name="oc"></param>
        public CashPayScreen(OrderComponent oc)
        {
            InitializeComponent();
            if(oc.DataContext is Order ord)
            {
                order = ord;
            }
            DataContext = new RegisterFunction(order);
            o = oc;
        }

        /// <summary>
        /// Event for the complete order click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CompleteOrderClick(object sender, RoutedEventArgs e)
        {
            reciept = new PrintReciept(order, this);
            reciept.printItems();
            order = new Order();
            o.DataContext = order;
            o.SwapToMenu();
        }

        /// <summary>
        /// Event for cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            o.SwapToMenu();
        }
    }
}
