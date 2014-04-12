using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GroupProject
{
    public class Product
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("price")]
        public double Price { get; set; }

        [XmlElement("taxable")]
        public bool Taxable { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, bool taxable)
        {
            this.Name = name;
            this.Price = price;
            this.Taxable = taxable;
        }
    }
}