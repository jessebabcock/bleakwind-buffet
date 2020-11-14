/*
* Author: Jesse Babcock
* Class name: Index.cshtml.cs
* Purpose: Backend of the index page to the website
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public bool Sidecheck, Entreecheck, Drinkcheck;

        public double? Pmin, Pmax, Cmin, Cmax;

        public IEnumerable<IOrderItem> Items { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] Selection, double? PriceMax, double? PriceMin, double? CaloriesMin, double? CaloriesMax)
        {
            Items = Menu.FullMenu();
            // Filter by Search
            if (SearchTerms != null)
            {
                Items = from item in Items
                        where item.Name != null && item.Name.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)
                         select item;
            }
            // Filter by Selection of type
            if (Selection != null && Selection.Length != 0)
            {
                Items = Items.Where(item =>
                    item is Drink && Selection.Contains("Drinks") || item is Entree && Selection.Contains("Entree") || item is Side && Selection.Contains("Sides")
                    );
            }
            // Filter by Price
            if (PriceMin != null && PriceMax != null)
            {
                Items = Items.Where(item =>
                    item.Price <= PriceMax && item.Price >= PriceMin
                    );
            }
            // Filter by Selection of type
            if (CaloriesMin != null && CaloriesMax != null)
            {
                Items = Items.Where(item =>
                    item.Calories <= CaloriesMax && item.Calories >= CaloriesMin
                    );
            }
            foreach (string thing in Selection)
            {
                switch (thing)
                {
                    case "Drinks":
                        Drinkcheck = true;
                        break;
                    case "Entrees":
                        Entreecheck = true;
                        break;
                    case "Sides":
                        Sidecheck = true;
                        break;
                }
            }
            if(Pmin != PriceMin) Pmin = PriceMin;
            if (PriceMax != 0 && Pmax != PriceMax) Pmax = PriceMax;
            if(Cmin != CaloriesMin) Cmin = CaloriesMin;
            if (CaloriesMax != 0 && Cmax != CaloriesMax) Cmax = CaloriesMax;
        }
    }
}
