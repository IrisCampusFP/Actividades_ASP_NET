namespace IrisPerezAparicio_ASP_A2_11_FleetManager_SA

{
    class Autobus : Vehiculo
    {
        private double _capacidadMaxima;
        public double CapacidadMaxima
        {
            get => _capacidadMaxima;
            set => _capacidadMaxima = value < 0 ? 0.0 : value;
        }

        // Factor de desgaste (solo lectura)
        private const double FACTOR_DESGASTE = 1.2;

        public Autobus(string matricula, double consumo, double capacidadMaxima)
            : base(matricula, consumo)
        {
            CapacidadMaxima = capacidadMaxima;
        }

        // Coste Por KM = (coste base) x Factor de Desgaste
        // Reutiliza el método polimórfico de la clase base
        public override double CalcularCostoPorKm()
        {
            return base.CalcularCostoPorKm() * FACTOR_DESGASTE;
        }

        public override string ToString()
        {
            return $"[Autobús] {base.ToString()}, Capacidad Máxima: {CapacidadMaxima:F0} pasajeros";
        }
    }
}
