namespace IrisPerezAparicio_ASP_A_2_9_TechSolutions_SL
{
    // Requisito técnico de herencia
    class EmpleadoFijo : Empleado
    {
        // Propiedad no automática con encapsulación y validación
        private double _bonoAnual;
        public double BonoAnual
        {
            get => _bonoAnual;
            set => _bonoAnual = value < 0 ? 0.0 : value; // Validación: si negativo, asigna 0.0
        }

        // Constructor que inicializa propiedades
        public EmpleadoFijo(string nombre, double salarioBase, double bonoAnual)
            : base(nombre, salarioBase)
        {
            BonoAnual = bonoAnual;
        }

        // Implementación polimórfica del cálculo de nómina
        public override double CalcularNomina()
        {
            return SalarioBase + (BonoAnual / 12);
        }

        // Polimorfismo de representación
        public override string ToString()
        {
            return $"Empleado Fijo: {Nombre}, Salario Base: {SalarioBase:F2}, Bono Anual: {BonoAnual:F2}, Nómina Mensual: {CalcularNomina():F2}";
        }
    }
}
