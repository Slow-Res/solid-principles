namespace SOLID.InterfaceSegregationPrinciple
{
    public class SimplePrinter : IPrinter
    {
        public void Print(Document document)
        {
            Console.WriteLine("Printing document: " + document.Content);
        }
    }
}