using BVG.TicketApp.Wpf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BVG.TicketApp.Wpf.ViewModel
{
    class TicketViewModel
    {
        private List<Ticket> _ticketList;
        private List<Money> _money;
        public TicketViewModel()
        {
            _ticketList = LoadTickets();
            _money = LoadMoney();
        }
        public List<Ticket> TicketList
        {
            get
            {
                return _ticketList;
            }
        }        
        public List<Money> MoneyList
        {
            get
            {
                return _money;
            }
        }

        private List<Ticket> LoadTickets()
        {
            return new List<Ticket>()
            {
                new Ticket() {Typ = "One Way", District="AB", Price=2.90M},
                new Ticket() {Typ = "Day Pass", District="AB", Price=8.60M},
                new Ticket() {Typ = "One Way", District="BC", Price=3.30M},
                new Ticket() {Typ = "Day Pass", District="BC", Price=9.00M},
                new Ticket() {Typ = "One Way", District="ABC", Price=3.60M},
                new Ticket() {Typ = "Day Pass", District="ABC", Price=9.60M},
            };
        }        
        private List<Money> LoadMoney()
        {
            return new List<Money>()
            {
                new Money() { Value = 0.10M },
                new Money() { Value = 0.20M },
                new Money() { Value = 0.50M },
                new Money() { Value = 1.00M },
                new Money() { Value = 2.00M },
                new Money() { Value = 5.00M },
                new Money() { Value = 10.00M },
                new Money() { Value = 20.00M },
                new Money() { Value = 50.00M }

            };
        }
    }
}
