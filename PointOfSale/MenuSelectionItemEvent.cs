///Author: Jesse Babcock
///File: MenuSelectionItemEventArgs.cs
///Date: 9/27/20
using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSale
{
    /// <summary>
    /// Make button click into IOrderItem
    /// </summary>
    public class MenuSelectionItemEventArgs : EventArgs
    {
        public IOrderItem item;
    }
}
