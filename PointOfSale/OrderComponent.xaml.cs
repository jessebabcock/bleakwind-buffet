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
        public OrderSum order = new OrderSum();

        /// <summary>
        /// Initializes the order component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
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
            if(e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Entree.Entree)))
            {
                if (e.Item is BriarheartBurger) pageDisplay.Child = new CustomizationBriarheartBurger(this, e.Item as BriarheartBurger);
                else if (e.Item is DoubleDraugr) pageDisplay.Child = new CustomizationDrauger(this, e.Item as DoubleDraugr);
                else if (e.Item is GardenOrcOmelette) pageDisplay.Child = new CustomizationGardenOrc(this, e.Item as GardenOrcOmelette);
                else if (e.Item is PhillyPoacher) pageDisplay.Child = new CustomizationPhilly(this, e.Item as PhillyPoacher);
                else if (e.Item is SmokehouseSkeleton) pageDisplay.Child = new CustomizationSmokehouse(this, e.Item as SmokehouseSkeleton);
                else if (e.Item is ThalmorTriple) pageDisplay.Child = new CustomizationThalmor(this, e.Item as ThalmorTriple);
                else if (e.Item is ThugsTBone) pageDisplay.Child = new CustomizationThugsTBone(this, e.Item as ThugsTBone);
            }
            else if (e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Drinks.Drink)))
            {
                if (e.Item is SailorSoda) pageDisplay.Child = new CustomSailorSoda(this, e.Item as SailorSoda);
                else if (e.Item is MarkarthMilk) pageDisplay.Child = new CustomMarkarthMilk(this, e.Item as MarkarthMilk);
                else if (e.Item is AretinoAppleJuice) pageDisplay.Child = new CustomAretinoAppleJuice(this, e.Item as AretinoAppleJuice);
                else if (e.Item is CandlehearthCoffee) pageDisplay.Child = new CustomCandlehearthCoffee(this, e.Item as CandlehearthCoffee);
                else if (e.Item is WarriorWater) pageDisplay.Child = new CustomWarriorWater(this, e.Item as WarriorWater);
            }
            else if (e.Item.GetType().IsSubclassOf(typeof(BleakwindBuffet.Data.Side.Side)))
            {
                if (e.Item is VokunSalad) pageDisplay.Child = new CustomVokunSalad(this, e.Item as VokunSalad);
                else if (e.Item is FriedMiraak) pageDisplay.Child = new CustomFriedMiraak(this, e.Item as FriedMiraak);
                else if (e.Item is MadOtarGrits) pageDisplay.Child = new CustomMadOtarGrits(this, e.Item as MadOtarGrits);
                else if (e.Item is DragonbornWaffleFries) pageDisplay.Child = new CustomDragonbornWaffleFries(this, e.Item as DragonbornWaffleFries);
            }
        }
    }
}
