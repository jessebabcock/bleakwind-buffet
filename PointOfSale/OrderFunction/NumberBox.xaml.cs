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
    /// Interaction logic for NumberBox.xaml
    /// </summary>
    public partial class NumberBox : UserControl, INotifyPropertyChanged
    {
        

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(NumberBox), new FrameworkPropertyMetadata(0,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public event PropertyChangedEventHandler PropertyChanged;

        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set 
            { 
                SetValue(ValueProperty, value);
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
            }
        }

        public NumberBox()
        {
            InitializeComponent();
        }

        void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            Value++;
        }

        void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            if(Value > 0) Value--;
        }
    }
}
