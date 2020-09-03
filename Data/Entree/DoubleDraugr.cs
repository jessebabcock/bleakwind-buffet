/*
* Author: Jesse Babcock
* Class name: DoubleDraugr.cs
* Purpose: To set prices and calories of Double Draugr and add instructions if they 
*          dont want bun, ketchup, mustard, pickle, cheese, tomato, lettuce, mayo
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    public class DoubleDraugr
    {
        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool bun = true, ketchup = true, mustard = true,
             pickle = true, cheese = true, tomato = true, lettuce = true, mayo = true;

        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 7.32;
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
                calories = 843;
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
        /// Prints Double Draugr
        /// </summary>
        /// <returns>String of Double Draugr</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}

