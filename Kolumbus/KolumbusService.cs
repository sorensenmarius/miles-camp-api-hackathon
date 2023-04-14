using System.Net.Http.Json;

namespace Kolumbus;

public static class KolumbusService
{
    public static StopPlace GetRandomStopPlace()
    {
        var client = new HttpClient();
        
        List<StopPlace>? stopPlaces =
            client.GetFromJsonAsync<List<StopPlace>>("https://api.kolumbus.no/api/stopplaces?transportMode=bus")
                .Result;

        return stopPlaces[new Random().Next(stopPlaces.Count)];
    }
}