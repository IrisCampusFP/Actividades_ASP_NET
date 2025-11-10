using IrisPerezAparicio_ASP_A_2_9_TechSolutions_SL;
using static System.Runtime.InteropServices.JavaScript.JSType;

class EmpleadoBase : Empleado
{
    public EmpleadoBase(string nombre, double salarioBase)
        : base(nombre, salarioBase) { }

    public override double CalcularNomina()
    {
        return SalarioBase;
    }

    public override string ToString()
    {
        return $"Empleado Base: {Nombre}, Salario Base: {SalarioBase:F2}, Nómina: {CalcularNomina():F2}";
    }
}
