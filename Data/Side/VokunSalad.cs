/*
* Author: Jesse Babcock
* Class name: VokunSalad.cs
* Purpose: To set prices and sizes of Vokun Salad
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Side
{
    /// <summary>
    /// Public class for Vokun Salad
    /// </summary>
    public class VokunSalad : Side, IOrderItem
    {

        /// <summary>
        /// Double for price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small)  price = .93;
                if (Size == Size.Medium) price = 1.28;
                if(Size == Size.Large)   price = 1.82;
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
                if (Size == Size.Small) calories = 41;
                if (Size == Size.Medium) calories = 52;
                if (Size == Size.Large) calories = 73;
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
        /// private variable to size defaulted small
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Prints what size it is 
        /// </summary>
        /// <returns>String value for [Size] Vokun Salad</returns>
        public override string ToString()
        {
            return $"{Size} Vokun Salad";
        }
    }
}
