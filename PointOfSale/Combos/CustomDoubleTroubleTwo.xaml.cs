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
    public partial class CustomDoubleTroubleTwo : UserControl
    {
        OrderComponent o;
        DoubleDraugr dd;
        AretinoAppleJuice aaj;
        DragonbornWaffleFries dwf;
        Combo combo;
        CustomCombo cust;
        public CustomDoubleTroubleTwo(OrderComponent oc, CustomCombo cc)
        {
            InitializeComponent();
            o = oc;
            dd = new DoubleDraugr();
            aaj = new AretinoAppleJuice();
            dwf = new DragonbornWaffleFries();
            combo = new Combo(dd, dwf, aaj);
            cust = cc;
            DataContext = combo;
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            o.SwapToParent(cust);
        }

        void DoneClick(object sender, RoutedEventArgs e)
        {
            if(o.DataContext is Order order)
            {
                order.Add(combo);
            }
            o.SwapToMenu();
        }

        void DoubleDraghuarClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomDraugrCombo(o, dd, this);
        }

        void AretinoClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomAretinoCombo(o, aaj, this);
        }

        void DragonbornClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomDragonCombo(o, dwf, this);
        }
    }
}
