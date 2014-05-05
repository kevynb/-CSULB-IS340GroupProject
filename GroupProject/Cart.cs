using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GroupProject
{
    public class Cart
    {
        public Dictionary<Product, int> _content {get; private set;}


        public Cart()
        {
            _content = new Dictionary<Product, int>();
        }
        
        public void update(Product p, int q)
        {
            _content[p] = q;
        }

        public double getTotal()
        {
            double total = 0;
            _content.ToList().ForEach(x => total += (x.Key.Price * x.Value) * ((x.Key.Taxable) ? (1.0875) : (1)));
            return Math.Round(total, 2);
        }
    } 
}
