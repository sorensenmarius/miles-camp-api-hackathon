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

    public static StopPlace MoveAlongLine(StopPlace current, string tripId, int n)
    {
        var client = new HttpClient();

        var journeys =
            client.GetFromJsonAsync<List<Journey>>($"https://api.kolumbus.no/api/journeys/active")
                .Result;

        var currentJourney = journeys.First(j => j.trip_id == tripId);

        var stopTimes =
            client.GetFromJsonAsync<List<StopTime>>(
                    $"https://api.kolumbus.no/api/journeys/{currentJourney.id}/stoptimes")
                .Result;

        var currentStopTime = stopTimes.Find(stopTime => stopTime.platform_name == current.name);
        var currentStopTimeIndex = stopTimes.IndexOf(currentStopTime);
        var destinationStopTime = stopTimes[currentStopTimeIndex + n];
        
        var newPlatform =
            client.GetFromJsonAsync<Platform>(
                    $"https://api.kolumbus.no/api/platforms/{destinationStopTime.platform_id}")
                .Result;
        
        return client.GetFromJsonAsync<StopPlace>(
                    $"https://api.kolumbus.no/api/stopplaces/{newPlatform.stop_place_id}")
                .Result;
    }

    public static TimeSpan TravelTime(StopPlace from, StopPlace to)
    {
        throw new NotImplementedException();
    }

    public static List<StopPlaceDeparture> GetPossibleTransportations(StopPlace stopPlace)
    {
        var client = new HttpClient();

        List<StopPlaceDeparture>? stopPlacesDepartures =
            client.GetFromJsonAsync<List<StopPlaceDeparture>>(
                    $"https://api.kolumbus.no/api/stopplaces/{stopPlace.id}/departures")
                .Result;

        return stopPlacesDepartures;
    }
}