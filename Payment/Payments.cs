﻿using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Payment
{
    public class Payments
    {
        public int Id { get; set; }
        public string GuestName { get; set; }
        public string PaymentMethod { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Amount { get; set; }

    }
}
