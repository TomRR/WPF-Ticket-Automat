using System;
using System.Collections.Generic;
using System.Text;

namespace BVG.TicketApp.Wpf.Model
{
    public class Money
    {
        private decimal _value;
        public decimal Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public string MoneyString => $"{_value} €";

    }
}
