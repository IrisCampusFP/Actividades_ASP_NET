using System;
using System.Collections.Generic;
using System.Linq;

namespace IrisPerezAparicio_ASP_A_2_9_TechSolutions_SL
{
    class Program
    {
        // Colección polimórfica
        static List<Empleado> empleados = new List<Empleado>();

        // Métodos auxiliares para validación de entrada
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

        static void ContratarEmpleado()
        {
            Console.WriteLine("\nTIPO DE EMPLEADO:");
            Console.WriteLine("1. Empleado Base");
            Console.WriteLine("2. Empleado Fijo");
            Console.WriteLine("3. Empleado por Hora");
            Console.WriteLine("4. Volver al menú");
            Console.Write("Seleccione una opción: ");
            int opcion = LeerEntero();

            if (opcion < 1 || opcion > 4)
            {
                Console.WriteLine("Opción no válida. Volviendo al menú...");
                return;
            }

            if (opcion == 4)
            {
                Console.WriteLine("Volviendo al menú...");
                return;
            }

            Console.Write("\nNombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Salario Base: ");
            double salarioBase = LeerDouble();

            switch (opcion)
            {
                case 1:
                    empleados.Add(new EmpleadoBase(nombre, salarioBase));
                    Console.WriteLine("Empleado Base contratado correctamente.\n");
                    break;

                case 2:
                    Console.Write("Bono Anual: ");
                    double bono = LeerDouble();
                    empleados.Add(new EmpleadoFijo(nombre, salarioBase, bono));
                    Console.WriteLine("Empleado Fijo contratado correctamente.\n");
                    break;

                case 3:
                    Console.Write("Tarifa por Hora: ");
                    double tarifa = LeerDouble();
                    Console.Write("Horas Trabajadas: ");
                    double horas = LeerDouble();
                    empleados.Add(new EmpleadoPorHora(nombre, salarioBase, tarifa, horas));
                    Console.WriteLine("Empleado por Hora contratado correctamente.\n");
                    break;
            }
        }

        static void VerNominasIndividuales()
        {
            Console.WriteLine("\nNÓMINAS INDIVIDUALES:");
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            foreach (var empleado in empleados)
                Console.WriteLine(empleado.ToString());
        }

        static void CalcularCosteTotalNominas()
        {
            double total = empleados.Sum(e => e.CalcularNomina());
            Console.WriteLine($"\nCoste Total de Nóminas: {total:F2}");
        }

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n··· MENÚ ···");
                Console.WriteLine("1. Contratar Empleado");
                Console.WriteLine("2. Ver Nóminas Individuales");
                Console.WriteLine("3. Calcular Coste Total de Nóminas");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = LeerEntero();

                switch (opcion)
                {
                    case 1: ContratarEmpleado(); break;
                    case 2: VerNominasIndividuales(); break;
                    case 3: CalcularCosteTotalNominas(); break;
                    case 4: Console.WriteLine("Cerrando aplicación..."); return;
                    default: Console.WriteLine("Opción no válida (1-4)."); break;
                }
            }
        }
    }
}
