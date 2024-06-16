namespace SOLID.InterfaceSegregationPrinciple
{
    public class MultifunctionPrinter : IPrinter, IScanner, IFax
    {
        public void Print(Document document)
        {
            Console.WriteLine("Printing document: " + document.Content);
        }

        public void Scan(Document document)
        {
            Console.WriteLine("Scanning document: " + document.Content);
        }

        public void Fax(Document document)
        {
            Console.WriteLine("Faxing document: " + document.Content);
        }
    }
}