using System;
using primero_pasos.Models;

Paciente paciente1 = new Paciente
{
    Id = 1,
    Nombre = "Carlos Mendoza",
    Edad = 34,
    Sintoma = "Fiebre alta"
};

Console.WriteLine("--- Paciente Registrado ---");
Console.WriteLine($"[ID: {paciente1.Id}] {paciente1.Nombre} - {paciente1.Edad} años- {paciente1.Sintoma} sintoma");
