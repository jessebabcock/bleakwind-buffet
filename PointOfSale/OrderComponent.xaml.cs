///Author: Jesse Babcock
///File: OrderComponent.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
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
using PointOfSale.Entree;
using PointOfSale.Sides;
using PointOfSale.Drinks;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Creates a Menu to be a reference when we traverse
        /// </summary>
        public MenuSelectionComponent Menu = new MenuSelectionComponent();

        /// <summary>
        /// Initialize order reciept
        /// </summary>
        private OrderSum order = new OrderSum();

        /// <summary>
        /// Keeps track of order number
        /// </summary>
        private int orderNum = 1;

        /// <summary>
        /// Initializes the order component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
            order.orderNumber.Text = $"Order# {orderNum}";
            pageDisplay.Child = Menu;
            Menu.ItemSelected += NewOrderClick;
        }

       /// <summary>
       /// Checks the click items for its type and changes screens
       /// based on what it is and increased order number
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        void NewOrderClick(object sender, MenuSelectionItemEventArgs e)
        {
            orderNum++;
            if(e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entree.Entree)))
            {
                if (e.Item is BriarheartBurger) pageDisplay.Child = new CustomizationBriarheartBurger(this);
                else if (e.Item is DoubleDraugr) pageDisplay.Child = new CustomizationDrauger(this);
                else if (e.Item is GardenOrcOmelette) pageDisplay.Child = new CustomizationGardenOrc(this);
                else if (e.Item is PhillyPoacher) pageDisplay.Child = new CustomizationPhilly(this);
                else if (e.Item is SmokehouseSkeleton) pageDisplay.Child = new CustomizationSmokehouse(this);
                else if (e.Item is ThalmorTriple) pageDisplay.Child = new CustomizationThalmor(this);
                else if (e.Item is ThugsTBone) pageDisplay.Child = new CustomizationThugsTBone(this);
            }
            else if (e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
            {
                if (e.Item is SailorSoda) pageDisplay.Child = new CustomSailorSoda(this);
                else if (e.Item is MarkarthMilk) pageDisplay.Child = new CustomMarkarthMilk(this);
                else if (e.Item is AretinoAppleJuice) pageDisplay.Child = new CustomAretinoAppleJuice(this);
                else if (e.Item is CandlehearthCoffee) pageDisplay.Child = new CustomCandlehearthCoffee(this);
                else if (e.Item is WarriorWater) pageDisplay.Child = new CustomWarriorWater(this);
            }
            else if (e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Side.Side)))
            {
                if (e.Item is VokunSalad) pageDisplay.Child = new CustomVokunSalad(this);
                else if (e.Item is FriedMiraak) pageDisplay.Child = new CustomFriedMiraak(this);
                else if (e.Item is MadOtarGrits) pageDisplay.Child = new CustomMadOtarGrits(this);
                else if (e.Item is DragonbornWaffleFries) pageDisplay.Child = new CustomDragonbornWaffleFries(this);
            }
        }
    }
}
