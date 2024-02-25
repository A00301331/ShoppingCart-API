using System;

namespace AuthAPIModels
{
    public class Product
    {
        public int id_ { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        public Category Category { get; set; } // Add this property

    }
}
