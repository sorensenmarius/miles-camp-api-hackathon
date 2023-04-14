namespace Kolumbus;

public class Platform
{
    public string id { get; set; }
    public string nsr_id { get; set; }
    public string external_id { get; set; }
    public string stop_place_id { get; set; }
    public string name { get; set; }
    public string modification { get; set; }
    public object description { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string type { get; set; }
    public string transport_mode { get; set; }
    public object sub_mode_type { get; set; }
    public string public_code { get; set; }
    public object private_code { get; set; }
    public string changed { get; set; }
    public string created { get; set; }
}