using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            // in >NET, for XML serialization, we have
            //  - DataContractSerializer
            //  - XMLSerializer (old, non-generic)
            // for JSON serialization, we have
            //  -JSON.NET aka Newtonsoft JSON (third-party)
            //  -DataContractSerializer
            //  -System.Text.Json (brand new)(we'll use this one today)

            string filePath = "../../../data.json";
            List<Person> data = null;
            if(!File.Exists(filePath))
            {
                data = GetInitialData();
                string json = ConvertToJson(data);
                WriteToFile(json);
            }
            else
            {
                //string jsonData = ReadFromFile(filePath);
                string jsonData = File.ReadAllText(filePath);
                data = JsonSerializer.Deserialize<List<Person>>(jsonData);
                // read JSON from file
                // and deserialize it
            }
            ModifyPersons(data);
            string json2 = ConvertToJson(data);
            WriteToFile(json2);
        }

        static void ModifyPersons(List<Person> data)
        {
            foreach (var item in data)
            {
                item.Id++;
            }
        }

        static string ReadFromFile(string filePath)
        {
            var sr = new StreamReader(filePath);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }
        static string ConvertToJson(List<Person> data)
        {
            return JsonSerializer.Serialize(data);
        }

        static void WriteToFile(string text)
        {
            var file = new FileStream("../../../data.json", FileMode.Create);
            //File.WriteAllText("../../../data.json",text);
            byte[] data = Encoding.UTF8.GetBytes(text);
            file.Write(data);
            file.Close();
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
