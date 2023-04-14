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

    /**
     * n = number of stops to include
     */
    public static TimeSpan GetTimeToNextStops(string vehicleId, int n)
    {
        throw new NotImplementedException();
    }

    public static StopPlace MoveAlongLine(string lineId, int n)
    {
        throw new NotImplementedException();
    }

    public static TimeSpan TravelTime(StopPlace from, StopPlace to)
    {
        throw new NotImplementedException();
    }

    public static List<StopPlaceDeparture> GetPossibleTransportations(StopPlace stopPlace)
    {
        var client = new HttpClient();

        List<StopPlaceDeparture>? stopPlacesDepartures =
            client.GetFromJsonAsync<List<StopPlaceDeparture>>($"https://api.kolumbus.no/api/stopplaces/{stopPlace.id}/departures")
                .Result;

        return stopPlacesDepartures;

    }
}