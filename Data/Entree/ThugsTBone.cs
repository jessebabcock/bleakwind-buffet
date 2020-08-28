/*
* Author: Jesse Babcock
* Class name: ThugsTBone.cs
* Purpose: To set prices and calories of Thugs T-Bone
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entree
{
    class ThugsTBone
    {
        /// <summary>
        /// Gets price
        /// </summary>
        private double price;
        public double Price
        {
            get
            {
                price = 6.44;
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
                calories = 982;
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
