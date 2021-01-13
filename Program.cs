using System;
using System.Text.Json;
using System.Collections.Generic;

namespace json
{
    class Program
    {
        protected class MyType
        {
            public IList<string> Messages { get; set; } = new List<string>();
        }

        static void Main(string[] args)
        {
            MyType obj = new() { Messages = { "Hello World!", "Some more text" } };
            JsonSerializerOptions options = new() { WriteIndented = true };
            var jsonText = JsonSerializer.Serialize(obj, options);
            Console.WriteLine(jsonText);

            var anotherJson = "{\r\n\"Messages\": [\r\n\"Another Hello!\", \"Who wants to live forever?\", \"Bohemian Rapsody\"\r\n]\r\n}";
            MyType anotherobj = JsonSerializer.Deserialize<MyType>(anotherJson);
            foreach (var message in anotherobj.Messages)
            {
                Console.WriteLine(message);
            }
        
        }
    }
}
