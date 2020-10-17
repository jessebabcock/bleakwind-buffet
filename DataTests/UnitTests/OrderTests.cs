/*
 * Author: Jesse Babcock
 * Class: OrderTest.cs
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
using System;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ShouldBeAnOrder()
        {
            Order order = new Order();
            Assert.IsAssignableFrom<Order>(order);
        }

        [Fact]
        public void ShouldAddToOrder()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            Combo combo = new Combo(bb, dw, aaj);
            Order order = new Order();
            order.Add(dw);
            order.Add(aaj);
            order.Add(bb);
            order.Add(combo);
            Assert.Contains(dw, order.items);
            Assert.Contains(bb, order.items);
            Assert.Contains(aaj, order.items);
            Assert.Contains(combo, order.items);
        }

        [Theory]
        [InlineData(.20)]
        [InlineData(.22)]
        public void ShouldSetSalesTax(double salesTax)
        {
            Order order = new Order();
            order.SalesTax = salesTax;
            Assert.Equal(salesTax, order.SalesTax);
        }

        [Fact]
        public void ShouldDefaultSalesTax()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTax);
        }

        [Theory]
        [InlineData(Size.Small, 6.94)]
        [InlineData(Size.Medium, 7.19)]
        [InlineData(Size.Large, 7.33)]
        public void ShouldReturnCorrectSubTotal(Size size, double price)
        {
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Order order = new Order();
            order.Add(aaj);
            order.Add(burg);
            Assert.Equal(price, order.SubTotal);
        }

        [Theory]
        [InlineData(Size.Small, 0.83)]
        [InlineData(Size.Medium, 0.86)]
        [InlineData(Size.Large, 0.88)]
        public void ShouldReturnCorrectTax(Size size, double tax)
        {
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Order order = new Order();
            order.Add(aaj);
            order.Add(burg);
            Assert.Equal(tax, order.Tax);
        }

        [Theory]
        [InlineData(Size.Small, 7.77)]
        [InlineData(Size.Medium, 8.05)]
        [InlineData(Size.Large, 8.21)]
        public void ShouldReturnCorrectTotal(Size size, double total)
        {
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Order order = new Order();
            order.Add(aaj);
            order.Add(burg);
            Assert.Equal(total, order.Total);
        }

        [Theory]
        [InlineData(Size.Small, 787)]
        [InlineData(Size.Medium, 831)]
        [InlineData(Size.Large, 875)]
        public void ShouldReturnCorrectCalories(Size size, uint calories)
        {
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Order order = new Order();
            order.Add(aaj);
            order.Add(burg);
            Assert.Equal(calories, order.Calories);
        }

        [Fact]
        public void ShouldRemoveFromOrder()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            Combo combo = new Combo(bb, dw, aaj);
            Order order = new Order();
            order.Add(dw);
            order.Add(aaj);
            order.Add(bb);
            order.Add(combo);
            order.Remove(dw, 0); //Supposed to remove from GUI first position
            order.Remove(bb, 2); //Supposed to remove from GUI thrid position
            Assert.Contains(aaj, order.items);
            Assert.Contains(combo, order.items);
            Assert.DoesNotContain(dw, order.items);
            Assert.DoesNotContain(bb, order.items);
        }

        [Fact]
        public void ShouldClearFromOrder()
        {
            DragonbornWaffleFries dw = new DragonbornWaffleFries();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            Combo combo = new Combo(bb, dw, aaj);
            Order order = new Order();
            order.Add(dw);
            order.Add(combo);
            Assert.PropertyChanged(order, "Total", () => {
                order.Clear();
            }
            );
            order.Add(dw);
            order.Add(combo);
            Assert.PropertyChanged(order, "Tax", () => {
                order.Clear();
            }
            );
            order.Add(dw);
            order.Add(combo);
            Assert.PropertyChanged(order, "SubTotal", () => {
                order.Clear();
            }
            );
            order.Add(dw);
            order.Add(combo);
            Assert.PropertyChanged(order, "Calories", () => {
                order.Clear();
            }
            );
            Assert.Empty(order.items);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldChangeProperties(Size size)
        {
            BriarheartBurger burg = new BriarheartBurger();
            AretinoAppleJuice aaj = new AretinoAppleJuice();
            aaj.Size = size;
            Order order = new Order();

            Assert.PropertyChanged(order, "Total", () => {
                order.Add(aaj);
                }
            );
            Assert.PropertyChanged(order, "Tax", () => {
                order.Add(aaj);
            }
            );
            Assert.PropertyChanged(order, "SubTotal", () => {
                order.Add(aaj);
            }
            );
            Assert.PropertyChanged(order, "Calories", () => {
                order.Add(aaj);
            }
            );
        }
    }
}