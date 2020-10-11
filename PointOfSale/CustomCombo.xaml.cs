using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using PointOfSale.Combos;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomCombo.xaml
    /// </summary>
    public partial class CustomCombo : UserControl
    {
        OrderComponent o;
        public CustomCombo(OrderComponent oc)
        {
            InitializeComponent();
            o = oc;
        }

        void CancelClick(object sender, RoutedEventArgs e)
        {
            o.SwapToMenu();
        }

        void DoubleTroubleClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomDoubleTroubleTwo(o);
        }

        void MadPhillyClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomMadPhillyGrits(o);
        }

        void OmeletteClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomOmeletteCombo(o);
        }

        void SailorSpecialClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new SailorSpecial(o);
        }
    }
}
