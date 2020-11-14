/*
* Author: Jesse Babcock
* Class name: IOrderItem.cs
* Purpose: Interface for the Data library
*/
using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface for the menu items
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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

        public string Description { get; }

        /// <summary>
        /// Special instructions for whatever is selected
        /// </summary>
        public List<string> SpecialInstructions { get; }

        /// <summary>
        /// Name of the item
        /// </summary>
        public string Name { get; }
    }
}
