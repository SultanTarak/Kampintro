using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1

{
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        //Birim fiyatı
        public double UnitPrice { get; set; }
        //Birim stok
        public int UnitsInStock { get; set; }
    
        
    
    }
}
