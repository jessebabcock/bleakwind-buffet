/*
* Author: Jesse Babcock
* Class name: Combo.cs
* Purpose: Class for combos
*/
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entree;
using BleakwindBuffet.Data.Side;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing a combonation of Drink, Entree, and Side
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        private BleakwindBuffet.Data.Entree.Entree entree;
        private BleakwindBuffet.Data.Side.Side side;
        private Drink drink;
        private List<IOrderItem> items = new List<IOrderItem>();
        /// <summary>
        /// Gets the list of items for the combo's price, calories, and instructions
        /// </summary>
        /// <param name="e">Entree</param>
        /// <param name="s">Side</param>
        /// <param name="d">Drink</param>
        public Combo(BleakwindBuffet.Data.Entree.Entree e, BleakwindBuffet.Data.Side.Side s, Drink d)
        {
            entree = e;
            side = s;
            drink = d;
            CollectionChanged += CollectionChangedListener;
            Order comboOrder = new Order();
            if (e is IOrderItem eitem)
            {
                comboOrder.Add(eitem);
                items.Add(eitem);
            }
            if (s is IOrderItem sitem)
            {
                comboOrder.Add(sitem);
                items.Add(sitem);
            }
            if (e is IOrderItem ditem)
            {
                comboOrder.Add(ditem);
                items.Add(ditem);
            }
        }

        /// <summary>
        /// Gets combo price
        /// </summary>
        public double Price
        {
            get
            {
                double val = (entree.Price + side.Price + drink.Price - 1.00);
                return Math.Round(val, 2);
            }
        }

        /// <summary>
        /// Gets combo calories 
        /// </summary>
        public uint Calories 
        {
            get
            {
                return entree.Calories + side.Calories + drink.Calories;
            }
        }

        /// <summary>
        /// Gets combo special instructions
        /// </summary>
        public List<string> SpecialInstructions 
        {
            get 
            {
                List<string> instructions = new List<string>();
                instructions.Add(entree.ToString());
                foreach(string special in entree.SpecialInstructions)
                {
                    instructions.Add(special);
                }
                instructions.Add(drink.ToString());
                foreach (string special in drink.SpecialInstructions)
                {
                    instructions.Add(special);
                }
                instructions.Add(side.ToString());
                foreach (string special in side.SpecialInstructions)
                {
                    instructions.Add(special);
                }
                return instructions; 
            }
        }

        /// <summary>
        /// Listener to the list for changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Listener for each item in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public string Description
        {
            get
            {
                return $"{items[0].Description}, {items[1].Description}, {items[2].Description}";
            }
        }

        public string Name
        {
            get
            {
                foreach(IOrderItem item in items)
                {
                    if (item is BriarheartBurger)
                    {
                        return "Sailor Special";
                    }
                    if(item is PhillyPoacher)
                    {
                        return "Mad Philly Coffee";
                    }
                    if (item is GardenOrcOmelette)
                    {
                        return "Omelette it slide";
                    }
                    if (item is DoubleDraugr)
                    {
                        return "Double Trouble";
                    }
                }
                throw new ArgumentException("Should never reach");
            }
        }
    }
}
