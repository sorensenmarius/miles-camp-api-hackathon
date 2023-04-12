namespace Kolumbus;

public record Vehicle(
    Next_platform next_platform,
    string journey_id,
    string vehicle_id,
    string company_id,
    bool is_active,
    int delay,
    string line_id,
    string line_name,
    string destination_display,
    string origin_name,
    string destination_name,
    string previous_stop_id,
    string previous_stop_order,
    object next_stop_id,
    string next_stop_name,
    double longitude,
    double latitude,
    double speed,
    double heading,
    int link_distance,
    int percentage,
    string recorded_at_time,
    string origin_aimed_departure_time,
    string destination_aimed_arrival_time,
    object trip_state
);

public record Next_platform(
    string id,
    string nsr_id,
    string external_id,
    string stop_place_id,
    string name,
    string modification,
    object description,
    double latitude,
    double longitude,
    string type,
    string transport_mode,
    object sub_mode_type,
    string public_code,
    string private_code,
    string changed,
    string created
);

