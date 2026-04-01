using InventoryManager.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wgu_968.model
{
    public class Inventory
    {
        public static BindingList<Part> Parts = new BindingList<Part>();
        public static BindingList <Product> Products = new BindingList<Product>();

        public static void AddPart( Part part) => Parts.Add(part);
        public static bool DeletePart(Part part ) => Parts.Remove(part);
        public static Part SearchPart(int partId)
        {
            var SearchPart = Parts.FirstOrDefault(part => part.PartID == partId);
            return SearchPart;
        }

        public static void modifyPart(int partId, Part part)
        {
           Part modifedPart = SearchPart(partId);
            if (modifedPart != null)
            {
                int index = Parts.IndexOf(modifedPart);
                Parts[index] = part;
            }

            
            
        }
    }
}
