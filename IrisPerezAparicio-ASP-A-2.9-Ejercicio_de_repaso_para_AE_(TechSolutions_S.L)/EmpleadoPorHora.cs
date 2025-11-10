namespace IrisPerezAparicio_ASP_A_2_9_TechSolutions_SL
{
    // Requisito técnico de herencia
    class EmpleadoPorHora : Empleado
    {
        // Propiedades no automáticas con encapsulación y validación
        private double _tarifaHora;
        public double TarifaHora
        {
            get => _tarifaHora;
            set => _tarifaHora = value < 0 ? 0.0 : value; // Validación: si negativo, asigna 0.0
        }

        private double _horasTrabajadasMes;
        public double HorasTrabajadasMes
        {
            get => _horasTrabajadasMes;
            set => _horasTrabajadasMes = value < 0 ? 0.0 : value; // Validación: si negativo, asigna 0.0
        }

        // Constructor que inicializa propiedades
        public EmpleadoPorHora(string nombre, double salarioBase, double tarifaHora, double horasTrabajadasMes)
            : base(nombre, salarioBase)
        {
            TarifaHora = tarifaHora;
            HorasTrabajadasMes = horasTrabajadasMes;
        }

        // Implementación polimórfica del cálculo de nómina
        public override double CalcularNomina()
        {
            return SalarioBase + (TarifaHora * HorasTrabajadasMes);
        }

        // Polimorfismo de representación
        public override string ToString()
        {
            return $"Empleado por Hora: {Nombre}, Salario Base: {SalarioBase:F2}, Tarifa por Hora: {TarifaHora:F2}, Horas Trabajadas: {HorasTrabajadasMes:F2}, Nómina Mensual: {CalcularNomina():F2}";
        }
    }
}
