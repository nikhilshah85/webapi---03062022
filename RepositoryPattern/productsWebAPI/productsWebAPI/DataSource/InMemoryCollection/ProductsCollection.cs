using productsWebAPI.Repository.ProductsRepository;

namespace productsWebAPI.DataSource.InMemoryCollection
{
    public class ProductsCollection : IProductRepository
    {

        static List<ProductRepository> productsRepository = new List<ProductRepository>()
        {
            new ProductRepository(){ pId=501, pName="Bileri", pCategory="Water", pIsInStock=true, pPrice=20},
            new ProductRepository(){ pId=502, pName="Frostick", pCategory="Ice Cream", pIsInStock=true, pPrice=20},
            new ProductRepository(){ pId=503, pName="CornFlakes", pCategory="Diet Food", pIsInStock=false, pPrice=20},
            new ProductRepository(){ pId=504, pName="Green Tea", pCategory="Green Water", pIsInStock=true, pPrice=20},
            new ProductRepository(){ pId=505, pName="Butter", pCategory="Health Hazard", pIsInStock=false, pPrice=20},
            new ProductRepository(){ pId=506, pName="Pizza", pCategory="Junk Food", pIsInStock=true, pPrice=20},
        };

        public string AddProduct(ProductRepository newProduct)
        {
            throw new NotImplementedException();
        }

        public string DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductRepository> GetAllProducts()
        {
            return productsRepository;
        }

        public List<ProductRepository> GetAllProductsInStock(bool para)
        {
            var prod = from p in productsRepository
                       where p.pIsInStock == para
                       select p;
            return prod.ToList();
        }

       
        public ProductRepository GetProductById(int id)
        {
            var p = (from pr in productsRepository
                    where pr.pId == id
                    select pr).Single();
            return p;
        }

        public string UpdateProduct(ProductRepository changes)
        {
            throw new NotImplementedException();
        }
    }
}
