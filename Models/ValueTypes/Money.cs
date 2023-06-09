﻿using System;
using WebApplication4.Models.Enums;

namespace WebApplication4.Models.ValueTypes
{
    public class Money
    {
        public Money() : this(Currency.EUR, 0.00m)
        { }
        public Money(Currency currency, decimal amount)
        {
            Amount = amount;
            Currency = currency;
        }
        private decimal amount = 0;
        public decimal Amount
        {
            get 
            { 
                return amount; 
            } 
            set {
                if (value < 0) {
                    throw new InvalidOperationException("The amount cannot be negative");
                }
                amount = value;
            }
        }
        public Currency Currency 
        { 
            get; set; 
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Amount, Currency);
        }
        public override string ToString()
        {
            return $"{Currency} {Amount:#.00}";
        }
        public override bool Equals(object obj)
        {
            if(obj is Money mo)
            {
                return Currency == mo.Currency && mo.amount == Amount;
            }
            else
            {
                return false;
            }
        }
    }
}
