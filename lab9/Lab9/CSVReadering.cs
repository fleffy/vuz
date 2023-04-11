using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVReader
{
    public class CSVReadering
    {
        public void Reader(string path)
        {
            string dateFormat = "yyyy-MM-dd";
            int batchCount = 10;

            Func<string, DateTime> func = d => DateTime.ParseExact(d, dateFormat, null);

            Func<string, double> func1 = d => double.Parse(d);

            Action<DateTime, double> printTotal = (date, total) =>
            Console.WriteLine("{0}: {1}", date.ToString(dateFormat), total);

            var transactions = File.ReadLines(path)
           .Select(line => line.Split(','))
           .GroupBy(cols => func(cols[0]));

            foreach (var group in transactions)
            {
                double total = group.Sum(cols => func1(cols[1]));

                printTotal(group.Key, total);

                if (group.Count() >= batchCount)
                {
                    RewriteCsvFile(path, group, dateFormat);
                }
            }
        }

        static void RewriteCsvFile(string csvFilePath, IGrouping<DateTime, string[]> group, string dateFormat)
        {
            string backupFilePath = string.Format("{0}_{1}.bak", csvFilePath, group.Key.ToString(dateFormat));

            File.Copy(csvFilePath, backupFilePath, true);

            using (var writer = new StreamWriter(csvFilePath))
            {
                foreach (var cols in group)
                {
                    writer.WriteLine(string.Join(",", cols));
                }
            }
        }
    }
}
