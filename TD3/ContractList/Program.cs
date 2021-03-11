using System;
using System.Collections.Generic;
using System.Text;

namespace ContractList
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();

        public static object JsonSerializer { get; private set; }

        static async Task Main()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                string url = "https://api.jcdecaux.com/vls/v3/";
                string data = "contracts";
                string apiKey = "76e5a6818bf2b41854f1f851546c5536616a40c3";
                HttpResponseMessage response = await client.GetAsync(url + data + "?apiKey=" + apiKey);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Contract[] contracts = JsonSerializer.Deserialize<Contract>(responseBody);

                Console.WriteLine(responseBody);
                Console.ReadLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
    }
}
