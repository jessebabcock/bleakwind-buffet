/*
* Author: Jesse Babcock
* Class name: SailorSoda.cs
* Purpose: To set prices, sizes, ice, and flavor of Sailor Soda
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Public class for Sailor Soda
    /// </summary>
    public class SailorSoda
    {
        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.42;
                if (Size == Size.Medium) price = 1.74;
                if (Size == Size.Large) price = 2.07;
                return price;
            }
        }

        /// <summary>
        /// Gets calories in uint
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 117;
                if (Size == Size.Medium) calories = 153;
                if (Size == Size.Large) calories = 205;
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
                if (!Ice) instructions.Add("Hold ice");
                return instructions;
            }
        }

        /// <summary>
        /// private variable to ice defaulted true
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// private variable to flavor defaulted cherry
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <summary>
        /// private variable to size defaulted small
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets true or false if they want ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
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
        /// Gets what flavor they want (Blackberry, Cherry, Grapefruit, Lemon, Peach, or Watermelon)
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }

        /// <summary>
        /// Prints what size and flavor it is 
        /// </summary>
        /// <returns>String value for [Size] [Flavor] Sailor Soda</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
