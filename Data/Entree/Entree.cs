using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entree
{
    /// <summary>
    /// A base class representing the common properties of the entree
    /// </summary>
    public abstract class Entree
    {

        /// <summary>
        /// Price of the entree
        /// </summary>
        /// <value>
        /// In US dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// Calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for the entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
