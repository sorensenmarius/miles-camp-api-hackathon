using System.Net.Http.Json;
using Kolumbus;

try
{
    var client = new HttpClient();
    
    string responseBody = await client.GetStringAsync("https://api.kolumbus.no/api/vehicles/realtimehub");

    List<Vehicle>? vehicles =
        await client.GetFromJsonAsync<List<Vehicle>>("https://api.kolumbus.no/api/vehicles/realtimehub");
}
catch (HttpRequestException e)
{
    Console.WriteLine("\nException Caught!");
    Console.WriteLine("Message :{0} ", e.Message);
}