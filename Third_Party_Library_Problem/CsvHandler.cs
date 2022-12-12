using CsvHelper;
using System.Globalization;

namespace Third_Party_Library_Problem
{
    public class CsvHandler
    {
        public static void ImlpementCSVDataHandling()
        {
            string importFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\Addressess.csv";
            string exportFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\ExportAddresses.csv";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data Successfully from addresses.csv, here are city");
                foreach (AddressData addressData in  records) 
                {
                    Console.WriteLine(addressData.city);
                }
                Console.WriteLine("\n*********************** Now Reading from Csv file and Write to Csv file ***********************");

                using (var writer = new StreamWriter(exportFilePath))
                using (var csvExport = new CsvWriter(writer,CultureInfo.InvariantCulture))
                {
                    csvExport.WriteRecords(records);
                }
            }
        }


    }
}
