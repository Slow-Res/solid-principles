using SOLID.OpenClosedPrinciple;
using SOLID.OpenClosedPrinciple.Enums;
using SOLID.OpenClosedPrinciple.Specifications;
using SOLID.SingleResponsibilityPrinciple;
using System.Diagnostics;

System.Console.WriteLine("SINGLE RESPONSIBILITY PRINCIPLE");
InitSRP();

System.Console.WriteLine("\nOPEN CLOSED PRINCIPLE");
InitOCP();


static void InitSRP()
{
    var journals = new Journal();

    journals.AddEntry("Dummy Entry 1");
    journals.AddEntry("Dummy Entry 2");
    journals.AddEntry("Dummy Entry 3");

    System.Console.WriteLine(journals);

    var persist = new Persistence();
    var filePath = @"SingleResponsibilityPrinciple\journal.txt";
    persist.SaveToFile(journals, filePath);
}


static void InitOCP()
{
    List<Product> products =
    [
        new(name: "Kayak", color: Color.RED, size: Size.Small, 15),
        new(name: "Soccer ball", color: Color.BLUE, size: Size.Medium, 30),
        new(name: "Running shoes", color: Color.BLUE, size: Size.Small, 25),
        new(name: "Tennis shoes", color: Color.BLUE, size: Size.Small, 55),
    ];

    var result =  new ProductsFilter().Filter(products, new PriceSpecification(10,30)).Select( p => p.Name);

    Print(result);

}


static void Print(IEnumerable<string> items)
{
    Console.WriteLine(string.Join(Environment.NewLine, items));
}