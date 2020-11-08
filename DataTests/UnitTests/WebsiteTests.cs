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
using Website.Pages;

namespace BleakwindBuffet.DataTests.UnitTests
{

    public class WebsiteTests
    {
        

        [Theory]
        [InlineData("", null, 0,0,0,0)]
        public void ShouldReturnAllMenu(string SearchTerms, string[] Selection, double PriceMax, double PriceMin, double CaloriesMin, double CaloriesMax)
        {
            Pages_Index thing = new Pages_Index();
            thing.Model.OnGet(SearchTerms, Selection, PriceMax, PriceMin, CaloriesMin, CaloriesMax);
            foreach(IOrderItem item in Menu.FullMenu())
            {
                Assert.Contains(item, thing.Model.Items);
            }
        }

    }
}