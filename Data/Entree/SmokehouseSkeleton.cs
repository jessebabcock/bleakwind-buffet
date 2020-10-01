/*
* Author: Jesse Babcock
* Class name: SmokehouseSkeleton.cs
* Purpose: To set prices and sizes of Smokehouse Skeleton
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
    /// Public class for Smokehouse Skeleton
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Ingredient variables set to true
        /// </summary>
        bool sausageLink = true, egg = true, hashBrowns = true, pancake = true;

        /// <summary>
        /// Gets price in double
        /// </summary>
        private double price;
        public override double Price
        {
            get
            {
                price = 5.62;
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
                calories = 602;
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
                if (!SausageLink)   instructions.Add("Hold sausage");
                if (!Egg)           instructions.Add("Hold egg");
                if (!HashBrowns)    instructions.Add("Hold hashbrowns");
                if (!Pancake)       instructions.Add("Hold pancake");
                return instructions;
            }
        }

        /// <summary>
        /// Gets if they want sausagelinks or not default true
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
            }
        }

        /// <summary>
        /// Gets if they want eggs or not default true
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
            }
        }

        /// <summary>
        /// Gets if they want hashbrowns or not default true
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
            }
        }

        /// <summary>
        /// Gets if they want a pancake or not default true
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
            }
        }

        /// <summary>
        /// Prints Smokehouse Skeleton
        /// </summary>
        /// <returns>String of Smokehouse Skeleton</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
