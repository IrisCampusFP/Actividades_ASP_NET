namespace IrisPerezAparicio_ASP_A2_10_LogiTrack_SA
{
    class Envio
    {
        // Propiedad automática
        public string Descripcion { get; set; }

        // Propiedad no automática con validación
        private double _peso;
        public double Peso
        {
            get => _peso;
            set => _peso = value < 0 ? 0.0 : value;
        }

        // Constante de coste base
        protected const double COSTO_POR_KG = 2.0;

        // Solo lectura
        public double CostoBase => Peso * COSTO_POR_KG;

        // Constructor base
        public Envio(string descripcion, double peso)
        {
            Descripcion = descripcion;
            Peso = peso;
        }

        // Método polimórfico base reutilizable
        public virtual double CalcularCostoTotal()
        {
            return CostoBase;
        }

        // ToString polimórfico
        public override string ToString()
        {
            return $"Descripción: {Descripcion}, Peso: {Peso:F2} kg, Costo Base: {CostoBase:F2} euros";
        }
    }
}
