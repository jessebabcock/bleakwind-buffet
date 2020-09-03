/*
* Author: Jesse Babcock
* Class name: DragonbornWaffleFries.cs
* Purpose: To set prices and sizes of Dragonborn Waffle Fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Side
{
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = .42;
                if (Size == Size.Medium) price = .76;
                if (Size == Size.Large) price = .96;
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
                if (Size == Size.Small) calories = 77;
                if (Size == Size.Medium) calories = 89;
                if (Size == Size.Large) calories = 100;
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
                return instructions;
            }
        }

        /// <summary>
        /// private variable to size defaulted small
        /// </summary>
        private Size size = Size.Small;

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
        /// <returns>String value for [Size] Dragonborn Waffle Fries</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
