/*
* Author: Jesse Babcock
* Class name: CandlehearthCoffee.cs
* Purpose: To set prices, sizes, decaf, and cream of Candlehearth Coffee
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class CandlehearthCoffee
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = .75;
                if (Size == Size.Medium) price = 1.25;
                if (Size == Size.Large) price = 1.75;
                return price;
            }
        }

        /// <summary>
        /// Gets calories
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 7;
                if (Size == Size.Medium) calories = 10;
                if (Size == Size.Large) calories = 20;
                return calories;
            }

        }

        /// <summary>
        /// List of instructions based on what ingredients are false
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice)            SpecialInstructions.Add("Add ice");
                if (RoomForCream)   SpecialInstructions.Add("Add cream");
                if (Decaf)          SpecialInstructions.Add("Add decaf");
                return instructions;
            }
        }

        /// <summary>
        /// private variable to ice defaulted true
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// private variable to size defaulted small
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// private variable to cream defaulted false
        /// </summary>
        private bool cream = false;

        /// <summary>
        /// private variable to decaf defaulted false
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Gets true or false if they want ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <summary>
        /// Gets true or false if they want cream
        /// </summary>
        public bool RoomForCream
        {
            get { return cream; }
            set { cream = value; }
        }

        /// <summary>
        /// Gets true or false if they want decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }

        /// <summary>
        /// Gets what size they want (small, medium, large)
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Prints what size it is and if it is decaf or not
        /// </summary>
        /// <returns>
        /// String value for decaf [Size] Decaf Candlehearth Coffee
        /// String value without decaf [Size] Candlehearth Coffee
        /// </returns>
        public override string ToString()
        {
            if (decaf) return   $"{Size} Decaf Candlehearth Coffee";
            else return         $"{Size} Candlehearth Coffee";
        }
    }
}
