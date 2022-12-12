
using CsvHelper;
using Newtonsoft.Json;
using System.Globalization;

namespace Third_Party_Library_Problem
{
    public class ReadJSON_And_WriteCSV
    {
        public static void ImplementJSONToCSV()
        {
            string importFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\Exportjson.json";
            string exportFilePath = @"C:\Users\Mahesh\OneDrive\Desktop\Assignments\RFP .Net Assignment\Third_Party_Library_Problem\Third_Party_Library_Problem\Utility\ExportCsvForJson.csv";

            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));
            foreach (AddressData Data in addressData)
            {
                Console.Write(Data.firstName + "\t");
                Console.Write(Data.lastName + "\t");
                Console.Write(Data.address + "\t");
                Console.Write(Data.city + "\t");
                Console.Write(Data.state + "\t");
                Console.Write(Data.zipCode + "\t");
                Console.WriteLine();
            }
            Console.WriteLine("\n*********************** Now Reading from Json file and Write to Csv file ***********************");

            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer,CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
