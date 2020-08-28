﻿/*
* Author: Jesse Babcock
* Class name: FriedMiraak.cs
* Purpose: To set prices and sizes of Fried Miraak
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Side
{
    class FriedMiraak
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.78;
                if (Size == Size.Medium) price = 2.01;
                if (Size == Size.Large) price = 2.88;
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
                if (Size == Size.Small) calories = 151;
                if (Size == Size.Medium) calories = 236;
                if (Size == Size.Large) calories = 306;
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
        /// <returns>String value for [Size] Fried Miraak</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}