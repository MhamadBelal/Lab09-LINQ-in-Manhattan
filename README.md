# Lab09-LINQ-in-Manhattan

## Summary:
The solution uses LINQ queries in C# to work with location data in Manhattan stored in a JSON file. It performs various operations such as outputting neighborhoods, filtering out neighborhoods without names, and removing duplicates. The queries are implemented using LINQ method chaining, and one question is also rewritten using LINQ query syntax.

## Visuals:
As the solution is a console application, it provides text-based output to the console, displaying the neighborhoods and the final counts based on the queries performed.

## Step-by-step directions (Happy Path):

1. Make sure you have the Newtonsoft.Json package installed in your project. If not, install it using the NuGet package manager.
2. Place the "data.json" file in the same directory as the program file.
3. Copy and paste the provided code into your C# project.
4. Run the program.
5. The console will display the output for each query, showing the neighborhoods and the final counts.

## Relevant Details:

* The solution uses the Newtonsoft.Json library to parse and deserialize the JSON file.
* The JSON file should have the specified structure, and the classes representing the JSON structure need to be defined correctly.
* The solution demonstrates both LINQ method calls and LINQ query syntax for performing the operations on the data.
* Make sure the "data.json" file exists and has the correct structure to avoid any file-related issues.
* You can customize the code and queries based on your specific needs or modify the classes to match the structure of your JSON data.
