﻿namespace ACME.CargoExpress.API.User.Domain.Model.Commands;

public record CreateEntrepreneurCommand(string Name, string Phone, string Ruc, string Address, int UserId, string LogoImage);