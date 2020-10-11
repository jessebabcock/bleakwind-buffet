/*
 * Author: Jesse Babcock
 * Class: ComboTest.cs
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

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTest
    {
        [Fact]
        public void ShouldBeACombo()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            dw.Size = Size.Large;
            Combo combo = new Combo(bb, dw, aaj);
            Assert.IsAssignableFrom<Combo>(combo);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            dw.Size = Size.Large;
            Combo combo = new Combo(bb, dw, aaj);
            Assert.Contains("Large Dragonborn Waffle Fries", combo.SpecialInstructions);
            Assert.Contains("Small Aretino Apple Juice", combo.SpecialInstructions);
            Assert.Contains("Briarheart Burger", combo.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 864)]
        [InlineData(Size.Medium, 920)]
        [InlineData(Size.Large, 975)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            dw.Size = size;
            aaj.Size = size;
            Combo combo = new Combo(bb, dw, aaj);
            Assert.Equal(calories, combo.Calories);
        }

        [Theory]
        [InlineData(Size.Small, 6.36)]
        [InlineData(Size.Medium, 6.95)]
        [InlineData(Size.Large, 7.29)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            dw.Size = size;
            aaj.Size = size;
            Combo combo = new Combo(bb, dw, aaj);
            Assert.Equal(price, combo.Price);
        }
    }
}