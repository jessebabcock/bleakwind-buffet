///Author: Jesse Babcock
///File: OrderSum.cs
///Date: 9/27/20
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSum.xaml
    /// </summary>
    public partial class OrderSum : UserControl, INotifyPropertyChanged
    {

        private string num;

        public event PropertyChangedEventHandler PropertyChanged;

        public String Num
        {
            get => num;
            set
            {
                num = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(num));
            }
        }
        /// <summary>
        /// Initializes order reciept
        /// </summary>
        public OrderSum()
        {
            InitializeComponent();
        }

        
    }
}
