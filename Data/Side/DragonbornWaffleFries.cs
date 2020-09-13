﻿/*
* Author: Jesse Babcock
* Class name: DragonbornWaffleFries.cs
* Purpose: To set prices and sizes of Dragonborn Waffle Fries
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Side
{
    /// <summary>
    /// Public class for Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries : Side, IOrderItem
    {
        /// <summary>
        /// Double for price
        /// </summary>
        private double price;
        public override double Price
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
        /// Uint for calories
        /// </summary>
        private uint calories;
        public override uint Calories
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
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();
                return instructions;
            }
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
