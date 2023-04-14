namespace Kolumbus;

public class Journey
{
    public string id { get; set; }
    public string external_id { get; set; }
    public string trip_id { get; set; }
    public string name { get; set; }
    public string start_time { get; set; }
    public string end_time { get; set; }
    public object trip_state { get; set; }
}