using SOLID.LiskovSubstitutionPrinciple;
using SOLID.OpenClosedPrinciple;
using SOLID.OpenClosedPrinciple.Enums;
using SOLID.OpenClosedPrinciple.Specifications;
using SOLID.SingleResponsibilityPrinciple;
using System.Diagnostics;

System.Console.WriteLine("SINGLE RESPONSIBILITY PRINCIPLE");
InitSRP();

System.Console.WriteLine("\nOPEN CLOSED PRINCIPLE");
InitOCP();

System.Console.WriteLine("\nLISKOV SUBSTITUTION PRINCIPLE");
InitLiskov();


static void InitSRP()
{
    // Each class should have only one responsibility ( Single Reason to make changes )
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
    // The Open Closed Principle states that the classes should be open for extension but closed for modification
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


static void InitLiskov()
{
    // Liskov Substitution Principle states that any code written to work with the base class
    // should also work correctly with a subclass, without needing any modifications
    Rectangle rectangle = new(7, 4);
    System.Console.WriteLine(rectangle.GetArea());

    Rectangle square = new Square();
    square.Width = 5;
    System.Console.WriteLine(square.GetArea());
}

static void Print(IEnumerable<string> items)
{
    Console.WriteLine(string.Join(Environment.NewLine, items));
}