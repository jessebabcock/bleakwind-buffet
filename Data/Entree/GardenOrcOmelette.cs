/*
* Author: Jesse Babcock
* Class name: GardenOrcOmelette.cs
* Purpose: To set prices and calories of Garden Orc Omelette and add instructions if they dont want broccoli,
*          mushrooms, tomato, or cheddar
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class GardenOrcOmelette
    {
        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool broccoli = true, mushrooms = true, tomato = true, cheddar = true;

        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 4.57;
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
                calories = 404;
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
                if (!Broccoli)  SpecialInstructions.Add("Hold broccoli");
                if (!Mushrooms) SpecialInstructions.Add("Hold mushrooms");
                if (!Tomato)    SpecialInstructions.Add("Hold tomato");
                if (!Cheddar)   SpecialInstructions.Add("Hold cheddar");
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
