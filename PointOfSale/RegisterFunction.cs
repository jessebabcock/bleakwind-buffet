///Author: Jesse Babcock
///File: RegisterFunction.cs
///Date: 9/27/20
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Public class for the register function
    /// </summary>
    public class RegisterFunction : INotifyPropertyChanged
    {
        /// <summary>
        /// private variables to hold info in the constructor
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        double tempTotal;
        double customerTotal;
        Order order;

        /// <summary>
        /// Gets the order in the constructor
        /// </summary>
        /// <param name="o"></param>
        public RegisterFunction(Order o)
        {
            order = o;
        }

        /// <summary>
        /// Gets register pennies
        /// </summary>
        public int Pennies
        {
            get { return CashDrawer.Pennies; }
            set
            {
                CashDrawer.Pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
            }
        }

        /// <summary>
        /// Gets register nickles
        /// </summary>
        public int Nickles
        {
            get { return CashDrawer.Nickels; }
            set
            {
                CashDrawer.Nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
            }
        }

        /// <summary>
        /// Gets register dimes
        /// </summary>
        public int Dimes
        {
            get { return CashDrawer.Dimes; }
            set
            {
                CashDrawer.Dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
            }
        }

        /// <summary>
        /// Gets register quarter
        /// </summary>
        public int Quarters
        {
            get { return CashDrawer.Quarters; }
            set
            {
                CashDrawer.Quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
            }
        }

        /// <summary>
        /// Gets register half dollar
        /// </summary>
        public int HalfDollars
        {
            get { return CashDrawer.HalfDollars; }
            set
            {
                CashDrawer.HalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
            }
        }

        /// <summary>
        /// Gets register dollar coins
        /// </summary>
        public int DollarCoin
        {
            get { return CashDrawer.Dollars; }
            set
            {
                CashDrawer.Dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
            }
        }

        /// <summary>
        /// Gets register Ones
        /// </summary>
        public int Ones
        {
            get { return CashDrawer.Ones; }
            set
            {
                CashDrawer.Ones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
            }
        }

        /// <summary>
        /// Gets register Twos
        /// </summary>
        public int Twos
        {
            get { return CashDrawer.Twos; }
            set
            {
                CashDrawer.Twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
            }
        }

        /// <summary>
        /// Gets register Fives
        /// </summary>
        public int Fives
        {
            get { return CashDrawer.Fives; }
            set
            {
                CashDrawer.Fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
            }
        }

        /// <summary>
        /// Gets register Tens
        /// </summary>
        public int Tens
        {
            get { return CashDrawer.Tens; }
            set
            {
                CashDrawer.Tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
            }
        }

        /// <summary>
        /// Gets register twenties
        /// </summary>
        public int Twenties
        {
            get { return CashDrawer.Twenties; }
            set
            {
                CashDrawer.Twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
            }
        }

        /// <summary>
        /// Gets register fifties
        /// </summary>
        public int Fifties
        {
            get { return CashDrawer.Fifties; }
            set
            {
                CashDrawer.Fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
            }
        }

        /// <summary>
        /// Gets register hundreds
        /// </summary>
        public int Hundreds
        {
            get { return CashDrawer.Hundreds; }
            set
            {
                CashDrawer.Hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
            }
        }

        /// <summary>
        /// Gets order total
        /// </summary>
        public double Total
        {
            get { return order.Total; }
        }

        /// <summary>
        /// Gets amount due
        /// </summary>
        public double AmountDue
        {
            get 
            {
                if (Total - customerTotal > 0) return Total - customerTotal;
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets amount owed
        /// </summary>
        private double amountOwe = 0;
        public double AmountOwe
        {
            get
            {
                amountOwe = customerTotal - Total;
                if (AmountDue == 0)
                {
                    ResetChange();
                    tempTotal = amountOwe;
                    GetChangeAmounts(amountOwe);
                    return Math.Round(amountOwe, 2);
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                amountOwe = value;
            }
        }

        /// <summary>
        /// Gets change in pennies
        /// </summary>
        int changePennies;
        public int ChangePennies
        {
            get
            {
                return changePennies;
            }
            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
            }
        }

        /// <summary>
        /// Gets change in nickles
        /// </summary>
        int changeNickles;
        public int ChangeNickles
        {
            get
            {
                return changeNickles;
            }
            set
            {
                changeNickles = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickles"));
            }
        }

        /// <summary>
        /// Gets change in dimes
        /// </summary>
        int changeDimes;
        public int ChangeDimes
        {
            get
            {
                return changeDimes;
            }
            set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
            }
        }

        /// <summary>
        /// Gets change in quarters
        /// </summary>
        int changeQuarters;
        public int ChangeQuarters
        {
            get
            {
                return changeQuarters;
            }
            set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
            }
        }

        /// <summary>
        /// Gets change in half dollars
        /// </summary>
        int changeHalfDollars;
        public int ChangeHalfDollars
        {
            get
            {
                return changeHalfDollars;
            }
            set
            {
                changeHalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHalfDollars"));
            }
        }

        /// <summary>
        /// Gets change in dollar coin
        /// </summary>
        int changeDollarCoin;
        public int ChangeDollarCoin
        {
            get
            {
                return changeDollarCoin;
            }
            set
            {
                changeDollarCoin = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollarCoin"));
            }
        }

        /// <summary>
        /// Gets change in ones
        /// </summary>
        int changeOnes;
        public int ChangeOnes
        {
            get
            {
                return changeOnes;
            }
            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
            }
        }

        /// <summary>
        /// Gets change in twos
        /// </summary>
        int changeTwos;
        public int ChangeTwos
        {
            get
            {
                return changeTwos;
            }
            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
            }
        }

        /// <summary>
        /// Gets change in fives
        /// </summary>
        int changeFives;
        public int ChangeFives
        {
            get
            {
                return changeFives;
            }
            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
            }
        }

        /// <summary>
        /// Gets change in tens
        /// </summary>
        int changeTens;
        public int ChangeTens
        {
            get
            {
                return changeTens;
            }
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
            }
        }

        /// <summary>
        /// Gets change in twenties
        /// </summary>
        int changeTwenties;
        public int ChangeTwenties
        {
            get
            {
                return changeTwenties;
            }
            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
            }
        }

        /// <summary>
        /// Gets change in fifties
        /// </summary>
        int changeFifties;
        public int ChangeFifties
        {
            get
            {
                return changeFifties;
            }
            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
            }
        }

        /// <summary>
        /// Gets change in hundreds
        /// </summary>
        int changeHundreds;
        public int ChangeHundreds
        {
            get
            {
                return changeHundreds;
            }
            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
            }
        }

        /// <summary>
        /// Gets the amount of change in each bill needed
        /// </summary>
        void GetChangeAmounts(double total)
        {
            tempTotal = total;
            while(tempTotal / 100 > 1)
            {
                tempTotal -= 100;
                ChangeHundreds++;
            }
            while (tempTotal / 50 > 1)
            {
                tempTotal -= 50;
                ChangeFifties++;
            }
            while (tempTotal / 20 > 1)
            {
                tempTotal -= 20;
                ChangeTwenties++;
            }
            while (tempTotal / 10 > 1)
            {
                tempTotal -= 10;
                ChangeTens++;
            }
            while (tempTotal / 5 > 1)
            {
                tempTotal -= 5;
                ChangeFives++;
            }
            while (tempTotal / 2 > 1)
            {
                tempTotal -= 2;
                ChangeTwos++;
            }
            while (tempTotal > 1)
            {
                tempTotal -= 1;
                ChangeOnes++;
            }
            tempTotal *= 100;
            while (tempTotal / 100 > 1)
            {
                tempTotal -= 100;
                ChangeDollarCoin++;
            }
            while (tempTotal / 50 > 1)
            {
                tempTotal -= 50;
                ChangeHalfDollars++;
            }
            while (tempTotal / 25 > 1)
            {
                tempTotal -= 25;
                ChangeQuarters++;
            }
            while (tempTotal / 10 > 1)
            {
                tempTotal -= 10;
                ChangeDimes++;
            }
            while (tempTotal / 5 > 1)
            {
                tempTotal -= 5;
                ChangeNickles++;
            }
            while (tempTotal > 1)
            {
                tempTotal -= 1;
                ChangePennies++;
            }
        }

        /// <summary>
        /// Gets customer pennies
        /// </summary>
        int customerPennies = 0;
        public int CustomerPennies
        {
            get { return customerPennies; }
            set
            {
                customerPennies = value;
                customerTotal += .05;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer nickles
        /// </summary>
        int customerNickles = 0;
        public int CustomerNickles
        {
            get { return customerNickles; }
            set
            {
                customerNickles = value;
                customerTotal += .05;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickles"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer dimes
        /// </summary>
        int customerDimes = 0;
        public int CustomerDimes
        {
            get { return customerDimes; }
            set
            {
                customerDimes = value;
                customerTotal += .1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer quarters
        /// </summary>
        int customerQuarters = 0;
        public int CustomerQuarters
        {
            get { return customerQuarters; }
            set
            {
                customerQuarters = value;
                customerTotal += .25;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer half dollar
        /// </summary>
        int customerHalfDollar = 0;
        public int CustomerHalfDollars
        {
            get { return customerHalfDollar; }
            set
            {
                customerHalfDollar = value;
                customerTotal += .5;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer dollar coins
        /// </summary>
        int customerDollarCoin = 0;
        public int CustomerDollarCoin
        {
            get { return customerDollarCoin; }
            set
            {
                customerDollarCoin = value;
                customerTotal += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollarCoin"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer ones
        /// </summary>
        int customerOnes = 0;
        public int CustomerOnes
        {
            get { return customerOnes; }
            set
            {
                customerOnes = value;
                customerTotal += 1;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer twos
        /// </summary>
        int customerTwos = 0;
        public int CustomerTwos
        {
            get { return customerTwos; }
            set
            {
                customerTwos = value;
                customerTotal += 2;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer fives
        /// </summary>
        int customerFives = 0;
        public int CustomerFives
        {
            get { return customerFives; }
            set
            {
                customerFives = value;
                customerTotal += 5;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer tens
        /// </summary>
        int customerTens = 0;
        public int CustomerTens
        {
            get { return customerTens; }
            set
            {
                customerTens = value;
                customerTotal += 10;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer twenties
        /// </summary>
        int customerTwenties = 0;
        public int CustomerTwenties
        {
            get { return customerTwenties; }
            set
            {
                customerTwenties = value;
                customerTotal += 20;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer fifties
        /// </summary>
        int customerFifties = 0;
        public int CustomerFifties
        {
            get { return customerFifties; }
            set
            {
                customerFifties = value;
                customerTotal += 50;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Gets customer hundreds
        /// </summary>
        int customerHunderds = 0;
        public int CustomerHundreds
        {
            get { return customerHunderds; }
            set
            {
                customerHunderds = value;
                customerTotal += 100;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountOwe"));
            }
        }

        /// <summary>
        /// Resets the change given
        /// </summary>
        void ResetChange()
        {
            ChangeDimes = 0;
            ChangeDollarCoin = 0;
            ChangeFifties = 0;
            ChangeFives = 0;
            ChangeHalfDollars = 0;
            ChangeHundreds = 0;
            ChangeNickles = 0;
            ChangeOnes = 0;
            ChangePennies = 0;
            ChangeQuarters = 0;
            ChangeTens = 0;
            ChangeTwenties = 0;
            ChangeTwos = 0;
        }
    }
}
