///Author: Jesse Babcock
///File: OrderSum.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using PointOfSale.Combos;
using PointOfSale.Drinks;
using PointOfSale.Entree;
using PointOfSale.Sides;
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
    public partial class OrderSum : UserControl
    { 
        private Order order;
        private OrderComponent oc;

        /// <summary>
        /// Initializes order summary
        /// </summary>
        public OrderSum(OrderComponent component)
        {
            InitializeComponent();
            order = (Order)component.DataContext;
            oc = component;
        }

        void CompleteOrderClick(object sender, RoutedEventArgs e)
        {
            order = new Order();
            oc.DataContext = order;
            oc.SwapToMenu();
        }

        void RemoveOrderClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = (IOrderItem)((Button)sender).DataContext;
                int index = orderMenuList.SelectedIndex;
                order.Remove(item, index);
            }
        }

        void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            order.Clear();
        }

        void EditOrderClick(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                var item = ((Button)sender).DataContext;
                int index = orderMenuList.SelectedIndex;
                order.Remove((IOrderItem)item, index);
                if (item is BleakwindBuffet.Data.Entree.Entree)
                {
                    if(item is BleakwindBuffet.Data.Entree.BriarheartBurger burg)
                    {
                        oc.pageDisplay.Child = new CustomizationBriarheartBurger(oc, burg);
                    }
                    else if(item is BleakwindBuffet.Data.Entree.DoubleDraugr dd)
                    {
                        oc.pageDisplay.Child = new CustomizationDrauger(oc, dd);
                    }
                    else if (item is BleakwindBuffet.Data.Entree.GardenOrcOmelette goo)
                    {
                        oc.pageDisplay.Child = new CustomizationGardenOrc(oc, goo);
                    }
                    else if (item is BleakwindBuffet.Data.Entree.PhillyPoacher pp)
                    {
                        oc.pageDisplay.Child = new CustomizationPhilly(oc, pp);
                    }
                    else if (item is BleakwindBuffet.Data.Entree.SmokehouseSkeleton ss)
                    {
                        oc.pageDisplay.Child = new CustomizationSmokehouse(oc, ss);
                    }
                    else if (item is BleakwindBuffet.Data.Entree.ThalmorTriple tt)
                    {
                        oc.pageDisplay.Child = new CustomizationThalmor(oc, tt);
                    }
                    else if (item is BleakwindBuffet.Data.Entree.ThugsTBone ttb)
                    {
                        oc.pageDisplay.Child = new CustomizationThugsTBone(oc, ttb);
                    }
                }
                else if (item is BleakwindBuffet.Data.Side.Side)
                {
                    if (item is BleakwindBuffet.Data.Side.DragonbornWaffleFries dwf)
                    {
                        oc.pageDisplay.Child = new CustomDragonbornWaffleFries(oc, dwf);
                    }
                    else if (item is BleakwindBuffet.Data.Side.FriedMiraak fm)
                    {
                        oc.pageDisplay.Child = new CustomFriedMiraak(oc, fm);
                    }
                    else if (item is BleakwindBuffet.Data.Side.MadOtarGrits mog)
                    {
                        oc.pageDisplay.Child = new CustomMadOtarGrits(oc, mog);
                    }
                    else if (item is BleakwindBuffet.Data.Side.VokunSalad vs)
                    {
                        oc.pageDisplay.Child = new CustomVokunSalad(oc, vs);
                    }
                }
                else if (item is BleakwindBuffet.Data.Combo combo)
                {
                    if (combo.SpecialInstructions.Contains("Garden Orc Omelette"))
                    {
                        oc.pageDisplay.Child = new CustomOmeletteCombo(oc);
                    }
                    else if (item.ToString().Contains("Philly Poacher"))
                    {
                        oc.pageDisplay.Child = new CustomMadPhillyGrits(oc);
                    }
                    else if (combo.SpecialInstructions.Contains("Double Draugr"))
                    {
                        oc.pageDisplay.Child = new CustomDoubleTroubleTwo(oc);
                    }
                    else if (combo.SpecialInstructions.Contains("Briarheart Burger"))
                    {
                        oc.pageDisplay.Child = new SailorSpecial(oc);
                    }
                }
                else
                {
                    if (item is BleakwindBuffet.Data.Drinks.WarriorWater ww)
                    {
                        oc.pageDisplay.Child = new CustomWarriorWater(oc, ww);
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.SailorSoda ss)
                    {
                        oc.pageDisplay.Child = new CustomSailorSoda(oc, ss);
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.CandlehearthCoffee cc)
                    {
                        oc.pageDisplay.Child = new CustomCandlehearthCoffee(oc, cc);
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.MarkarthMilk mm)
                    {
                        oc.pageDisplay.Child = new CustomMarkarthMilk(oc, mm);
                    }
                    else if (item is BleakwindBuffet.Data.Drinks.AretinoAppleJuice aaj)
                    {
                        oc.pageDisplay.Child = new CustomAretinoAppleJuice(oc, aaj);
                    }
                }
            }
        }
    }
}
