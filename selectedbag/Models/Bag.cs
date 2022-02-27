using System;
using System.ComponentModel.DataAnnotations;

namespace selectedbag.Models
{
    public class Bag
    {
        public int ID { get; set; }
        public string Type { get; set; }
        

        [DataType(DataType.Date)]
        public DateTime Packingdate { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
    }
}