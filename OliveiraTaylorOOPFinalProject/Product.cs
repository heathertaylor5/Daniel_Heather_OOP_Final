using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveiraTaylorOOPFinalProject
{
    public abstract class Product
    {
        //Properties
        public int InStock { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        //Constructors
        public Product() { }
        public Product(int inInStock, string inCode, decimal inPrice, string inDescription)
        {
            InStock= inInStock;
            Code= inCode;
            Price= inPrice;
            Description= inDescription;
        }

        //Methods
        public virtual string DisplayInfo(Product product)
            => String.Format();
    }

    public sealed class Photo : Product 
    {
        public bool Digital { get; set; }
        public bool Colour { get; set; }

        public Photo() { }
        public Photo(int inInStock, string inCode, decimal inPrice, string inDescription, bool inDigital, bool inColour) : 
            base(inInStock, inCode, inPrice, inDescription)
        {
            Digital = inDigital;
            Colour = inColour;
        }

        public override string DisplayInfo(Photo photo)
            => base.DisplayInfo(photo) + String.Format();
    }
}
