using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAShopping
{
    public class ShoppingItem
    {
        private readonly int _id;

        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Vat { get; set; }

        public ShoppingItem(int _id, string name, decimal price, bool vat)
        {
            this._id = _id;
            Name = name;
            Price = price;
            Vat = vat;
        }
    }
}
