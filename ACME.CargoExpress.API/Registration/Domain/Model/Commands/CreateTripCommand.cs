namespace ACME.CargoExpress.API.Registration.Domain.Model.Commands;

public record CreateTripCommand(string Name, string Type, int Weight, string LoadLocation, string LoadDate, string UnloadLocation, string UnloadDate, int DriverId, int VehicleId, int ClientId, int EntrepreneurId);