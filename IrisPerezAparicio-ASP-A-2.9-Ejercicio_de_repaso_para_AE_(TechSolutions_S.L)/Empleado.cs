namespace IrisPerezAparicio_ASP_A_2_9_TechSolutions_SL
{
    abstract class Empleado
    {
        public string Nombre { get; set; }

        private double _salarioBase;
        public double SalarioBase
        {
            get => _salarioBase;
            set => _salarioBase = value < 0 ? 0.0 : value;
        }

        protected Empleado(string nombre, double salarioBase)
        {
            Nombre = nombre;
            SalarioBase = salarioBase;
        }

        public abstract double CalcularNomina();

        public override string ToString()
        {
            return $"Empleado: {Nombre}, Salario Base: {SalarioBase:F2}";
        }
    }
}
