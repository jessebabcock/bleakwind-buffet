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
    /// Interaction logic for SailorSpecial.xaml
    /// </summary>
    public partial class SailorSpecial : UserControl
    {
        OrderComponent o;
        SailorSoda ss;
        BriarheartBurger bb;
        DragonbornWaffleFries dwf;
        Combo combo;
        public SailorSpecial(OrderComponent oc)
        {
            InitializeComponent();
            o = oc;
            ss = new SailorSoda();
            bb = new BriarheartBurger();
            dwf = new DragonbornWaffleFries();
            combo = new Combo(bb, dwf, ss);
            DataContext = combo;
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            o.SwapToParent(this);
        }

        void DoneClick(object sender, RoutedEventArgs e)
        {
            if (o.DataContext is Order order)
            {
                order.Add(combo);
            }
            o.SwapToMenu();
        }

        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomSailorCombo(o, ss, this);
        }

        void BriarheartburgerClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomBurgerCombo(o, bb, this);
        }

        void DragonbornClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomWaffleFries(o, dwf, this);
        }
    }
}
