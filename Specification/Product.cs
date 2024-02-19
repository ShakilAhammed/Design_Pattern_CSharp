using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Specification
{
    public class Product
    {
        private string _name;
        private double _price;
        private string _description;
        private Color _color;
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Product(string name, double price, string description, Color color)
        {
            _name = name;
            _price = price;
            _description = description;
            _color = color;
        }
    }
}
