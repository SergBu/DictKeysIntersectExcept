using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DictKeysIntersectExcept
{
    public class Helper
    {
        public static Dictionary<string, VehicleReservationDto> MapReservationFromApi(string restriction, List<VehicleReservationDto> deliveryResponse)
        {
            return deliveryResponse
                .Select(x => new VehicleReservationDto
                {
                    AreaId = 1,
                    VehicleId = 1,
                    CropId = 1,
                    ReservationByNewTripInShipping = true,
                    DriverId = 1,
                    ForReservationNotFoundTripInShipping = false
                })
            .ToDictionary(x =>
            ("vehicleId=" + x.VehicleId.ToString() + ','
            + "driverId=" + x.DriverId.ToString()
            ));
        }
    }
}
