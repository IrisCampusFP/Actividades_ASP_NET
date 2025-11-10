namespace IrisPerezAparicio_ASP_A2_10_LogiTrack_SA
{
    class Program
    {
        static List<Envio> envios = new List<Envio>();

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

        static void CrearEnvio()
        {
            Console.WriteLine("\nTIPO DE ENVÍO:");
            Console.WriteLine("1. Paquete Estándar");
            Console.WriteLine("2. Paquete Express");
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

            Console.Write("\nDescripción: ");
            string descripcion = Console.ReadLine();
            Console.Write("Peso (kg): ");
            double peso = LeerDouble();

            switch (opcion)
            {
                case 1:
                    // Tarifa plana fija 10€, pero se mantiene validación por coherencia general
                    envios.Add(new PaqueteEstandar(descripcion, peso, 10.0));
                    Console.WriteLine("Paquete Estándar creado correctamente.\n");
                    break;

                case 2:
                    Console.Write("Recargo Urgencia (euros/kg): ");
                    double recargo = LeerDouble();
                    envios.Add(new PaqueteExpress(descripcion, peso, recargo));
                    Console.WriteLine("Paquete Express creado correctamente.\n");
                    break;
            }
        }

        static void VerCostosIndividuales()
        {
            Console.WriteLine("\nCOSTOS INDIVIDUALES:");
            if (envios.Count == 0)
            {
                Console.WriteLine("No hay envíos registrados.");
                return;
            }

            foreach (var envio in envios)
                Console.WriteLine(envio.ToString());
        }

        static void CalcularIngresoTotal()
        {
            double total = envios.Sum(e => e.CalcularCostoTotal());
            Console.WriteLine($"\nIngreso Total por Envíos: {total:F2} euros");
        }

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n··· MENÚ ···");
                Console.WriteLine("1. Crear Envío");
                Console.WriteLine("2. Ver Costos Individuales");
                Console.WriteLine("3. Calcular Ingreso Total");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = LeerEntero();

                switch (opcion)
                {
                    case 1: CrearEnvio(); break;
                    case 2: VerCostosIndividuales(); break;
                    case 3: CalcularIngresoTotal(); break;
                    case 4: return;
                    default: Console.WriteLine("Opción no válida (1-4)."); break;
                }
            }
        }
    }
}
