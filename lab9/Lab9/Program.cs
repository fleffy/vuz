using CSVReader;

namespace Lab9
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\NewVSCODE\Lab9\Lab9\test.csv";
            CSVReadering cSVReadering = new CSVReadering();
            cSVReadering.Reader(path);
        }

    }
}