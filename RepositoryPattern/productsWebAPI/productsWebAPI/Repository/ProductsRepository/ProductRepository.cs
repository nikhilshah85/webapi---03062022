namespace productsWebAPI.Repository.ProductsRepository
{
    public class ProductRepository 
    {
        IProductRepository _prod;

        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public int pPrice { get; set; }
        public bool pIsInStock { get; set; }

        public List<ProductRepository> FetchAllProducts()
        {
            return _prod.GetAllProducts();
        }

        public ProductRepository FetchProductById(int productId)
        {
            return _prod.GetProductById(productId);
        }

        public List<ProductRepository> FetchAvailableProducts(bool Parameter)
        {
            return _prod.GetAllProductsInStock(Parameter);
        }





    }
}
