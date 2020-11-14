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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// Public class for Philly Poacher
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Description of the item
        /// </summary>
        public string Description
        {
            get
            {
                return "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
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
        bool sirloin = true, onion = true, roll = true;

        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                price = 7.23;
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
                calories = 784;
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
                if (!Sirloin)   instructions.Add("Hold sirloin");
                if (!Onion)     instructions.Add("Hold onion");
                if (!Roll)      instructions.Add("Hold roll");
                return instructions;
            }
        }

        /// <summary>
        /// Gets if they want Sirloin or not default true
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
            }
        }

        /// <summary>
        /// Gets if they want onions or not default true
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
            }
        }

        /// <summary>
        /// Gets if they want a roll or not default true
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
            }
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
