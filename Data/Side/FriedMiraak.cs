/*
* Author: Jesse Babcock
* Class name: FriedMiraak.cs
* Purpose: To set prices and sizes of Fried Miraak
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Side
{
    /// <summary>
    /// Public class for Fried Miraak
    /// </summary>
    public class FriedMiraak : Side, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
                if (Size == Size.Small) price = 1.78;
                if (Size == Size.Medium) price = 2.01;
                if (Size == Size.Large) price = 2.88;
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
                if (Size == Size.Small) calories = 151;
                if (Size == Size.Medium) calories = 236;
                if (Size == Size.Large) calories = 306;
                return calories;
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
        /// Prints what size it is 
        /// </summary>
        /// <returns>String value for [Size] Fried Miraak</returns>
        public override string ToString()
        {
            return $"{Size} Fried Miraak";
        }
    }
}
