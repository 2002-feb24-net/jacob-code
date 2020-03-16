using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static string filePath = "../../../data.json";
        static async Task Main(string[] args)
        {
            // in >NET, for XML serialization, we have
            //  - DataContractSerializer
            //  - XMLSerializer (old, non-generic)
            // for JSON serialization, we have
            //  -JSON.NET aka Newtonsoft JSON (third-party)
            //  -DataContractSerializer
            //  -System.Text.Json (brand new)(we'll use this one today)

            List<Person> data = null;
            if(!File.Exists(filePath))
            {
                data = GetInitialData();
                string json = ConvertToJson(data);
                try
                {
                    await WriteToFileAsync(json);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Fatal error");
                    Console.WriteLine(ex.Message);
                }
                
            }
            else
            {
                //string jsonData = ReadFromFile(filePath);
                string jsonData = await File.ReadAllTextAsync(filePath);
                //string jsonData2 = await ReadFromFileAsync(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(jsonData);
                // read JSON from file
                // and deserialize it
            }
            ModifyPersons(data);
            string json2 = ConvertToJson(data);
            await WriteToFileAsync(json2);
        }

        static void ModifyPersons(List<Person> data)
        {
            foreach (var item in data)
            {
                item.Id++;
            }
        }

        async static Task<string> ReadFromFileAsync(string filePath)
        {
            //using(var sr = new StreamReader(filePath))
            //{
            //    string text = sr.ReadToEnd();
            //    return text;
            //}
            var sr = new StreamReader(filePath);
            Task<string> textTask = sr.ReadToEndAsync();
            // at this point, the operation might have already started
            string text = await textTask;
            // the away keyword pauses this method right here
            // while still letting other operations in the rest of the
            // program continue
            // (e.g. other ongoing Tasks)
            sr.Close();
            return text;
        }
        static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
        }

        static async Task WriteToFileAsync(string text)
        {
            //exception handling is important for good user experience
            //as well as data correctness etc

            //opening a file is something that definitely could go wrong
            //its code that we expect to sometimes throw an exception
            //any code like that, we should put in a try {} block
            FileStream file = null;
            try
            {
                file = new FileStream("../../../data.json", FileMode.Create);
                //File.WriteAllText("../../../data.json",text);
                byte[] data = Encoding.UTF8.GetBytes(text);
                await file.WriteAsync(data);
                file.Close();
            }
            //catch
            //{
            //   //we can catch ANY exception... this is bad practice
            //}
            catch (UnauthorizedAccessException ex)
            {
                //useful properties of the exception:
                // Message, StackTrace, InnerException
                Console.WriteLine($"Access to file {filePath} is not allowed by the OS: ");
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                if(file!=null)
                {
                    //file.Close();
                    file.Dispose();
                }
            }
        }
        static List<Person> GetInitialData()
        {
            var list = new List<Person>();
            var person1 = new Person();
            person1.Id = 1;
            person1.Name = "Nick";

            var person2 = new Person();
            person2.Id = 2;
            person2.Name = "Mark";
            person2.Children = new List<Person>
            {
                new Person { Id = 3, Name = "Ethan"},
                new Person { Id = 4, Name = "Hope"},
                new Person { Id = 5, Name = "Maya"},
            };

            list.Add(person1);
            list.Add(person2);
            return list;
        }
    }
}
