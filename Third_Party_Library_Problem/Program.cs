namespace Third_Party_Library_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Read data from CSV and Write data in CSV");

            CsvHandler.ImlpementCSVDataHandling();
            Console.WriteLine();

            Console.WriteLine(" Read data from CSV and Write data in JSON");

            ReadCSV_And_WriteJSON.ImplementCSVTOJSON();
            Console.WriteLine();

            Console.WriteLine(" Read data from JSON and Write data in CSV");
            ReadJSON_And_WriteCSV.ImplementJSONToCSV();
            Console.WriteLine();


        }
    }
}