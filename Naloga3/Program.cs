using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Naloga3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Zaposleni> seznam = new List<Zaposleni>();

            string vsebina = Vrnivsebino("http://dummy.restapiexample.com/api/v1/employees");

            //vsebina povezave
            Console.WriteLine($"{vsebina}");

            //TODO 3.1
            //dodajte Nuget Newtonsoft.Json in odkomentirajte 
            /*
            JToken token = JToken.Parse(vsebina);
            JArray zaposleni = (JArray)token.SelectToken("data");
            foreach (JToken zap in zaposleni)
            {
                seznam.Add(new Zaposleni() { id = (int)zap["id"], employee_name = (string)zap["employee_name"], employee_age = (int)zap["employee_age"], employee_salary = (double)zap["employee_salary"] });
            }
            //*/



            //TODO 3.2
            //izracunajte povprecno placo in jo shranite v spremenljivko: povprecnaplaca

            //po vsaki poizvedbi izpisite seznam (naredi rezsiritev)


            //TODO 3.3
            //ustvarite seznam ljudi, ki majo placo visjo od povprecneplace z uporabo Linq


            //TODO 3.4
            //izpisite zaposlene, ki so stari med 30 in 50 let, razvrstite jih po placi padajoce


            //TODO 3.5
            //grupirajte zaposlene glede na starost (3x) je grupa 3, (4x)je grupa 4 in inzračunajte seštevek njihovih, plač in koliko je zaposlenih v tej grupi


        }

        static string Vrnivsebino(string url)
        {
            string vsebina = "";
            using (var webClient = new System.Net.WebClient())
            {
                vsebina = webClient.DownloadString(url);
            }
            return vsebina;
        }
    }

   
}
