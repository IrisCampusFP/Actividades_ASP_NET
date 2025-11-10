using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace IrisPerezAparicio_ASP_A2_8_Simulacro_de_actividad_evaluable
{
    // Requisito técnico de abstracción
    abstract class Figura
    {
        // Requisito técnico de polimorfismo
        public abstract double CalcularArea();
        // Requisito técnico de polimorfismo
        public abstract double CalcularPerimetro();

        protected double _area;
        protected double _perimetro;
    }

    // Requisito técnico de herencia
    class Circulo : Figura
    {
        // Requisito funcional
        // Propiedad no automática
        private double _radio;
        // Requisito de calidad si valores negativos
        public double Radio { get => _radio; set => _radio = value <= 0 ? 1 : value; }

        // Requisito técnico de propiedades de sólo lectura.
        public double Area { get => Math.PI * Math.Pow(Radio, 2); }
        // Requisito técnico de propiedades de sólo lectura.
        public double Perimetro { get => 2 * Math.PI * Radio; }
        // Requisito técnico de polimorfismo
        public override double CalcularArea()
        {
            _area = Area;
            return _area;
        }

        // Requisito técnico de polimorfismo
        public override double CalcularPerimetro()
        {
            _perimetro = Perimetro;
            return Perimetro;
        }
        // Requisito funcional ver colección
        public override string ToString()
        {
            return $"Circulo de Radio {Radio:F2} con área {Area:F2} y perímetro {Perimetro:F2}";
            // (F2 hace que se muestren solo 2 decimales del double)
        }
    }

    // Requisito técnico de herencia
    class Rectangulo : Figura    {
        // Requisito funcional
        // Propiedad no automática
        private double _base;
        // Requisito de calidad si valores negativos
        public double Base { get => _base; set => _base = value <= 0 ? 1 : value; }

        // Requisito funcional
        // Propiedad no automática
        private double _altura;
        // Requisito de calidad si valores negativos
        public double Altura { get => _altura; set => _altura = value <= 0 ? 1 : value; }

        // Requisito técnico de propiedades de sólo lectura.
        public double Area { get => Base * Altura; }
        // Requisito técnico de propiedades de sólo lectura.
        public double Perimetro { get => 2 * (Base + Altura); }
        // Requisito técnico de polimorfismo
        public override double CalcularArea()
        {
            _area = Area;
            return Area;
        }

        // Requisito técnico de polimorfismo
        public override double CalcularPerimetro()
        {
            _perimetro = Perimetro;
            return Perimetro;
        }
        // Requisito funcional ver colección
        public override string ToString()
        {
            return $"Rectángulo de Base {Base:F2} y Altura {Altura:F2} con área {Area} y perímetro {Perimetro:F2}";
        }

    }

    // Requisito técnico de herencia
    class Rombo : Figura
    {
        // Requisito funcional
        // Propiedad no automática
        private double _diagonalMayor;
        // Requisito de calidad si valores negativos
        public double DiagonalMayor { get => _diagonalMayor; set => _diagonalMayor = value <= 0 ? 1 : value; }
        // Requisito funcional
        // Propiedad no automática
        private double _diagonalMenor;
        // Requisito de calidad si valores negativos
        public double DiagonalMenor { get => _diagonalMenor; set => _diagonalMenor = value <= 0 ? 1 : value; }
        // Requisito técnico de propiedades de sólo lectura.
        public double Area { get => DiagonalMayor * DiagonalMenor / 2; }
        // Requisito técnico de propiedades de sólo lectura.
        public double Perimetro { get => 2 * Math.Sqrt(Math.Pow(DiagonalMayor, 2) * Math.Pow(DiagonalMenor, 2)); }

        public override double CalcularArea()
        {
            _area = Area;
            return Area;
        }

        // Requisito técnico de polimorfismo
        public override double CalcularPerimetro()
        {
            _perimetro = Perimetro;
            return Perimetro;
        }

        // Requisito funcional ver colección
        public override string ToString()
        {
            return $"Rombo de Diagonal Mayor {DiagonalMayor:F2} y Diagonal Menor {DiagonalMenor:F2} con área {Area:F2} y perímetro {Perimetro:F2}";
        }
    }

    class Programa
    {
        static List<Figura> figuras = new List<Figura>();
        static int LeerOpcion()
        {
            int opcion = 0;
            Console.Write("Seleccione una opción: ");
            bool valido = int.TryParse(Console.ReadLine(), out opcion);

            while (!valido)
            {
                Console.Write("Por favor, introduce un número entero: ");
                valido = int.TryParse(Console.ReadLine(), out opcion);
            }
            return opcion;
        }
        static double LeerDouble()
        {
            double num = 0;
            bool valido = double.TryParse(Console.ReadLine(), out num);

            while (!valido)
            {
                Console.WriteLine("Por favor, introduce un número: ");
                valido = double.TryParse(Console.ReadLine(), out num);
            }
            return num;
        }

        //  Requisito funcional      
        static void CrearFigura()
        {
            Console.WriteLine("\nElija una figura:\n1- Circulo\n2- Rectangulo\n3- Rombo\n4- Volver al menu");
            int opcion = LeerOpcion();

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("\nCIRCULO");
                    Console.Write("Radio: ");
                    double radio = LeerDouble();

                    Circulo circulo = new Circulo();
                    circulo.Radio = radio;
                    figuras.Add(circulo);
                    
                    Console.WriteLine("Círculo creado correctamente.\n(" + circulo.ToString() + ")");
                    break;
                case 2:
                    Console.WriteLine("\nRECTANGULO");
                    Console.Write("Base: ");
                    double baseRect = LeerDouble();
                    Console.Write("Altura: ");
                    double alturaRect = LeerDouble();

                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.Base = baseRect;
                    rectangulo.Altura = alturaRect;
                    figuras.Add(rectangulo);

                    Console.WriteLine("Rectángulo creado correctamente.\n(" + rectangulo.ToString() + ")");
                    break;
                case 3:
                    Console.WriteLine("\nROMBO");
                    Console.Write("Diagonal Mayor: ");
                    double diagonalMayor = LeerDouble();
                    Console.Write("Diagonal Menor: ");
                    double diagonalMenor = LeerDouble();
                    
                    Rombo rombo = new Rombo();
                    rombo.DiagonalMayor = diagonalMayor;
                    rombo.DiagonalMenor = diagonalMenor;
                    figuras.Add(rombo);

                    Console.WriteLine("Rombo creado correctamente.\n(" + rombo.ToString() + ")");
                    break;
                case 4:
                    Console.WriteLine("Volviendo al menú...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Volviendo al menú...");
                    break;
            }
        }
        //  Requisito funcional      
        static void VerColeccion()
        {
            Console.WriteLine("´\nCOLECCION DE FIGURAS:");
            figuras.ForEach(figura => Console.WriteLine(figura));
        }
        //  Requisito funcional      
        static void CalcularAreaTotal()
        {
            Console.WriteLine($"\nArea total = {figuras.Sum(figura => figura.CalcularArea()):F2}");
        }
        //  Requisito funcional      
        static void CalcularPerimetroTotal()
        {
            Console.WriteLine($"\nPerimetro total = {figuras.Sum(figura => figura.CalcularPerimetro()):F2}");
        }

        public static void Main()
        {
            while (true)
            {
                //  Requisito funcional
                Console.WriteLine("\n··· MENU ···");
                Console.WriteLine("1.- Crear Figura");
                Console.WriteLine("2.- Ver colección");
                Console.WriteLine("3.- Calcular Área Total");
                Console.WriteLine("4.- Calcular Perímetro Total");
                Console.WriteLine("5.- Terminar");
                
                int opcion = LeerOpcion();

                switch (opcion)
                {
                    case 1: CrearFigura(); break;
                    case 2: VerColeccion(); break;
                    case 3: CalcularAreaTotal(); break;
                    case 4: CalcularPerimetroTotal(); break;
                    case 5: Console.WriteLine("Cerrando programa..."); return;
                    default: Console.WriteLine("Opción no válida (introduce un número del 1 al 5)"); break;
                }
            }

        }

    }
}
