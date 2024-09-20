﻿using ACME.CargoExpress.API.Registration.Domain.Model.Aggregates;
using ACME.CargoExpress.API.IAM.Domain.Model.Aggregates;
using ACME.CargoExpress.API.User.Domain.Model.Commands;

namespace ACME.CargoExpress.API.User.Domain.Model.Aggregates;

public class Client
{
    public Client()
    {
        Name = string.Empty;
        Phone = string.Empty;
        Ruc = string.Empty;
        Address = string.Empty;
        User = new IAM.Domain.Model.Aggregates.User();
        Trips = new List<Trip>();
    }

    public Client(string name, string phone, string ruc, string address, int userId, IAM.Domain.Model.Aggregates.User user)
    {
        Name = name;
        Phone = phone;
        Ruc = ruc;
        Address = address;
        UserId = userId;
        User = user;
        Trips = new List<Trip>();
    }
    
    public Client(CreateClientCommand command, IAM.Domain.Model.Aggregates.User user)
    {
        Name = command.Name;
        Phone = command.Phone;
        Ruc = command.Ruc;
        Address = command.Address;
        UserId = command.UserId;
        User = user;
        Trips = new List<Trip>();
    }
    
    public void Update(UpdateClientCommand command)
    {
        Name = command.Name;
        Phone = command.Phone;
        Ruc = command.Ruc;
        Address = command.Address;
    }
    
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Ruc { get; set; } 
    public string Address { get; set; }
    public IAM.Domain.Model.Aggregates.User User { get; set; }
    public int UserId { get; set; }
    
    
    public ICollection<Trip> Trips { get; }
    
}