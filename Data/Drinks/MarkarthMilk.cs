/*
* Author: Jesse Babcock
* Class name: AretinoAppleJuice.cs
* Purpose: To set prices, sizes, and ice of Markarth Milk
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    public class MarkarthMilk
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.05;
                if (Size == Size.Medium) price = 1.11;
                if (Size == Size.Large) price = 1.22;
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
                if (Size == Size.Small) calories = 56;
                if (Size == Size.Medium) calories = 72;
                if (Size == Size.Large) calories = 93;
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
        /// Prints what size it is 
        /// </summary>
        /// <returns>String value for [Size] Markarth Milk</returns>
        public override string ToString()
        {
            return $"{Size} Markarth Milk";
        }
    }
}
