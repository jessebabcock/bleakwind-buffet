///Author: Jesse Babcock
///File: PrintReciept.cs
///Date: 9/27/20
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data;
using Microsoft.VisualBasic;
using PointOfSale.OrderFunction;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Public class to print the reciept of order
    /// </summary>
    public class PrintReciept
    {
        /// <summary>
        /// private variables to hold info
        /// </summary>
        Order order;
        RegisterFunction register;
        string paymentOption;
        List<string> items;

        /// <summary>
        /// Constructor for cash payment
        /// </summary>
        /// <param name="o"></param>
        /// <param name="cash"></param>
        public PrintReciept(Order o, CashPayScreen cash)
        {
            order = o;
            if (cash.DataContext is RegisterFunction rf) register = rf;
            items = new List<string>();
            GetItems(o.items);
        }

        /// <summary>
        /// Constructor for credit/debit payment
        /// </summary>
        /// <param name="o"></param>
        /// <param name="payment"></param>
        public PrintReciept(Order o, string payment)
        {
            order = o;
            paymentOption = payment;
            items = new List<string>();
            GetItems(o.items);
        }

        /// <summary>
        /// Gets the list of items from the order
        /// </summary>
        /// <param name="list"></param>
        void GetItems(List<IOrderItem> list)
        {
            items.Add($"Order Number: {order.Number}");
            items.Add($"Time: {DateAndTime.Now}");
            foreach (IOrderItem item in list)
            {
                items.Add(item.ToString());
                foreach(string special in item.SpecialInstructions)
                {
                    items.Add(special);
                }
                items.Add($"Price: ${item.Price}");
            }
            items.Add($"Subtotal: ${order.SubTotal}");
            items.Add($"Tax: ${order.Tax}");
            items.Add($"Total: ${order.Total}");
            if(paymentOption != null)
            {
                if(paymentOption == "Credit")
                {
                    items.Add("Payment: Credit");
                }
                else
                {
                    items.Add("Payment: Debit");
                }
            }
            else
            {
                items.Add("Payment: Cash");
                items.Add($"Cash owed: ${register.AmountOwe}");
            }
        }

        /// <summary>
        /// Prints the things needed for the reciept
        /// </summary>
        public void printItems()
        {
            foreach(string line in items)
            {
                if (line.Length < 40) RecieptPrinter.PrintLine(line);
                else RecieptPrinter.CutTape();
            }
            RecieptPrinter.CutTape();
        }
    }
}
