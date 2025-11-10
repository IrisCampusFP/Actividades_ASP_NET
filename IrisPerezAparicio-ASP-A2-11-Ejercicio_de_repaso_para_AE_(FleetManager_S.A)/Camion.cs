namespace IrisPerezAparicio_ASP_A2_11_FleetManager_SA
{
    class Camion : Vehiculo
    {
        private double _peajeAnual;
        public double PeajeAnual
        {
            get => _peajeAnual;
            set => _peajeAnual = value < 0 ? 0.0 : value;
        }

        public Camion(string matricula, double consumo, double peajeAnual)
            : base(matricula, consumo)
        {
            PeajeAnual = peajeAnual;
        }

        // Coste Por KM = coste base + (Peaje Anual / 100000)
        // Se apoya en el método base para el coste de combustible
        public override double CalcularCostoPorKm()
        {
            double costoBaseCombustible = base.CalcularCostoPorKm();
            double costoPeajePorKm = PeajeAnual / 100000.0;
            return costoBaseCombustible + costoPeajePorKm;
        }

        public override string ToString()
        {
            return $"[Camión] {base.ToString()}, Peaje Anual: {PeajeAnual:F2}";
        }
    }
}
