namespace IrisPerezAparicio_ASP_A2_11_FleetManager_SA
{
    class Program
    {
        // Colección polimórfica de vehículos
        static List<Vehiculo> flota = new List<Vehiculo>();

        static int LeerEntero()
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num))
                Console.Write("Introduce un número entero válido: ");
            return num;
        }

        static double LeerDouble()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.Write("Introduce un número válido: ");
            return num;
        }

        static void RegistrarVehiculo()
        {
            Console.WriteLine("\nTIPO DE VEHÍCULO:");
            Console.WriteLine("1. Autobús");
            Console.WriteLine("2. Camión");
            Console.WriteLine("3. Volver al menú");
            Console.Write("Seleccione una opción: ");
            int opcion = LeerEntero();

            if (opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción no válida. Volviendo al menú...");
                return;
            }

            if (opcion == 3)
            {
                Console.WriteLine("Volviendo al menú...");
                return;
            }

            Console.Write("\nMatrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Consumo (L/100km): ");
            double consumo = LeerDouble();

            switch (opcion)
            {
                case 1:
                    Console.Write("Capacidad Máxima (número de pasajeros): ");
                    double capacidad = LeerDouble();
                    flota.Add(new Autobus(matricula, consumo, capacidad));
                    Console.WriteLine("Autobús registrado correctamente.\n");
                    break;

                case 2:
                    Console.Write("Peaje Anual (€): ");
                    double peajeAnual = LeerDouble();
                    flota.Add(new Camion(matricula, consumo, peajeAnual));
                    Console.WriteLine("Camión registrado correctamente.\n");
                    break;
            }
        }

        static void VerCostosOperacionales()
        {
            Console.WriteLine("\nCOSTOS OPERACIONALES POR VEHÍCULO:");
            if (flota.Count == 0)
            {
                Console.WriteLine("No hay vehículos registrados.");
                return;
            }

            foreach (var vehiculo in flota)
            {
                double costoPorKm = vehiculo.CalcularCostoPorKm();
                Console.WriteLine($"{vehiculo} | Costo por Km: {costoPorKm:F4} €");
            }
        }

        static void CalcularCostoTotalFlota()
        {
            if (flota.Count == 0)
            {
                Console.WriteLine("\nNo hay vehículos registrados.");
                return;
            }

            const double KM_FIJOS = 100000.0;
            double total = flota.Sum(v => v.CalcularCostoPorKm() * KM_FIJOS);

            Console.WriteLine($"\nCosto Total de la Flota para {KM_FIJOS:F0} km por vehículo: {total:F2} €");
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n··· MENÚ ···");
                Console.WriteLine("1. Registrar Vehículo");
                Console.WriteLine("2. Ver Costos Operacionales");
                Console.WriteLine("3. Calcular Costo Total de Flota (100,000 km por vehículo)");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = LeerEntero();

                switch (opcion)
                {
                    case 1:
                        RegistrarVehiculo();
                        break;
                    case 2:
                        VerCostosOperacionales();
                        break;
                    case 3:
                        CalcularCostoTotalFlota();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida (1-4).");
                        break;
                }
            }
        }
    }
}
