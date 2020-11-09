/*
 * Author: Jesse Babcock
 * Class: MenuTest.cs
 * Purpose: Test the Menu.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Side;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTest
    {
        [Fact]
        public void MenuShouldReturnEntrees()
        {
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Menu.Entrees(), (item) => { return item.ToString().Equals("Thugs T-Bone"); });
        }

        [Fact]
        public void MenuShouldReturnDrinks()
        {
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.Drinks(), (item) => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void MenuShouldReturnSides()
        {
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.Sides(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });
        }

        [Fact]
        public void MenuShouldReturnAllMenuItems()
        {
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Fried Miraak"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Mad Otar Grits"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Vokun Salad"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Aretino Apple Juice"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Decaf Candlehearth Coffee"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Decaf Candlehearth Coffee"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Markarth Milk"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Cherry Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Lemon Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Peach Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Large Warrior Water"); });

            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Menu.FullMenu(), (item) => { return item.ToString().Equals("Thugs T-Bone"); });
        }

        [Fact]
        public void MenuShouldAssertEachItem()
        {
            foreach(IOrderItem item in Menu.FullMenu())
            {
                Assert.IsAssignableFrom<INotifyPropertyChanged>(item);
            }
        }

        [Theory]
        [InlineData("")]
        [InlineData("burger")]
        [InlineData(null)]
        public void WebsiteShouldReturnSearch(string searchterm)
        {
            IEnumerable<IOrderItem> items = Menu.Search(searchterm);
            Assert.Contains(items, (item) => { return item is BriarheartBurger; });
        }

        [Fact]
        public void WebsiteShouldFilterNothingNullCheck()
        {
            string[] filter = null;
            IEnumerable<IOrderItem> items = Menu.FilterBySelection(Menu.FullMenu(), filter);
            foreach (IOrderItem item in items)
            {
                Assert.IsAssignableFrom<IOrderItem>(item);
            }
        }

        [Fact]
        public void WebsiteShouldFilterNothingEmptyCheck()
        {
            string[] filter = new string[3];
            IEnumerable<IOrderItem> items = Menu.FilterBySelection(Menu.FullMenu(), filter);
            foreach (IOrderItem item in items)
            {
                Assert.IsAssignableFrom<IOrderItem>(item);
            }
        }

        [Fact]
        public void WebsiteShouldFilterDrinks()
        {
            string[] filter = new string[3];
            filter[0] = "Drinks";
            IEnumerable<IOrderItem> items = Menu.FilterBySelection(Menu.FullMenu(), filter);
            foreach(IOrderItem item in items)
            {
                Assert.IsAssignableFrom<Drink>(item);
            }
            
        }

        [Fact]
        public void WebsiteShouldFilterEntrees()
        {
            string[] filter = new string[3];
            filter[0] = "Entrees";
            IEnumerable<IOrderItem> items = Menu.FilterBySelection(Menu.FullMenu(), filter);
            foreach (IOrderItem item in items)
            {
                Assert.IsAssignableFrom<Entree>(item);
            }

        }

        [Fact]
        public void WebsiteShouldFilterSides()
        {
            string[] filter = new string[3];
            filter[0] = "Sides";
            IEnumerable<IOrderItem> items = Menu.FilterBySelection(Menu.FullMenu(), filter);
            foreach (IOrderItem item in items)
            {
                Assert.IsAssignableFrom<Side>(item);
            }
        }

        [Fact]
        public void ShouldCheckMinAndMaxFilterPriceNullCheck()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByPrice(Menu.FullMenu(), null, null);
            Assert.Contains(items, (item) => { return item is BriarheartBurger; });
        }

        [Fact]
        public void ShouldCheckMinPriceNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByPrice(Menu.FullMenu(), null, 1);
            foreach (IOrderItem item in items)
            {
                Assert.True(item.Price <= 1 && item.Price >= 0);
            }
        }

        [Fact]
        public void ShouldCheckMaxPriceNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByPrice(Menu.FullMenu(), 4, null);
            Assert.Contains(items, (item) => { return item is BriarheartBurger; });
            Assert.Contains(items, (item) => { return item is DoubleDraugr; });
            Assert.Contains(items, (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(items, (item) => { return item is PhillyPoacher; });
            Assert.Contains(items, (item) => { return item is ThalmorTriple; });
        }

        [Fact]
        public void ShouldCheckMinAndMaxPriceNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByPrice(Menu.FullMenu(), 4, 6);
            Assert.Contains(items, (item) => { return item is GardenOrcOmelette; });
            Assert.Contains(items, (item) => { return item is SmokehouseSkeleton; });
        }

        [Fact]
        public void ShouldCheckMinCaloriesNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCalories(Menu.FullMenu(), null, 400);
            foreach(IOrderItem item in items)
            {
                Assert.True(item.Calories <= 400 && item.Calories >= 0);
            }
        }

        [Fact]
        public void ShouldCheckMaxCaloriesNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCalories(Menu.FullMenu(), 400, null);
            Assert.Contains(items, (item) => { return item is BriarheartBurger; });
            Assert.Contains(items, (item) => { return item is DoubleDraugr; });
            Assert.Contains(items, (item) => { return item is SmokehouseSkeleton; });
            Assert.Contains(items, (item) => { return item is PhillyPoacher; });
            Assert.Contains(items, (item) => { return item is ThalmorTriple; });
        }

        [Fact]
        public void ShouldCheckMinAndMaxCaloriesNullFilter()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCalories(Menu.FullMenu(), 300, 400);
            Assert.Contains(items, (item) => { return item is FriedMiraak; });
        }

        [Fact]
        public void ShouldCheckMinAndMaxFilterCaloriesNullCheck()
        {
            IEnumerable<IOrderItem> items = Menu.FilterByCalories(Menu.FullMenu(), null, null);
            Assert.Contains(items, (item) => { return item is BriarheartBurger; });
        }
    }
}