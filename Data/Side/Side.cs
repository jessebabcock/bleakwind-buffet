using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Side
{
    /// <summary>
    /// A base class representing the common properties of the side
    /// </summary>
    public abstract class Side
    {
        /// <virtual>
        /// Size of the side
        /// </virutal>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Price of the side
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
