using InventoryManager.model;
using System.ComponentModel;
using System.Linq;


namespace wgu_968.model
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Instock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public void AddassociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool RemoveassociatedPart(int partID)
        {
         var part = LookupAssociatedPart(partID);
            if (part != null)
            {
                AssociatedParts.Remove(part);
                return true;
            }
         return false;
        }
        public Part LookupAssociatedPart(int partID)
        { 
            return AssociatedParts.FirstOrDefault(associatedPart => associatedPart.PartID == partID);
        }



    }
}
