/*
 * Author: Jesse Babcock
 * Class: PaymentTests.cs
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
using RoundRegister;
using PointOfSale;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class PaymentTests
    {
        [Fact]
        public void HundredsShouldBeHundreds()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Hundreds, CashDrawer.Hundreds);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void FiftiesShouldBeFifties()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Fifties, CashDrawer.Fifties);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void TwentiesShouldBeTwenties()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Twenties, CashDrawer.Twenties);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void TensShouldBeTens()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Tens, CashDrawer.Tens);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void FivesShouldBeFives()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Fives, CashDrawer.Fives);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void TwosShouldBeTwos()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Twos, CashDrawer.Twos);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void OnesShouldBeOnes()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Ones, CashDrawer.Ones);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void DollarCoinShouldBeDollarCoin()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.DollarCoin, CashDrawer.Dollars);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void HalfCoinShouldBeHalfCoins()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.HalfDollars, CashDrawer.HalfDollars); 
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void QuarterShouldBeQuater()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Quarters, CashDrawer.Quarters);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void DimesShouldBeDimes()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Dimes, CashDrawer.Dimes);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void NicklesShouldBeNickles()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Nickles, CashDrawer.Nickels);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void PenniesShouldBePennies()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(register.Pennies, CashDrawer.Pennies);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void ChangeShouldStartAtZero()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.Equal(0, register.ChangeDimes);
            Assert.Equal(0, register.ChangeDollarCoin);
            Assert.Equal(0, register.ChangeFifties);
            Assert.Equal(0, register.ChangeFives);
            Assert.Equal(0, register.ChangeHalfDollars);
            Assert.Equal(0, register.ChangeHundreds);
            Assert.Equal(0, register.ChangeNickles);
            Assert.Equal(0, register.ChangeOnes);
            Assert.Equal(0, register.ChangePennies);
            Assert.Equal(0, register.ChangeQuarters);
            Assert.Equal(0, register.ChangeTens);
            Assert.Equal(0, register.ChangeTwenties);
            Assert.Equal(0, register.ChangeTwos);
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void ShouldNotifyPropertyChange()
        {
            CashDrawer.OpenDrawer();
            RegisterFunction register = new RegisterFunction(new Order());
            Assert.PropertyChanged(register, "CustomerDimes", () => {
                register.CustomerDimes++;
            }
            );
            Assert.PropertyChanged(register, "ChangeDimes", () => {
                register.ChangeDimes++;
            }
            );
            Assert.PropertyChanged(register, "CustomerDollarCoin", () => {
                register.CustomerDollarCoin++;
            }
            );
            Assert.PropertyChanged(register, "ChangeDollarCoin", () => {
                register.ChangeDollarCoin++;
            }
            );
            Assert.PropertyChanged(register, "CustomerFifties", () => {
                register.CustomerFifties++;
            }
            );
            Assert.PropertyChanged(register, "ChangeFifties", () => {
                register.ChangeFifties++;
            }
            );
            Assert.PropertyChanged(register, "CustomerFives", () => {
                register.CustomerFives++;
            }
            );
            Assert.PropertyChanged(register, "ChangeFives", () => {
                register.ChangeFives++;
            }
            );
            Assert.PropertyChanged(register, "CustomerHalfDollars", () => {
                register.CustomerHalfDollars++;
            }
            );
            Assert.PropertyChanged(register, "ChangeHalfDollars", () => {
                register.ChangeHalfDollars++;
            }
            );
            Assert.PropertyChanged(register, "CustomerHundreds", () => {
                register.CustomerHundreds++;
            }
            );
            Assert.PropertyChanged(register, "ChangeHundreds", () => {
                register.ChangeHundreds++;
            }
            );
            Assert.PropertyChanged(register, "CustomerNickles", () => {
                register.CustomerNickles++;
            }
            );
            Assert.PropertyChanged(register, "ChangeNickles", () => {
                register.ChangeNickles++;
            }
            );
            Assert.PropertyChanged(register, "CustomerOnes", () => {
                register.CustomerOnes++;
            }
            );
            Assert.PropertyChanged(register, "ChangeOnes", () => {
                register.ChangeOnes++;
            }
            );
            Assert.PropertyChanged(register, "CustomerPennies", () => {
                register.CustomerPennies++;
            }
            );
            Assert.PropertyChanged(register, "ChangePennies", () => {
                register.ChangePennies++;
            }
            );
            Assert.PropertyChanged(register, "CustomerQuarters", () => {
                register.CustomerQuarters++;
            }
            );
            Assert.PropertyChanged(register, "ChangeQuarters", () => {
                register.ChangeQuarters++;
            }
            );
            Assert.PropertyChanged(register, "CustomerTens", () => {
                register.CustomerTens++;
            }
            );
            Assert.PropertyChanged(register, "ChangeTens", () => {
                register.ChangeTens++;
            }
            );
            Assert.PropertyChanged(register, "CustomerTwenties", () => {
                register.CustomerTwenties++;
            }
            );
            Assert.PropertyChanged(register, "ChangeTwenties", () => {
                register.ChangeTwenties++;
            }
            );
            Assert.PropertyChanged(register, "CustomerTwos", () => {
                register.CustomerTwos++;
            }
            );
            Assert.PropertyChanged(register, "ChangeTwos", () => {
                register.ChangeTwos++;
            }
            );
            CashDrawer.ResetDrawer();
        }

        [Fact]
        public void TotalIsCorrect()
        {
            CashDrawer.OpenDrawer();
            Order order = new Order();
            order.Add(new AretinoAppleJuice());
            RegisterFunction register = new RegisterFunction(order);
            Assert.Equal(.69, register.Total);
            CashDrawer.ResetDrawer();
        }
    }
}