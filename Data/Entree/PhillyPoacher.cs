/*
* Author: Jesse Babcock
* Class name: PhillyPoacher.cs
* Purpose: To set prices and calories of Philly Poacher and to add special instructions if they dont want sirloin, onion, or roll
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data.Entree
{
    public class PhillyPoacher
    {
        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool sirloin = true, onion = true, roll = true;

        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 7.23;
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
                calories = 784;
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
                if (!Sirloin)   SpecialInstructions.Add("Hold sirloin");
                if (!Onion)     SpecialInstructions.Add("Hold onion");
                if (!Roll)      SpecialInstructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Gets if they want Sirloin or not default true
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }

        /// <summary>
        /// Gets if they want onions or not default true
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }

        /// <summary>
        /// Gets if they want a roll or not default true
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Prints Philly Poacher
        /// </summary>
        /// <returns>String of Philly Poacher</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
