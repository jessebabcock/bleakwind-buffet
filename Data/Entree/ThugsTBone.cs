/*
* Author: Jesse Babcock
* Class name: ThugsTBone.cs
* Purpose: To set prices and calories of Thugs T-Bone
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
    /// Class for Thugs T-Bone
    /// </summary>
    public class ThugsTBone : Entree, IOrderItem, INotifyPropertyChanged
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
                price = 6.44;
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
                calories = 982;
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
        /// Prints Thugs T-Bone
        /// </summary>
        /// <returns>String of Thugs T-Bone</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
