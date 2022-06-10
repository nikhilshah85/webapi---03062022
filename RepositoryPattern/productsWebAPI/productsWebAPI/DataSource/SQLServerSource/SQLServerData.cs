using productsWebAPI.Repository.ProductsRepository;
namespace productsWebAPI.DataSource.SQLServerSource
{
    public class SQLServerData : IProductRepository
    {
        static List<ProductRepository> productsRepository = new List<ProductRepository>()
        {
            new ProductRepository(){ pId=1, pName="Chocoflakes", pCategory="Diet Food", pIsInStock=true, pPrice=20},
            new ProductRepository(){ pId=2, pName="Beat Coffee", pCategory="Coffee", pIsInStock=false, pPrice=20},
            new ProductRepository(){ pId=3, pName="Latte", pCategory="Coffee", pIsInStock=false, pPrice=20},
            new ProductRepository(){ pId=4, pName="American Spicy Paneer", pCategory="Junk Food", pIsInStock=true, pPrice=20},
            new ProductRepository(){ pId=5, pName="Mozerella", pCategory="Cheese", pIsInStock=false, pPrice=20},
            new ProductRepository(){ pId=6, pName="Pears", pCategory="GlowSoap", pIsInStock=false, pPrice=20},
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

            //you will connect to database and get the
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
