using CategorizeTrades.Categories;
using CategorizeTrades.Trades;
using CategorizeTrades.Risk;

List<ITrade> portfolio;
List<string> tradeCategories;

Trade trade1 = new Trade { Value = 2000000, ClientSector = SectorRisk.Private, NextPaymentDate = new DateTime(2025, 12, 29), RefDate = new DateTime(2020, 11, 12) };
Trade trade2 = new Trade { Value = 400000, ClientSector = SectorRisk.Public, NextPaymentDate = new DateTime(2020, 01, 07), RefDate = new DateTime(2020, 11, 12) };
Trade trade3 = new Trade { Value = 5000000, ClientSector = SectorRisk.Public, NextPaymentDate = new DateTime(2024, 02, 01), RefDate = new DateTime(2020, 11, 12) };
Trade trade4 = new Trade { Value = 3000000, ClientSector = SectorRisk.Public, NextPaymentDate = new DateTime(2023, 10, 26), RefDate = new DateTime(2020, 11, 12) };
Trade trade5 = new Trade { Value = 1000000, ClientSector = SectorRisk.Private, NextPaymentDate = DateTime.Now, RefDate = new DateTime(2020, 11, 12), IsPoliticallyExposed = true };

portfolio = new List<ITrade> { trade1, trade2, trade3, trade4, trade5 };

tradeCategories = new Category(portfolio).GetCategories();

Console.Title = "Categories of Trades";

Console.WriteLine("Input:\n");
foreach (ITrade trade in portfolio)
{
    Console.WriteLine("{0} = {{ Value = {1}, ClientSector = {2}, NextPaymentDate = {3}, IsPoliticallyExposed = {4} }}", (Trade)trade, trade.Value, trade.ClientSector, trade.NextPaymentDate.ToString("dd/MM/yyyy"), trade.IsPoliticallyExposed);
}

Console.WriteLine("\nOutput:\n");
foreach (string tradeCategorie in tradeCategories)
{
    Console.WriteLine(tradeCategorie);
}

Console.Write("\n\nPress any key to continue...");
Console.ReadKey();