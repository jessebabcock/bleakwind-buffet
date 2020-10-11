using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class representing the order
    /// </summary>
    public class Order : INotifyPropertyChanged, INotifyCollectionChanged, ICollection<IOrderItem>
    {
        public event NotifyCollectionChangedEventHandler CollectionChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// List of items for the order
        /// </summary>
        public List<IOrderItem> items = new List<IOrderItem>();

        private double salestax = .12;
        /// <summary>
        /// Sales tax defaulted to .12
        /// </summary>
        public double SalesTax
        {
            get { return salestax; }
            set
            {
                if(salestax != value)
                {
                    salestax = value;
                }
            }
        }

        double sum = 0.00;
        /// <summary>
        /// Subtotal grabs all items in the list and adds them together
        /// </summary>
        public double SubTotal
        {
            get
            {
                sum = 0;
                foreach(IOrderItem item in items)
                {
                    sum += item.Price;
                }
                return sum;
            }
        }

        /// <summary>
        /// Tax multiplies SalesTax and SubTotal
        /// </summary>
        public double Tax
        {
            get
            {
                double val = SalesTax * SubTotal;
                return Math.Round(val, 2);
            }
        }

        /// <summary>
        /// Total adds Tax and SubTotal
        /// </summary>
        public double Total
        {
            get
            {
                double val = Tax + SubTotal;
                return Math.Round(val, 2);
            }
        }

        uint calories;
        /// <summary>
        /// Calories grabs all items in the list and adds the calories together as uint
        /// </summary>
        public uint Calories
        {
            get
            {
                calories = 0;
                foreach (IOrderItem item in items)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }

        private static int orderNum = 1;
        /// <summary>
        /// Number of the order
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Gets the count of the collection
        /// </summary>
        public int Count => ((ICollection<IOrderItem>)items).Count;

        /// <summary>
        /// Makes it readonly
        /// </summary>
        public bool IsReadOnly => ((ICollection<IOrderItem>)items).IsReadOnly;

        /// <summary>
        /// Constructor for Order
        /// </summary>
        public Order()
        {
            Number = orderNum;
            orderNum++;
            CollectionChanged += CollectionChangedListener;
        }

        /// <summary>
        /// Listener to the list for changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
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
                    items.Clear();
                    break;
            }
            
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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }
            else if (e.PropertyName == "Calories")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Adds the item to the list
        /// </summary>
        /// <param name="item">item to be added</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            item.PropertyChanged += CollectionItemChangedListener;
        }

        /// <summary>
        /// Removes the item from the list
        /// </summary>
        /// <param name="item">item to be removed</param>
        public bool Remove(IOrderItem item, int index)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, index));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                item.PropertyChanged -= CollectionItemChangedListener;
            }
            return removed;
        }

        /// <summary>
        /// Clears the collection
        /// </summary>
        public void Clear()
        {
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        /// <summary>
        /// Checks collection if item is in it
        /// </summary>
        /// <param name="item">item to be checked</param>
        /// <returns>true if it is in the collection</returns>
        public bool Contains(IOrderItem item)
        {
            return ((ICollection<IOrderItem>)items).Contains(item);
        }

        /// <summary>
        /// Copies the collection to another array
        /// </summary>
        /// <param name="array">List of IOrderItems</param>
        /// <param name="arrayIndex">Index in the array</param>
        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            ((ICollection<IOrderItem>)items).CopyTo(array, arrayIndex);
        }
        
        /// <summary>
        /// Gets the enumerator
        /// </summary>
        /// <returns></returns>
        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return ((IEnumerable<IOrderItem>)items).GetEnumerator();
        }

        /// <summary>
        /// Is the enumerator
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)items).GetEnumerator();
        }

        public bool Remove(IOrderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
