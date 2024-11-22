using System.Runtime.InteropServices.JavaScript;

namespace ACME.CargoExpress.API.Registration.Domain.Model.ValueObjects;

public record TripData(string LoadLocation, string LoadDate, string UnloadLocation, string UnloadDate)
{
    public TripData() : this(string.Empty, string.Empty, string.Empty, string.Empty)
    {
    }
}