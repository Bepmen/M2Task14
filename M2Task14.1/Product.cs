using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2Task14._1
{
    public enum ProductTypes
    {
        Food,
        Appliances
    }
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public ProductTypes Type { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
