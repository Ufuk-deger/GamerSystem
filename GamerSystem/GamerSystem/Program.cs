using System;

namespace GamerSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            SaleManager saleManager = new SaleManager(new CampaignApplyManager());
            saleManager.Sale(new Sales { SalesId = 2, ProductName = "İPhone", Campaign = false});
            gamerManager.Add(new Gamer { IdNumber = 1, FirstName = "Ufuk", LastName = "Değer" });
        }
    }
}
