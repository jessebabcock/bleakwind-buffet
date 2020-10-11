using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using PointOfSale.Combos.ComboItems;
using PointOfSale.Drinks;
using PointOfSale.Entree;
using PointOfSale.Sides;
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

namespace PointOfSale.Combos
{
    /// <summary>
    /// Interaction logic for CustomDoubleTroubleTwo.xaml
    /// </summary>
    public partial class CustomMadPhillyGrits : UserControl
    {
        OrderComponent o;
        MadOtarGrits mad;
        CandlehearthCoffee can;
        PhillyPoacher phil;
        Combo combo;
        CustomCombo cust;
        public CustomMadPhillyGrits(OrderComponent oc, CustomCombo cc)
        {
            InitializeComponent();
            o = oc;
            mad = new MadOtarGrits();
            can = new CandlehearthCoffee();
            phil = new PhillyPoacher();
            combo = new Combo(phil, mad, can);
            cust = cc;
            DataContext = combo;
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            o.SwapToParent(cust);
        }

        void DoneClick(object sender, RoutedEventArgs e)
        {
            if (o.DataContext is Order order)
            {
                order.Add(combo);
            }
            o.SwapToMenu();
        }

        void MadClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomMadCombo(o, mad, this);
        }

        void PhillyClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomPhillyCombo(o, phil, this);
        }

        void CandleClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomCandleCombo(o, can, this);
        }
    }
}
