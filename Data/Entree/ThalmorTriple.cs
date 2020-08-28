/*
* Author: Jesse Babcock
* Class name: ThalmorTriple.cs
* Purpose: To set prices and calories of Thalmor Triple and add instructions if they 
*          dont want bun, ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, eggs
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThalmorTriple
    {
        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool bun = true, ketchup = true, mustard = true, pickle = true, 
             cheese = true, tomato = true, lettuce = true, mayo = true, bacon = true, egg = true;

        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 8.32;
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
                calories = 943;
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold mustard");
                if (!Lettuce) instructions.Add("Hold pickle");
                if (!Mayo) instructions.Add("Hold cheese");
                if (!Bacon) instructions.Add("Hold bacon");
                if (!Egg) instructions.Add("Hold egg");
                return instructions;
            }
        }

        /// <summary>
        /// Gets if they want buns or not default true
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// Gets if they want cheese or not default true
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Gets if they want ketchup or not default true
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// Gets if they want mustard or not default true
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// Gets if they want a pickles or not default true
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
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
        /// Gets if they want lettuce or not default true
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }

        /// <summary>
        /// Gets if they want mayo or not default true
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        /// <summary>
        /// Gets if they want a bacon or not default true
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }

        /// <summary>
        /// Gets if they want a egg or not default true
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Prints Thalmor Triple
        /// </summary>
        /// <returns>String of Thalmor Triple</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
