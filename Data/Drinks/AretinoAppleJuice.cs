﻿/*
* Author: Jesse Babcock
* Class name: AretinoAppleJuice.cs
* Purpose: To set prices, sizes, and ice of Aretino Apple Juice
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Drinks
{
    class AretinoAppleJuice
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
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
        /// Gets calories
        /// </summary>
        private uint calories;
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                if (Ice) SpecialInstructions.Add("Add ice");
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
        /// <returns>String value for [Size] Aretino Apple Juice</returns>
        public override string ToString()
        {
            return $"{Size} Aretino Apple Juice";
        }
    }
}