namespace IrisPerezAparicio_ASP_A2_10_LogiTrack_SA
{
    class PaqueteEstandar : Envio
    {
        // Tarifa plana fija recomendada: 10.0€
        private double _tarifaPlana;
        public double TarifaPlana
        {
            get => _tarifaPlana;
            set => _tarifaPlana = value < 0 ? 0.0 : value;
        }

        public PaqueteEstandar(string descripcion, double peso, double tarifaPlana = 10.0)
            : base(descripcion, peso)
        {
            TarifaPlana = tarifaPlana;
        }

        // CostoTotal = base + tarifa plana
        public override double CalcularCostoTotal()
        {
            return base.CalcularCostoTotal() + TarifaPlana;
        }

        public override string ToString()
        {
            return $"[Estándar] {base.ToString()}, Tarifa Plana: {TarifaPlana:F2} euros, Costo Total: {CalcularCostoTotal():F2} euros";
        }
    }
}
