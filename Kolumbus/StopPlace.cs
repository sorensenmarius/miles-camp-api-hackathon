namespace Kolumbus;

public class StopPlace
{
    public string id { get; set; }
    public string external_id { get; set; }
    public string jbv_code { get; set; }
    public string name { get; set; }
    public object description { get; set; }
    public string modification { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string type { get; set; }
    public string transport_mode { get; set; }
    public string sub_mode_type { get; set; }
    public string valid_from { get; set; }
    public object valid_to { get; set; }
    public string created { get; set; }
    public string changed { get; set; }
}

