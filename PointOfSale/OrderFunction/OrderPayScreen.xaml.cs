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
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale.OrderFunction
{
    /// <summary>
    /// Interaction logic for OrderPayScreen.xaml
    /// </summary>
    public partial class OrderPayScreen : UserControl
    {
        OrderComponent o;
        PrintReciept reciept;
        public OrderPayScreen(OrderComponent oc)
        {
            InitializeComponent();
            o = oc;
            DataContext = oc;
        }

        void DebitClick(object sender, RoutedEventArgs e)
        {
            if(o.DataContext is Order order)
            {
                if (CardReader.RunCard(order.Total) == CardTransactionResult.Approved)
                {
                    reciept = new PrintReciept(order, "Debit");
                    reciept.printItems();
                    order = new Order();
                    o.DataContext = order;
                    o.SwapToMenu();
                }
                else
                {
                    order.Clear();
                    o.SwapToMenu();
                }
            }
        }

        void CreditClick(object sender, RoutedEventArgs e)
        {
            if (o.DataContext is Order order)
            {
                if (CardReader.RunCard(order.Total) == CardTransactionResult.Approved)
                {
                    reciept = new PrintReciept(order, "Credit");
                    reciept.printItems();
                    order = new Order();
                    o.DataContext = order;
                    o.SwapToMenu();
                }
                else
                {
                    order.Clear();
                    o.SwapToMenu();
                }
            }
        }

        void CashClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CashPayScreen(o);
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            o.SwapToMenu();
        }
    }
}
