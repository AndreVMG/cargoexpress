﻿namespace ACME.CargoExpress.API.User.Domain.Model.Commands;

public record UpdateEntrepreneurCommand(int EntrepreneurId, string Name, string Phone, string Ruc, string Address, int UserId, string LogoImage);