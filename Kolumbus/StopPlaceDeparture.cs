using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolumbus
{
    internal class StopPlaceDeparture
    {
        public class Rootobject
        {
            public string id { get; set; }
            public string line_number { get; set; }
            public string line_name { get; set; }
            public string transport_mode { get; set; }
            public string transport_sub_mode { get; set; }
            public string destination { get; set; }
            public string static_destination { get; set; }
            public bool alighting { get; set; }
            public bool boarding { get; set; }
            public string time_type { get; set; }
            public string time_source { get; set; }
            public string platform_id { get; set; }
            public string platform_name { get; set; }
            public string platform_code { get; set; }
            public string platform_external_id { get; set; }
            public string platform_nsr_id { get; set; }
            public string trip_id { get; set; }
            public int order { get; set; }
            public bool is_next_stop { get; set; }
            public string arrival_status { get; set; }
            public string departure_status { get; set; }
            public object schedule_arrival_time { get; set; }
            public DateTime schedule_departure_time { get; set; }
            public DateTime expected_arrival_time { get; set; }
            public DateTime expected_departure_time { get; set; }
            public object[] notices { get; set; }
            public DateTime creation_time { get; set; }
            public bool is_valid { get; set; }
            public string vehicle_id { get; set; }
        }
    }
}
