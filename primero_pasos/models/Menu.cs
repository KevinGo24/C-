using primero_pasos.Models;

bool exitoso =  true;
while (!exitoso)
{
    Console.Clear();
    Console.WriteLine("--------------------------");
    Console.WriteLine("----- Bienvenido Querido pacinete -----");
    Console.WriteLine("---------------------------");
    Console.WriteLine("---- Elija una opcion para seguir con el programa -----");
    Console.WriteLine("1. Registrar cita");
    Console.WriteLine("2. Consultar historial");
    Console.WriteLine("3. Salir");
    Console.Write("Selección: ");
    String Opcion = Console.ReadLine();
    switch (Opcion)
    {
        case "1":
            Console.WriteLine("\n[Abriendo registro de cita...] Presione una tecla para continuar.");
            Console.ReadKey();
            break;
        case "2":
            Console.WriteLine("\n[consultar historial de cita...] Presione una tecla para continuar.");
            Console.ReadKey();
            break;
        case "3":
            Console.WriteLine("\nGracias por usar el sistema. ¡Hasta luego!");
            // Forzar el cierre inmediato de la consola de comandos
            Environment.Exit(0); 
            break;
        default:
            Console.WriteLine("\nOpción no válida. Intente de nuevo.");
            Console.ReadKey();
            break;
    }
}