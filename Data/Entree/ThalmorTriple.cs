﻿/*
* Author: Jesse Babcock
* Class name: ThalmorTriple.cs
* Purpose: To set prices and calories of Thalmor Triple and add instructions if they 
*          dont want bun, ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, eggs
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// Public class for Thalmor Triple
    /// </summary>
    public class ThalmorTriple : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";
            }
        }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name
        {
            get => ToString();
        }

        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool bun = true, ketchup = true, mustard = true, pickle = true, 
             cheese = true, tomato = true, lettuce = true, mayo = true, bacon = true, egg = true;

        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                price = 8.32;
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
                calories = 943;
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
                if (!Bun) instructions.Add("Hold bun");
                if (!Ketchup) instructions.Add("Hold ketchup");
                if (!Mustard) instructions.Add("Hold mustard");
                if (!Pickle) instructions.Add("Hold pickle");
                if (!Cheese) instructions.Add("Hold cheese");
                if (!Tomato) instructions.Add("Hold tomato");
                if (!Lettuce) instructions.Add("Hold lettuce");
                if (!Mayo) instructions.Add("Hold mayo");
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
            set
            {
                bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
            }
        }

        /// <summary>
        /// Gets if they want cheese or not default true
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
            }
        }

        /// <summary>
        /// Gets if they want ketchup or not default true
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
            }
        }

        /// <summary>
        /// Gets if they want mustard or not default true
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
            }
        }

        /// <summary>
        /// Gets if they want a pickles or not default true
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
            }
        }

        /// <summary>
        /// Gets if they want tomato or not default true
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
            }
        }

        /// <summary>
        /// Gets if they want lettuce or not default true
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
            }
        }

        /// <summary>
        /// Gets if they want mayo or not default true
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
            }
        }

        /// <summary>
        /// Gets if they want a bacon or not default true
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
            }
        }

        /// <summary>
        /// Gets if they want a egg or not default true
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
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
