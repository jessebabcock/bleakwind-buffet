﻿/*
* Author: Jesse Babcock
* Class name: CandlehearthCoffee.cs
* Purpose: To set prices, sizes, decaf, and cream of Candlehearth Coffee
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Public class for Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Fair trade, fresh ground dark roast coffee.";
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
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = .75;
                if (Size == Size.Medium) price = 1.25;
                if (Size == Size.Large) price = 1.75;
                return price;
            }
        }

        /// <summary>
        /// Gets calories in uint
        /// </summary>
        private  uint calories;
        public override uint Calories
        {
            get
            {
                if (Size == Size.Small) calories = 7;
                if (Size == Size.Medium) calories = 10;
                if (Size == Size.Large) calories = 20;
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
                if (Ice)            instructions.Add("Add ice");
                if (RoomForCream)   instructions.Add("Add cream");
                if (Decaf)          instructions.Add("Add decaf");
                return instructions;
            }
        }

        /// <summary>
        /// private variable to ice defaulted false
        /// </summary>
        private bool ice = false;

        /// <summary>
        /// private variable to cream defaulted false
        /// </summary>
        private bool cream = false;

        /// <summary>
        /// private variable to decaf defaulted false
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// Gets true or false if they want ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets true or false if they want cream
        /// </summary>
        public bool RoomForCream
        {
            get { return cream; }
            set
            {
                cream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Gets true or false if they want decaf
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// private variable to size defaulted small
        /// </summary>
        private Size size;

        /// <summary>
        /// Checks for size
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Prints what size it is and if it is decaf or not
        /// </summary>
        /// <returns>
        /// String value for decaf [Size] Decaf Candlehearth Coffee
        /// String value without decaf [Size] Candlehearth Coffee
        /// </returns>
        public override string ToString()
        {
            if (decaf) return   $"{Size} Decaf Candlehearth Coffee";
            else return         $"{Size} Candlehearth Coffee";
        }
    }
}
