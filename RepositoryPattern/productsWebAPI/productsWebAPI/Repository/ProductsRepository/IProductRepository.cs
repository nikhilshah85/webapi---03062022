namespace productsWebAPI.Repository.ProductsRepository
{
    public interface IProductRepository
    {
        List<ProductRepository> GetAllProducts();
        ProductRepository GetProductById(int id);
        List<ProductRepository> GetAllProductsInStock(bool para);
        string AddProduct(ProductRepository newProduct);
        string UpdateProduct(ProductRepository changes);
        string DeleteProduct(int id);
    }
}
