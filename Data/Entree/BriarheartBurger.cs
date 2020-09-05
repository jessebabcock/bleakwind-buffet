/*
* Author: Jesse Babcock
* Class name: BriarheartBurger.cs
* Purpose: To set prices and calories of Briarheart Burger and add instructions if they 
*          dont want bun, ketchup, mustard, pickle, cheese
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// Public class for Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Private bools for the getter and setter defaulted true
        /// </summary>
        bool bun = true, ketchup = true, mustard = true, pickle = true, cheese = true;

        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 6.32;
                return price;
            }
        }

        /// <summary>
        /// Gets calories in uint
        /// </summary>
        private uint calories;
        public uint Calories
        {
            get
            {
                calories = 743;
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
        /// Prints Briarheart Burger
        /// </summary>
        /// <returns>String of Briarheart Burger</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
