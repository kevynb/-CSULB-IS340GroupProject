using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GroupProject
{
    [XmlRoot("products")]
    public class ProductList
    {
        [XmlElement("product")]
        public List<Product> Products { get; set; }

        public ProductList()
        {
            Products = new List<Product>();
        }
    }
}