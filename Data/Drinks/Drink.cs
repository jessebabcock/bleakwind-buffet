using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink
    {
        /// <virutal>
        /// Size of drink
        /// </virtual>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Price of drink
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get;}

        /// <summary>
        /// Calories of drink
        /// </summary>
        public abstract uint Calories { get;} 

        /// <summary>
        /// Special instructions for drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get;}
    }
}
