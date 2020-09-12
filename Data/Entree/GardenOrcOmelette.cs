/*
* Author: Jesse Babcock
* Class name: GardenOrcOmelette.cs
* Purpose: To set prices and calories of Garden Orc Omelette and add instructions if they dont want broccoli,
*          mushrooms, tomato, or cheddar
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
    /// <summary>
    /// Public class for Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool broccoli = true, mushrooms = true, tomato = true, cheddar = true;

        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                price = 4.57;
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
                calories = 404;
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
                List<string>    instructions = new List<string>();
                if (!Broccoli)  instructions.Add("Hold broccoli");
                if (!Mushrooms) instructions.Add("Hold mushrooms");
                if (!Tomato)    instructions.Add("Hold tomato");
                if (!Cheddar)   instructions.Add("Hold cheddar");
                return instructions;
            }
        }

        /// <summary>
        /// Gets if they want broccoli or not default true
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }

        /// <summary>
        /// Gets if they want mushrooms or not default true
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }

        /// <summary>
        /// Gets if they want tomato or not default true
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }

        /// <summary>
        /// Gets if they want a cheddar or not default true
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Prints Garden Orc Omelette
        /// </summary>
        /// <returns>String of Garden Orc Omelette</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
