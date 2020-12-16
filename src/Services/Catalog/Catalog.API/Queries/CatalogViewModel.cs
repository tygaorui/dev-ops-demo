using System.Globalization;

namespace Catalog.API.Queries
{
    public class Product
    {
        public string ProductName { get; set; }

        public string ProductLongName { get; set; }

        public string UnitPrice => (OriginPrice * 0.9m).ToString("c", new CultureInfo("zh-CN"));

        public decimal OriginPrice { get; set; }
    }
}
