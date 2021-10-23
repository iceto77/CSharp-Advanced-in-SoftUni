using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StockMarket
{
    public class Investor
    {
        private List<Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            portfolio = new List<Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count => portfolio.Count;

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization > 10000 && MoneyToInvest >= stock.PricePerShare)
            {
                portfolio.Add(stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            Stock stock = portfolio.FirstOrDefault(x => x.CompanyName == companyName);
            if (portfolio.Contains(stock))
            {
                if (stock.PricePerShare > sellPrice)
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    MoneyToInvest += sellPrice;
                    portfolio.Remove(stock);
                    return $"{companyName} was sold.";
                }
            }
            else
            {
                return $"{companyName} does not exist.";
            }
        }

        public Stock FindStock(string companyName)
        {
            return portfolio.FirstOrDefault(x => x.CompanyName == companyName);
        }

        public Stock FindBiggestCompany()
        {
            return portfolio.OrderByDescending(x => x.MarketCapitalization).FirstOrDefault();
        }

        public string InvestorInformation()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var item in portfolio)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString().TrimEnd();
        }
    }
}
