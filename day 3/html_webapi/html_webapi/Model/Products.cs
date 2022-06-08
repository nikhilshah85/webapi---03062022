namespace html_webapi.Model
{
    public class Products
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public double pPrice { get; set; }
        public string pCategory { get; set; }
        public string pImage { get; set; }

        static List<Products> pList = new List<Products>()
        {
            new Products(){ pId=101, pName="Pepsi", pCategory="Cold-Drink", pImage="", pPrice=50},
            new Products(){ pId=102, pName="IPhone", pCategory="Electronics", pImage="", pPrice=50},
            new Products(){ pId=103, pName="Maggie Noodles", pCategory="Fast-food", pImage="", pPrice=50},
            new Products(){ pId=104, pName="Dell Laptop", pCategory="Electronics", pImage="", pPrice=50},
        };

        public List<Products> DisplayProducts()
        {
            return pList;
        }
    }
}
