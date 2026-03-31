using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgu_968.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        public int ProductID { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


   
    }
}
