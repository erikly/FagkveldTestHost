using System;

namespace BeerService.Data.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public int AmountInMilliliters { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
