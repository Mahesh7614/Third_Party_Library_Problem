
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;

namespace Third_Party_Library_Problem
{
    public class ReadCSV_And_WriteJSON
    {
        public static void ImplementCSVTOJSON()
        {
            string importFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\Addressess.csv";
            string exportFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\Exportjson.json";

            using (var reader = new StreamReader(importFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<AddressData>().ToList();
                Console.WriteLine("Read data Successfully from addresses.csv");
                foreach (AddressData addressData in records)
                {
                    Console.Write("\t" + addressData.firstName);
                    Console.Write("\t" + addressData.lastName);
                    Console.Write("\t" + addressData.address);
                    Console.Write("\t" + addressData.city);
                    Console.Write("\t" + addressData.state);
                    Console.Write("\t" + addressData.zipCode);
                    Console.WriteLine();
                }
                Console.WriteLine("\n*********************** Now Reading from Csv file and Write to Json file ***********************");

                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(exportFilePath))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, records);
                }
            }
        }
    }
}
