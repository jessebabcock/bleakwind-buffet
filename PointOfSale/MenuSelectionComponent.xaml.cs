///Author: Jesse Babcock
///File: MenuSelectionComponent.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {

        private OrderComponent o;

        /// <summary>
        /// Initializes Menu select
        /// </summary>
        public MenuSelectionComponent(OrderComponent oc)
        {
            InitializeComponent();
            o = oc;
        }

        /// <summary>
        /// Burger click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BrairheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger burg = new BriarheartBurger();
            o.pageDisplay.Child = new CustomizationBriarheartBurger(o, burg);

        }

        /// <summary>
        /// Draghaur click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraghaurClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr drau = new DoubleDraugr();
            o.pageDisplay.Child = new CustomizationDrauger(o, drau);
        }

        /// <summary>
        /// Thalmor Triple click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple thal = new ThalmorTriple();
            o.pageDisplay.Child = new CustomizationThalmor(o, thal);
        }

        /// <summary>
        /// Smokehouse Skeleton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            o.pageDisplay.Child = new CustomizationSmokehouse(o, skel);
        }

        /// <summary>
        /// Garden Orc Omelette click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette orc = new GardenOrcOmelette();
            o.pageDisplay.Child = new CustomizationGardenOrc(o, orc);
        }

        /// <summary>
        /// Philly Poacher click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher poach = new PhillyPoacher();
            o.pageDisplay.Child = new CustomizationPhilly(o, poach);
        }

        /// <summary>
        /// Thugs T-Bone click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone bone = new ThugsTBone();
            o.pageDisplay.Child = new CustomizationThugsTBone(o, bone);
        }

        /// <summary>
        /// Sailor Soda click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda soda = new SailorSoda();
            o.pageDisplay.Child = new CustomSailorSoda(o, soda);
        }

        /// <summary>
        /// Markarth Milk click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk milk = new MarkarthMilk();
            o.pageDisplay.Child = new CustomMarkarthMilk(o, milk);
        }

        /// <summary>
        /// Aretino Apple Juice click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            o.pageDisplay.Child = new CustomAretinoAppleJuice(o, apple);
        }

        /// <summary>
        /// Candlehearth Coffee click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            o.pageDisplay.Child = new CustomCandlehearthCoffee(o, coffee);
        }

        /// <summary>
        /// Warrior Water click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater water = new WarriorWater();
            o.pageDisplay.Child = new CustomWarriorWater(o, water);
        }

        /// <summary>
        /// Vokun Salad click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad salad = new VokunSalad();
            o.pageDisplay.Child = new CustomVokunSalad(o, salad);
        }

        /// <summary>
        /// Fried Miraak click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fried = new FriedMiraak();
            o.pageDisplay.Child = new CustomFriedMiraak(o, fried);
        }

        /// <summary>
        /// Mad Otar Grits click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits grits = new MadOtarGrits();
            o.pageDisplay.Child = new CustomMadOtarGrits(o, grits);
        }

        /// <summary>
        /// Dragonborn Waffle Fries click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries waffle = new DragonbornWaffleFries();
            o.pageDisplay.Child = new CustomDragonbornWaffleFries(o, waffle);
        }

        void ComboClick(object sender, RoutedEventArgs e)
        {
            o.pageDisplay.Child = new CustomCombo(o);
        }
    }
}
