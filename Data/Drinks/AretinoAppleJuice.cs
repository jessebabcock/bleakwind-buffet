/*
* Author: Jesse Babcock
* Class name: AretinoAppleJuice.cs
* Purpose: To set prices, sizes, and ice of Aretino Apple Juice
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Public class for Aretino Applejuice
    /// </summary>
    public class AretinoAppleJuice : Drink, IOrderItem
    {
        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = .62;
                if (Size == Size.Medium) price = .87;
                if (Size == Size.Large) price = 1.01;
                return price;
            }
        }

        /// <summary>
        /// Gets calories in uint
        /// </summary>
        private uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 44;
                if (Size == Size.Medium) calories = 88;
                if (Size == Size.Large) calories = 132;
                return calories;
            }

        }

        /// <summary>
        /// List of instructions based on what ingredients are false
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) instructions.Add("Add ice");
                return instructions;
            }
        }

        /// <summary>
        /// private variable to ice defaulted false
        /// </summary>
        private bool ice;

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
        /// Prints what size it is 
        /// </summary>
        /// <returns>String value for [Size] Aretino Apple Juice</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}
