using System;
using System.Collections.Generic;
using System.Text;

namespace BVG.TicketApp.Wpf.Model
{
    public class Ticket
    {
        private string _typ;
        private string _district;
        private decimal _price;
        public string Typ
        {
            get { return _typ; }
            set { _typ = value; }

        }
        public string District
        {
            get { return _district; }
            set { _district = value; }

        }
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string FullInformation => $"{_district.ToUpper()} {_typ}: {_price}€";

    }
}
