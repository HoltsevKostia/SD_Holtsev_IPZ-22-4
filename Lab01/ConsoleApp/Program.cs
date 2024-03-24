using ClassLibrary;

Money money = new UAH(10, 15);

Product product = new (money, "P1", "D1");

Console.WriteLine(product.Price.Summa());

product.PriceDecreaser(5);

Console.WriteLine(product.Price.Summa());
Console.WriteLine(product.Price.ToCurrency());


Warehouse warehouse = new Warehouse(new List<Product> { product , new (money, "P2", "D2") });

ReportingRegister.RegisterIncoming(warehouse, 10, DateTime.Now);
ReportGeneratorConsole reportGeneratorConsole = new ReportGeneratorConsole();

reportGeneratorConsole.GenerateReport_Console(warehouse);

ReportingRegister.RegisterOutgoing(warehouse, 8);
reportGeneratorConsole.GenerateReport_Console(warehouse);



