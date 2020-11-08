using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public bool Sidecheck, Entreecheck, Drinkcheck;

        public double Pmin, Pmax, Cmin, Cmax;

        public IEnumerable<IOrderItem> Items { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(string SearchTerms, string[] Selection, double PriceMax, double PriceMin, double CaloriesMin, double CaloriesMax)
        {
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterBySelection(Items, Selection);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            foreach(string thing in Selection)
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
