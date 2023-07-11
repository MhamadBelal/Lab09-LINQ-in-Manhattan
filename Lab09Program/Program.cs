using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Text.Json.Nodes;

namespace Lab09Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The first Way to solve the lab without making classes

            //string json =File.ReadAllText("../../../data.json");
            //JObject root = JObject.Parse(json);
            //JArray data = (JArray)root["features"];

            ////Question 1: Output all of the neighborhoods in this data list (Final Total: 147 neighborhoods)
            //Console.WriteLine("Neighborhoods:");
            //foreach (JObject item in data)
            //{
            //    string neighborhood = item["properties"]["neighborhood"].ToString();
            //    Console.WriteLine(neighborhood);
            //}
            //Console.WriteLine("Final Total: " + data.Count);

            //Console.WriteLine("**************************");

            ////Question 2: Filter out all the neighborhoods that do not have any names (Final Total: 143)
            //var filterNeighborhood = data.Where(item => !string.IsNullOrEmpty(item["properties"]["neighborhood"].ToString()))
            //    .Select(item => item["properties"]["neighborhood"].ToString())
            //    .ToList();
            //Console.WriteLine("Filtered Neighborhoods (without empty names):");
            //foreach (var neighborhood in filterNeighborhood)
            //{
            //    Console.WriteLine(neighborhood);
            //}
            //Console.WriteLine("Final Total: " + filterNeighborhood.Count);

            //Console.WriteLine("**************************");

            ////Question 3: Remove the duplicates (Final Total: 39 neighborhoods)
            //var filterNeighborhoodduplicates = filterNeighborhood.Distinct().ToList();
            //Console.WriteLine("Unique Neighborhoods:");
            //foreach (var neighborhood in filterNeighborhoodduplicates)
            //{
            //    Console.WriteLine(neighborhood);
            //}
            //Console.WriteLine("Final Total: " + filterNeighborhoodduplicates.Count);

            //Console.WriteLine("**************************");

            //// Question 4: Rewrite the queries from above and consolidate all into one single query.
            //var uniqueNeighborhoods = data
            //.Where(item => !string.IsNullOrEmpty(item["properties"]["neighborhood"].ToString()))
            //.Select(item => item["properties"]["neighborhood"].ToString())
            //.Distinct()
            //.ToList();
            //Console.WriteLine("Unique Neighborhoods:");
            //foreach (var neighborhood in uniqueNeighborhoods)
            //{
            //    Console.WriteLine(neighborhood);
            //}
            //Console.WriteLine("Final Total: " + uniqueNeighborhoods.Count);

            //Console.WriteLine("**************************");

            ////Question 5: Rewrite at least one of these questions only using the opposing method (example: Use LINQ Query statements instead of LINQ method calls and vice versa.)
            //var filteredNeighborhoodsQueryStatements = ( from item in data where !string.IsNullOrEmpty(item["properties"]["neighborhood"].ToString())
            //                                           select item["properties"]["neighborhood"].ToString()).ToList() ;
            //var uniqueNeighborhoods2 = filteredNeighborhoodsQueryStatements.Distinct().ToList();
            //Console.WriteLine("Unique Neighborhoods:");
            //foreach (var neighborhood in uniqueNeighborhoods2)
            //{
            //    Console.WriteLine(neighborhood);
            //}
            //Console.WriteLine("Final Total: " + uniqueNeighborhoods2.Count);



            string json = File.ReadAllText("../../../data.json");
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(json);


            //Question 1
            var neighborhoods = rootObject.Features.Select(feature => feature.Properties.Neighborhood);
            Console.WriteLine("Neighborhoods:");
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine("Final Total: " + neighborhoods.Count());


            //Question 2
            neighborhoods = neighborhoods.Where(neighborhood => !string.IsNullOrEmpty(neighborhood));
            Console.WriteLine("\nFiltered Neighborhoods (without empty names):");
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine("Final Total: " + neighborhoods.Count());


            //Question 3
            neighborhoods = neighborhoods.Distinct();
            Console.WriteLine("\nUnique Neighborhoods:");
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine("Final Total: " + neighborhoods.Count());


            //Question 4
            neighborhoods = rootObject.Features
            .Select(feature => feature.Properties.Neighborhood)
            .Where(neighborhood => !string.IsNullOrEmpty(neighborhood))
            .Distinct();
            Console.WriteLine("\nRewritten Query (Consolidated):");
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine("Final Total: " + neighborhoods.Count());


            //Question 5
            neighborhoods = (from feature in rootObject.Features
                             select feature.Properties.Neighborhood)
                            .Where(neighborhood => !string.IsNullOrEmpty(neighborhood))
                            .Distinct();
            Console.WriteLine("\nRewritten Query (Opposing Method):");
            foreach (var neighborhood in neighborhoods)
            {
                Console.WriteLine(neighborhood);
            }
            Console.WriteLine("Final Total: " + neighborhoods.Count());
        }
    }
}