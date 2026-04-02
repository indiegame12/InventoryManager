using InventoryManager.model;
using System.ComponentModel;
using System.Linq;

namespace wgu_968.model
{
    public class Inventory
    {
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Product> Products = new BindingList<Product>();

        public static void AddProduct(Product product) => Products.Add(product);

        public static bool RemoveProduct(int productId)
        {
            var product = lookupProduct(productId);
            if (product != null)
            {
                Products.Remove(product);
                return true;
            }
            return false;
        }

        public static Product lookupProduct(int productId)
        {
            var SearchProduct = Products.FirstOrDefault(product => product.ProductID == productId);
            return SearchProduct;
        }

        public static void AddPart(Part part) => AllParts.Add(part);

        public static bool DeletePart(Part part) => AllParts.Remove(part);

        public static Part lookupPart(int partId)
        {
            var SearchPart = AllParts.FirstOrDefault(part => part.PartID == partId);
            return SearchPart;
        }

        public static void updatePart(int partId, Part part)
        {
            int index = -1;
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].PartID == partId)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                AllParts[index] = part;
            }
        }

        public static void UpdateProduct(int productId, Product product)
        {
            int index = -1;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == productId)
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                Products[index] = product;
            }
        }
    }
}