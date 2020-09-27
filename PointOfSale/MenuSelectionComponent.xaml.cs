///Author: Jesse Babcock
///File: MenuSelectionComponent.cs
///Date: 9/27/20
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
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
        /// <summary>
        /// Button click event to get in
        /// </summary>
        public event EventHandler<MenuSelectionItemEventArgs> ItemSelected;

        /// <summary>
        /// Initializes Menu select
        /// </summary>
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Burger click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BrairheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger burg = new BriarheartBurger();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs(){Item = burg});
            
        }

        /// <summary>
        /// Draghaur click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DoubleDraghaurClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr drau = new DoubleDraugr();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = drau });
        }

        /// <summary>
        /// Thalmor Triple click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple thal = new ThalmorTriple();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = thal });
        }

        /// <summary>
        /// Smokehouse Skeleton click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton skel = new SmokehouseSkeleton();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = skel });
        }

        /// <summary>
        /// Garden Orc Omelette click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette orc = new GardenOrcOmelette();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = orc });
        }

        /// <summary>
        /// Philly Poacher click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher poach = new PhillyPoacher();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = poach });
        }

        /// <summary>
        /// Thugs T-Bone click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone bone = new ThugsTBone();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = bone });
        }

        /// <summary>
        /// Sailor Soda click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda soda = new SailorSoda();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = soda });
        }

        /// <summary>
        /// Markarth Milk click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk milk = new MarkarthMilk();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = milk });
        }

        /// <summary>
        /// Aretino Apple Juice click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice apple = new AretinoAppleJuice();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = apple });
        }

        /// <summary>
        /// Candlehearth Coffee click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = coffee });
        }

        /// <summary>
        /// Warrior Water click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater water = new WarriorWater();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = water });
        }

        /// <summary>
        /// Vokun Salad click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad salad = new VokunSalad();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = salad });
        }

        /// <summary>
        /// Fried Miraak click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fried = new FriedMiraak();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = fried });
        }

        /// <summary>
        /// Mad Otar Grits click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits grits = new MadOtarGrits();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = grits });
        }

        /// <summary>
        /// Dragonborn Waffle Fries click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries waffle = new DragonbornWaffleFries();
            ItemSelected?.Invoke(this, new MenuSelectionItemEventArgs() { Item = waffle });
        }

        
    }
}
