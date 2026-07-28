using System;
using primero_pasos.Models;

partial class Program
{
    static void Main(string[] args)
    {
        // 1. Esto es lo que ya tenías (crear el paciente de prueba)
        Paciente paciente1 = new Paciente
        {
            Id = 1,
            Nombre = "Carlos Mendoza",
            Edad = 34,
            Sintoma = "Fiebre alta"
        };

        Console.WriteLine("--- Paciente Registrado ---");
        Console.WriteLine($"[ID: {paciente1.Id}] {paciente1.Nombre} - {paciente1.Edad} años - {paciente1.Sintoma} síntoma");
        
        // Pausa breve para ver los datos del paciente registrado antes del menú
        Console.WriteLine("\nPresione una tecla para entrar al menú principal...");
        Console.ReadKey();

        // 2. LLAMADA AL MENÚ (Esto activará el código de tu otro archivo)
        // Nota: Asegúrate de que el método en menu.cs sea "public static void"

    }
}