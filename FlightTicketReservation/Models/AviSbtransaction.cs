﻿using System;
using System.Collections.Generic;

#nullable disable

namespace FlightTicketReservation.Models
{
    public partial class AviSbtransaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public double Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
