using System;
using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string companyName, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            CompanyName = companyName;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            MarketCapitalization = pricePerShare * totalNumberOfShares;
        }

        public string CompanyName { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization { get; set; }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Company: {CompanyName}");
            result.AppendLine($"Director: { Director}");
            result.AppendLine($"Price per share: ${ PricePerShare}");
            result.AppendLine($"Market capitalization: ${ MarketCapitalization}");
            return result.ToString().TrimEnd();
        }
    }
}
