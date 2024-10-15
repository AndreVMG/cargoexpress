﻿using ACME.CargoExpress.API.Registration.Domain.Model.Commands;
using ACME.CargoExpress.API.Registration.Domain.Model.Entities;
using ACME.CargoExpress.API.Registration.Domain.Repositories;
using ACME.CargoExpress.API.Registration.Domain.Services;
using ACME.CargoExpress.API.Shared.Domain.Repositories;
using ACME.CargoExpress.API.User.Domain.Repositories;

namespace ACME.CargoExpress.API.Registration.Application.Internal.CommandServices;

public class VehicleCommandService(IVehicleRepository vehicleRepository, IEntrepreneurRepository entrepreneurRepository,IUnitOfWork unitOfWork)
    : IVehicleCommandService
{
    public async Task<Vehicle?> Handle(CreateVehicleCommand command)
    {
        var entrepreneur = await entrepreneurRepository.FindByIdAsync(command.EntrepreneurId);
        if (entrepreneur == null)
        {
            throw new ArgumentException("EntrepreneurId not found.");
        }

        var vehicle = new Vehicle(command.Model, command.Plate, command.TractorPlate, command.MaxLoad, command.Volume, command.EntrepreneurId);
        await vehicleRepository.AddAsync(vehicle);
        await unitOfWork.CompleteAsync();
        return vehicle;
    }
    
    public async Task<Vehicle?> Handle(UpdateVehicleCommand command)
    {
        var vehicle = await vehicleRepository.FindByIdAsync(command.VehicleId);
        if (vehicle == null)
        {
            return null;
        }
        //Update the vehicle information
        vehicle.Model = command.Model;
        vehicle.Plate = command.Plate;
        vehicle.TractorPlate = command.TractorPlate;
        vehicle.MaxLoad = command.MaxLoad;
        vehicle.Volume = command.Volume;
        vehicle.EntrepreneurId = command.EntrepreneurId;
        
        await unitOfWork.CompleteAsync();
        return vehicle;
    }
}