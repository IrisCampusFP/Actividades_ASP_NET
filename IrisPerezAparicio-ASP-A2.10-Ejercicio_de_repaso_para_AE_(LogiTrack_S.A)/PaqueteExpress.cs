namespace IrisPerezAparicio_ASP_A2_10_LogiTrack_SA
{
    class PaqueteExpress : Envio
    {
        // Recargo de urgencia con validación (lo tratamos como importe €/kg o factor según enunciado)
        private double _recargoUrgencia;
        public double RecargoUrgencia
        {
            get => _recargoUrgencia;
            set => _recargoUrgencia = value < 0 ? 0.0 : value;
        }

        public PaqueteExpress(string descripcion, double peso, double recargoUrgencia)
            : base(descripcion, peso)
        {
            RecargoUrgencia = recargoUrgencia;
        }

        // CostoTotal = base + RecargoUrgencia x Peso
        public override double CalcularCostoTotal()
        {
            return base.CalcularCostoTotal() + (RecargoUrgencia * Peso);
        }

        public override string ToString()
        {
            return $"[Express] {base.ToString()}, Recargo Urgencia: {RecargoUrgencia:F2} euros/kg, Costo Total: {CalcularCostoTotal():F2} euros";
        }
    }
}
