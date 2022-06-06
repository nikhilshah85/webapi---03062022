namespace productswebapi.Model
{
    public class Products
    {
        public int pid { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public string pManufacturer { get; set; }

        private static List<Products> pList = new List<Products>()
        {
            new Products(){ pid=101, pName="Pepsi", pCategory="Cold-Drink", pManufacturer="Pepsi co.", pPrice=50},
            new Products(){ pid=102, pName="Maggie", pCategory="Fast-food", pManufacturer="Nestle", pPrice=80},
            new Products(){ pid=103, pName="Pasta", pCategory="Fast-food", pManufacturer="HUL", pPrice=250},
        };

        public List<Products> GetAllProducts()
        {
            return pList;
        }
        public Products GetProductById(int p_id)
        {
            var product = (from p in pList
                           where p.pid == p_id
                           select p).Single();

            return product;
        }

        public string AddNewProduct(Products newProduct)
        {
            pList.Add(newProduct);
            return "New Product has been added successfully";
        }

        public string DeleteProduct(int p_id)
        {
            var product = (from p in pList
                           where p.pid == p_id
                           select p).Single();

            pList.Remove(product);
            return "Product has been removed successfully";
        }

        public string UpdateProduct(Products update)
        {
            var product = (from p in pList
                           where p.pid == update.pid
                           select p).Single();
            product.pName = update.pName;
            product.pCategory = update.pCategory;
            product.pPrice = update.pPrice;
            product.pManufacturer = update.pManufacturer;

            return "Product has been updated successfully";
            
        }
    }
}
