using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonDataResult
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string apiUrl = "http://agl-developer-test.azurewebsites.net/people.json";
            //Send webRequest

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);

            //Get the Web Response

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //Now, create the Stream

            Stream responseStream = response.GetResponseStream();

            //Seting Up the Stream Reader

            StreamReader readerStream = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));
            //Get in a STring

            string json = readerStream.ReadToEnd();

           // Store the entire JSON text(web response) in a string type.

           //Close the Stream

            readerStream.Close();
            var articles = JsonConvert.DeserializeObject<List<Class1>>(json);
            // var pets = JsonConvert.DeserializeObject<List<Class1>>(json);

            // Close the Stream.
            // It's time to extract the data from the JSON file.For that, we must convert it into a JObject.
            //var jo = JObject.Parse(json);
            Console.WriteLine(" list of Cats");
            foreach (var Owner in articles)
            {
                if (Owner.pets != null&& Owner.pets[0].type == "Cat")
                {                   
                    Console.WriteLine(Owner.pets[0].name);
                    Console.WriteLine("{0}\t{1}\t{2}", Owner.name, Owner.gender, Owner.age);
                }
                
            }


            // Now, we try to get the Object Values.Since JObject treats its Name with an index name.

            //Console.WriteLine("Country : " + (string)jo["country_name"]);

            //Console.WriteLine("Country Code : " + (string)jo["country_code"]);

            //Console.WriteLine("Region Code : " + (string)jo["region_code"]);

            //Console.WriteLine("City : " + (string)jo["city"]);

            //Console.WriteLine("Zip Code :" + (string)jo["zipcode"]);

            //Console.WriteLine("Latitude :" + (string)jo["latitude"]);

            //Console.WriteLine("Longitude :" + (string)jo["longitude"]);
            }
    }
}
