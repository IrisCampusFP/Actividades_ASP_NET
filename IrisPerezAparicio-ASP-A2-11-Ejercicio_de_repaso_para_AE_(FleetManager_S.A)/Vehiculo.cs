namespace IrisPerezAparicio_ASP_A2_11_FleetManager_SA
{
    // Clase base reutilizable con lógica común
    class Vehiculo
    {
        // Propiedad automática
        public string Matricula { get; set; }

        // Propiedad no automática con validación
        private double _consumo; // litros por 100 km
        public double Consumo
        {
            get => _consumo;
            set => _consumo = value < 0 ? 0.0 : value;
        }

        // Costo operacional base por litro (solo lectura)
        protected const double COSTO_OPERACIONAL_BASE = 0.15;

        // Constructor base
        public Vehiculo(string matricula, double consumo)
        {
            Matricula = matricula;
            Consumo = consumo;
        }

        // Método polimórfico: costo por km base
        // Puede ser reutilizado por las clases derivadas
        public virtual double CalcularCostoPorKm()
        {
            // Según enunciado: Coste base = Consumo x Costo Operacional Base
            return Consumo * COSTO_OPERACIONAL_BASE;
        }

        // ToString polimórfico (solo datos comunes)
        public override string ToString()
        {
            return $"Matrícula: {Matricula}, Consumo: {Consumo:F2} L/100km";
        }
    }
}
