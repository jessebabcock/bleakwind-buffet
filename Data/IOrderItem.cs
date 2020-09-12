using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for the menu items
    /// </summary>
    public interface IOrderItem
    {

        /// <summary>
        /// Price of whatever is selected
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public double Price { get; }

        /// <summary>
        /// Calories of whatever is selected
        /// </summary>
        public uint Calories { get; }

        /// <summary>
        /// Special instructions for whatever is selected
        /// </summary>
        public List<string> SpecialInstructions { get; }
    }
}
