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
    public partial class CustomOmeletteCombo : UserControl
    {
        OrderComponent o;
        MarkarthMilk mm;
        GardenOrcOmelette orc;
        VokunSalad sal;
        Combo combo;
        public CustomOmeletteCombo(OrderComponent oc)
        {
            InitializeComponent();
            o = oc;
            mm = new MarkarthMilk();
            orc = new GardenOrcOmelette();
            sal = new VokunSalad();
            combo = new Combo(orc, sal, mm);
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

        void GardenClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomGardenOrcCombo(o, orc, this);
        }

        void MilkClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomMilkCombo(o, mm, this);
        }

        void SaladClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomVokunCombo(o, sal, this);
        }
    }
}
