using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DictKeysIntersectExcept
{
    public class VehicleReservationDto
    {
        public int? TerminalTimeslotVehicleReservationId { get; set; }
        public int AreaId { get; set; }
        public int VehicleId { get; set; }
        public int CropId { get; set; }

        public bool ReservationByNewTripInShipping { get; set; }
        public bool ForReservationNotFoundTripInShipping { get; set; }

        [JsonIgnore]
        public int TerminalRestictionReservationId { get; set; }

        [JsonIgnore]
        public int DriverId { get; set; }
    }
}
