﻿/*
* Author: Jesse Babcock
* Class name: MadOtarGrits.cs
* Purpose: To set prices and sizes of Mad Otar Grits
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Side
{
    /// <summary>
    /// Public class for Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Cheesey Grits.";
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
        /// Double for price
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                if (Size == Size.Small) price = 1.22;
                if (Size == Size.Medium) price = 1.58;
                if (Size == Size.Large) price = 1.93;
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
                if (Size == Size.Small) calories = 105;
                if (Size == Size.Medium) calories = 142;
                if (Size == Size.Large) calories = 179;
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
        /// Prints what size it is 
        /// </summary>
        /// <returns>String value for [Size] Mad Otar Grits</returns>
        public override string ToString()
        {
            return $"{Size} Mad Otar Grits";
        }
    }
}
