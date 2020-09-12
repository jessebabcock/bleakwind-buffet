/*
 * Author: Jesse Babcock
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTest
    {
        [Fact]
        public void ShouldBeAbleToCastEntree()
        {
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Double Draugr"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Garden Orc Omlette"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Menu.Entrees(), (Entree) => { return Entree.ToString().Equals("Thugs T-Bone"); });
        }

        [Fact]
        public void ShouldBeAbleToCastDrink()
        {
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Arentino Apple Juice"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Arentino Apple Juice"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Arentino Apple Juice"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Small Warrior Watter"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Medium Warrior Watter"); });
            Assert.Contains(Menu.Entrees(), (Drink) => { return Drink.ToString().Equals("Large Warrior Watter"); });
        }

        [Fact]
        public void ShouldBeAbleToCastSide()
        {
            Assert.Contains(Menu.Entrees(), (Side) => { return Side.ToString().Equals("Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Entrees(), (Side) => { return Side.ToString().Equals("Fried Miraak"); });
            Assert.Contains(Menu.Entrees(), (Side) => { return Side.ToString().Equals("Mad Otar Grits"); });
            Assert.Contains(Menu.Entrees(), (Side) => { return Side.ToString().Equals("Vokun Salad"); });
        }
    }
}