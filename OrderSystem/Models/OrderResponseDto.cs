﻿namespace OrderSystem.Models
{
    public class OrderResponseDto
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }
        public int ClientId { get; set; }
    }
}
