/*
* Author: Jesse Babcock
* Class name: Menu.cs
* Purpose: Adds all the menu items into an IEnumerale<IOrderItem>
*/
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Side;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        /// <summary>
        /// Makes a list of Entrees and turns it into an IEnumerale<IOrderItem>
        /// </summary>
        /// <returns> IEnumerale<IOrderItem> of Entrees </returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Items.Add(bb);
            Items.Add(dd);
            Items.Add(goo); 
            Items.Add(pp);
            Items.Add(ss);
            Items.Add(tt);
            Items.Add(ttb);
            return Items;
        }

        /// <summary>
        /// Makes a list of Sides and turns it into an IEnumerale<IOrderItem>
        /// </summary>
        /// <returns> IEnumerale<IOrderItem> of Sides </returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            DragonbornWaffleFries dwfs = new DragonbornWaffleFries();
            dwfs.Size = Size.Small;
            DragonbornWaffleFries dwfm = new DragonbornWaffleFries();
            dwfm.Size = Size.Medium;
            DragonbornWaffleFries dwfl = new DragonbornWaffleFries();
            dwfl.Size = Size.Large;
            Items.Add(dwfs);
            Items.Add(dwfm);
            Items.Add(dwfl);

            FriedMiraak fms = new FriedMiraak();
            fms.Size = Size.Small;
            FriedMiraak fmm = new FriedMiraak();
            fmm.Size = Size.Medium;
            FriedMiraak fml = new FriedMiraak();
            fml.Size = Size.Large;
            Items.Add(fms);
            Items.Add(fmm);
            Items.Add(fml);

            MadOtarGrits mogs = new MadOtarGrits();
            mogs.Size = Size.Small;
            MadOtarGrits mogm = new MadOtarGrits();
            mogm.Size = Size.Medium;
            MadOtarGrits mogl = new MadOtarGrits();
            mogl.Size = Size.Large;
            Items.Add(mogs);
            Items.Add(mogm);
            Items.Add(mogl);

            VokunSalad vss = new VokunSalad();
            vss.Size = Size.Small;
            VokunSalad vsm = new VokunSalad();
            vsm.Size = Size.Medium;
            VokunSalad vsl = new VokunSalad();
            vsl.Size = Size.Large;
            Items.Add(vss);
            Items.Add(vsm);
            Items.Add(vsl);

           
            return Items;
        }

        /// <summary>
        /// Makes a list of Drinks and turns it into an IEnumerale<IOrderItem>
        /// </summary>
        /// <returns> IEnumerale<IOrderItem> of Drinks </returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> Items = new List<IOrderItem>();
            AretinoAppleJuice ajs = new AretinoAppleJuice();
            ajs.Size = Size.Small;
            AretinoAppleJuice ajm = new AretinoAppleJuice();
            ajm.Size = Size.Medium;
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajl.Size = Size.Large;
            Items.Add(ajs);
            Items.Add(ajm);
            Items.Add(ajl);

            CandlehearthCoffee ccs = new CandlehearthCoffee();
            ccs.Size = Size.Small;
            CandlehearthCoffee ccm = new CandlehearthCoffee();
            ccm.Size = Size.Medium;
            CandlehearthCoffee ccl = new CandlehearthCoffee();
            ccl.Size = Size.Large;
            Items.Add(ccs);
            Items.Add(ccm);
            Items.Add(ccl);

            CandlehearthCoffee dccs = new CandlehearthCoffee();
            dccs.Size = Size.Small;
            dccs.Decaf = true;
            CandlehearthCoffee dccm = new CandlehearthCoffee();
            dccm.Size = Size.Medium;
            dccm.Decaf = true;
            CandlehearthCoffee dccl = new CandlehearthCoffee();
            dccl.Size = Size.Large;
            dccl.Decaf = true;
            Items.Add(dccs);
            Items.Add(dccm);
            Items.Add(dccl);

            MarkarthMilk mms = new MarkarthMilk();
            mms.Size = Size.Small;
            MarkarthMilk mmm = new MarkarthMilk();
            mmm.Size = Size.Medium;
            MarkarthMilk mml = new MarkarthMilk();
            mml.Size = Size.Large;
            Items.Add(mms);
            Items.Add(mmm);
            Items.Add(mml);

            SailorSoda sssbb = new SailorSoda();
            sssbb.Size = Size.Small;
            sssbb.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssmbb = new SailorSoda();
            ssmbb.Size = Size.Medium;
            ssmbb.Flavor = SodaFlavor.Blackberry;
            SailorSoda sslbb = new SailorSoda();
            sslbb.Size = Size.Large;
            sslbb.Flavor = SodaFlavor.Blackberry;
            Items.Add(sssbb);
            Items.Add(ssmbb);
            Items.Add(sslbb);

            SailorSoda sssc = new SailorSoda();
            sssc.Size = Size.Small;
            sssc.Flavor = SodaFlavor.Cherry;
            SailorSoda ssmc = new SailorSoda();
            ssmc.Flavor = SodaFlavor.Cherry;
            ssmc.Size = Size.Medium;
            SailorSoda sslc = new SailorSoda();
            sslc.Flavor = SodaFlavor.Cherry;
            sslc.Size = Size.Large;
            Items.Add(sssc);
            Items.Add(ssmc);
            Items.Add(sslc);

            SailorSoda sssg = new SailorSoda();
            sssg.Size = Size.Small;
            sssg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssmg = new SailorSoda();
            ssmg.Size = Size.Medium;
            ssmg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda sslg = new SailorSoda();
            sslg.Size = Size.Large;
            sslg.Flavor = SodaFlavor.Grapefruit;
            Items.Add(sssg);
            Items.Add(ssmg);
            Items.Add(sslg);

            SailorSoda sssl = new SailorSoda();
            sssl.Size = Size.Small;
            sssl.Flavor = SodaFlavor.Lemon;
            SailorSoda ssml = new SailorSoda();
            ssml.Size = Size.Medium;
            ssml.Flavor = SodaFlavor.Lemon;
            SailorSoda ssll = new SailorSoda();
            ssll.Size = Size.Large;
            ssll.Flavor = SodaFlavor.Lemon;
            Items.Add(sssl);
            Items.Add(ssml);
            Items.Add(ssll);

            SailorSoda sssp = new SailorSoda();
            sssp.Size = Size.Small;
            sssp.Flavor = SodaFlavor.Peach;
            SailorSoda ssmp = new SailorSoda();
            ssmp.Size = Size.Medium;
            ssmp.Flavor = SodaFlavor.Peach;
            SailorSoda sslp = new SailorSoda();
            sslp.Size = Size.Large;
            sslp.Flavor = SodaFlavor.Peach;
            Items.Add(sssp);
            Items.Add(ssmp);
            Items.Add(sslp);

            SailorSoda sssw = new SailorSoda();
            sssw.Size = Size.Small;
            sssw.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssmw = new SailorSoda();
            ssmw.Size = Size.Medium;
            ssmw.Flavor = SodaFlavor.Watermelon;
            SailorSoda sslw = new SailorSoda();
            sslw.Size = Size.Large;
            sslw.Flavor = SodaFlavor.Watermelon;
            Items.Add(sssw);
            Items.Add(ssmw);
            Items.Add(sslw);

            WarriorWater wws = new WarriorWater();
            wws.Size = Size.Small;
            WarriorWater wwm = new WarriorWater();
            wwm.Size = Size.Medium;
            WarriorWater wwl = new WarriorWater();
            wwl.Size = Size.Large;
            Items.Add(wws);
            Items.Add(wwm);
            Items.Add(wwl);

            return Items;
        }

        /// <summary>
        /// Makes a list of all the items and turns it into an IEnumerale<IOrderItem>
        /// </summary>
        /// <returns> IEnumerale<IOrderItem> of all the items </returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> Items = new List<IOrderItem>();

            AretinoAppleJuice ajs = new AretinoAppleJuice();
            ajs.Size = Size.Small;
            AretinoAppleJuice ajm = new AretinoAppleJuice();
            ajm.Size = Size.Medium;
            AretinoAppleJuice ajl = new AretinoAppleJuice();
            ajl.Size = Size.Large;
            Items.Add(ajs);
            Items.Add(ajm);
            Items.Add(ajl);

            CandlehearthCoffee ccs = new CandlehearthCoffee();
            ccs.Size = Size.Small;
            CandlehearthCoffee ccm = new CandlehearthCoffee();
            ccm.Size = Size.Medium;
            CandlehearthCoffee ccl = new CandlehearthCoffee();
            ccl.Size = Size.Large;
            Items.Add(ccs);
            Items.Add(ccm);
            Items.Add(ccl);

            CandlehearthCoffee dccs = new CandlehearthCoffee();
            dccs.Size = Size.Small;
            dccs.Decaf = true;
            CandlehearthCoffee dccm = new CandlehearthCoffee();
            dccm.Size = Size.Medium;
            dccm.Decaf = true;
            CandlehearthCoffee dccl = new CandlehearthCoffee();
            dccl.Size = Size.Large;
            dccl.Decaf = true;
            Items.Add(dccs);
            Items.Add(dccm);
            Items.Add(dccl);

            MarkarthMilk mms = new MarkarthMilk();
            mms.Size = Size.Small;
            MarkarthMilk mmm = new MarkarthMilk();
            mmm.Size = Size.Medium;
            MarkarthMilk mml = new MarkarthMilk();
            mml.Size = Size.Large;
            Items.Add(mms);
            Items.Add(mmm);
            Items.Add(mml);

            SailorSoda sssbb = new SailorSoda();
            sssbb.Size = Size.Small;
            sssbb.Flavor = SodaFlavor.Blackberry;
            SailorSoda ssmbb = new SailorSoda();
            ssmbb.Size = Size.Medium;
            ssmbb.Flavor = SodaFlavor.Blackberry;
            SailorSoda sslbb = new SailorSoda();
            sslbb.Size = Size.Large;
            sslbb.Flavor = SodaFlavor.Blackberry;
            Items.Add(sssbb);
            Items.Add(ssmbb);
            Items.Add(sslbb);

            SailorSoda sssc = new SailorSoda();
            sssc.Size = Size.Small;
            sssc.Flavor = SodaFlavor.Cherry;
            SailorSoda ssmc = new SailorSoda();
            ssmc.Flavor = SodaFlavor.Cherry;
            ssmc.Size = Size.Medium;
            SailorSoda sslc = new SailorSoda();
            sslc.Flavor = SodaFlavor.Cherry;
            sslc.Size = Size.Large;
            Items.Add(sssc);
            Items.Add(ssmc);
            Items.Add(sslc);

            SailorSoda sssg = new SailorSoda();
            sssg.Size = Size.Small;
            sssg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda ssmg = new SailorSoda();
            ssmg.Size = Size.Medium;
            ssmg.Flavor = SodaFlavor.Grapefruit;
            SailorSoda sslg = new SailorSoda();
            sslg.Size = Size.Large;
            sslg.Flavor = SodaFlavor.Grapefruit;
            Items.Add(sssg);
            Items.Add(ssmg);
            Items.Add(sslg);

            SailorSoda sssl = new SailorSoda();
            sssl.Size = Size.Small;
            sssl.Flavor = SodaFlavor.Lemon;
            SailorSoda ssml = new SailorSoda();
            ssml.Size = Size.Medium;
            ssml.Flavor = SodaFlavor.Lemon;
            SailorSoda ssll = new SailorSoda();
            ssll.Size = Size.Large;
            ssll.Flavor = SodaFlavor.Lemon;
            Items.Add(sssl);
            Items.Add(ssml);
            Items.Add(ssll);

            SailorSoda sssp = new SailorSoda();
            sssp.Size = Size.Small;
            sssp.Flavor = SodaFlavor.Peach;
            SailorSoda ssmp = new SailorSoda();
            ssmp.Size = Size.Medium;
            ssmp.Flavor = SodaFlavor.Peach;
            SailorSoda sslp = new SailorSoda();
            sslp.Size = Size.Large;
            sslp.Flavor = SodaFlavor.Peach;
            Items.Add(sssp);
            Items.Add(ssmp);
            Items.Add(sslp);

            SailorSoda sssw = new SailorSoda();
            sssw.Size = Size.Small;
            sssw.Flavor = SodaFlavor.Watermelon;
            SailorSoda ssmw = new SailorSoda();
            ssmw.Size = Size.Medium;
            ssmw.Flavor = SodaFlavor.Watermelon;
            SailorSoda sslw = new SailorSoda();
            sslw.Size = Size.Large;
            sslw.Flavor = SodaFlavor.Watermelon;
            Items.Add(sssw);
            Items.Add(ssmw);
            Items.Add(sslw);

            WarriorWater wws = new WarriorWater();
            wws.Size = Size.Small;
            WarriorWater wwm = new WarriorWater();
            wwm.Size = Size.Medium;
            WarriorWater wwl = new WarriorWater();
            wwl.Size = Size.Large;
            Items.Add(wws);
            Items.Add(wwm);
            Items.Add(wwl);

            DragonbornWaffleFries dwfs = new DragonbornWaffleFries();
            dwfs.Size = Size.Small;
            DragonbornWaffleFries dwfm = new DragonbornWaffleFries();
            dwfm.Size = Size.Medium;
            DragonbornWaffleFries dwfl = new DragonbornWaffleFries();
            dwfl.Size = Size.Large;
            Items.Add(dwfs);
            Items.Add(dwfm);
            Items.Add(dwfl);

            FriedMiraak fms = new FriedMiraak();
            fms.Size = Size.Small;
            FriedMiraak fmm = new FriedMiraak();
            fmm.Size = Size.Medium;
            FriedMiraak fml = new FriedMiraak();
            fml.Size = Size.Large;
            Items.Add(fms);
            Items.Add(fmm);
            Items.Add(fml);

            MadOtarGrits mogs = new MadOtarGrits();
            mogs.Size = Size.Small;
            MadOtarGrits mogm = new MadOtarGrits();
            mogm.Size = Size.Medium;
            MadOtarGrits mogl = new MadOtarGrits();
            mogl.Size = Size.Large;
            Items.Add(mogs);
            Items.Add(mogm);
            Items.Add(mogl);

            VokunSalad vss = new VokunSalad();
            vss.Size = Size.Small;
            VokunSalad vsm = new VokunSalad();
            vsm.Size = Size.Medium;
            VokunSalad vsl = new VokunSalad();
            vsl.Size = Size.Large;
            Items.Add(vss);
            Items.Add(vsm);
            Items.Add(vsl);

            BriarheartBurger bb = new BriarheartBurger();
            DoubleDraugr dd = new DoubleDraugr();
            GardenOrcOmelette goo = new GardenOrcOmelette();
            PhillyPoacher pp = new PhillyPoacher();
            SmokehouseSkeleton ss = new SmokehouseSkeleton();
            ThalmorTriple tt = new ThalmorTriple();
            ThugsTBone ttb = new ThugsTBone();
            Items.Add(bb);
            Items.Add(dd);
            Items.Add(goo);
            Items.Add(pp);
            Items.Add(ss);
            Items.Add(tt);
            Items.Add(ttb);

            return Items;
        }


        /// <summary>
        /// Gets all the movies in the database
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return FullMenu(); } }

        /// <summary>
        /// Searches the movies i nthe database for matches
        /// </summary>
        /// <param name="terms"></param>
        /// <returns> The results of the search</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            //null check
            if (terms == null || terms == "") return All;

            foreach (IOrderItem item in All)
            {
                //adding the movie to the list if it matches
                if (item.ToString().ToLower().Contains(terms.ToLower()))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterBySelection(IEnumerable<IOrderItem> items, IEnumerable<string> selection)
        {
            // If no filter is specified, just return the provided collection
            if (selection == null || selection.Count() == 0) return items;

            // Filter the supplied collection of movies
            List<IOrderItem> results = new List<IOrderItem>();
            if (selection.Contains("Entrees"))
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Entree.Entree)
                    {
                        results.Add(item);
                    }
                }
            }
            if (selection.Contains("Sides"))
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Side.Side)
                    {
                        results.Add(item);
                    }
                }
            }
            if (selection.Contains("Drinks"))
            {
                foreach (IOrderItem item in items)
                {
                    if (item is Drink)
                    {
                        results.Add(item);
                    }
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// to those with IMDB ratings falling within
        /// the specified range
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered IOrderItem collection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> itemlist, double? min, double? max)
        {
            if (min == null && max == null) return itemlist;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in itemlist)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in itemlist)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in itemlist)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of movies
        /// to those with IMDB ratings falling within
        /// the specified range
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered IOrderItem collection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> itemlist, double? min, double? max)
        {
            if (min == null && max == null) return itemlist;

            var results = new List<IOrderItem>();

            // only a maximum specified
            if (min == null)
            {
                foreach (IOrderItem item in itemlist)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            // only a minimum specified
            if (max == null)
            {
                foreach (IOrderItem item in itemlist)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            // Both minimum and maximum specified
            foreach (IOrderItem item in itemlist)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
