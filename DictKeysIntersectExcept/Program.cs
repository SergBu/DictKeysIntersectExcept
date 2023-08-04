// See https://aka.ms/new-console-template for more information
using DictKeysIntersectExcept;
using System.Reflection;
using System.Security.AccessControl;

var vehicleReservationFromDBDictionary = new Dictionary<string, VehicleReservationDto>();
var vehicleReservationFromApiDictionary = new Dictionary<string, VehicleReservationDto>();
var vehicleReservationDtos = new List<VehicleReservationDto>();

var vehicleReservationFromDBIntersectApiDictionary = vehicleReservationFromDBDictionary.Keys.Intersect(vehicleReservationFromApiDictionary.Keys)
    .ToDictionary(x => x, x => vehicleReservationFromDBDictionary[x]);

if (vehicleReservationFromDBIntersectApiDictionary.Any())
{
    vehicleReservationDtos.AddRange(vehicleReservationFromDBIntersectApiDictionary.Values.ToList());
}

var vehicleReservationFromApiExceptDBDictionary = vehicleReservationFromApiDictionary.Keys.Except(vehicleReservationFromDBDictionary.Keys)
    .ToDictionary(x => x, x => vehicleReservationFromApiDictionary[x]);

if (vehicleReservationFromApiExceptDBDictionary.Any())
{
    vehicleReservationDtos.AddRange(vehicleReservationFromApiExceptDBDictionary.Values.ToList());
}

var vehicleReservationFromDBExceptApiDictionary = vehicleReservationFromDBDictionary.Keys.Except(vehicleReservationFromApiDictionary.Keys)
    .ToDictionary(x => x, x => vehicleReservationFromDBDictionary[x]);

if (vehicleReservationFromDBExceptApiDictionary.Any())
{
    vehicleReservationDtos.AddRange(vehicleReservationFromDBExceptApiDictionary.Values.ToList());
}





