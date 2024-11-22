namespace ACME.CargoExpress.API.Registration.Interfaces.REST.Resources;

public record UpdateTripResource(string Name, string Type, int Weight, string LoadLocation, string LoadDate, string UnloadLocation, string UnloadDate, int DriverId, int VehicleId, int ClientId, int EntrepreneurId);