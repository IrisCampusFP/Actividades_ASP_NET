using System;





/* NO SE HACERLO */






class Alarma
{
    // Declaro un delegado para el evento
    public delegate void AlarmaActivadaEventHandler(object sender, EventArgs e);

    // Declaro un evento
    public event AlarmaActivadaEventHandler AlarmaActivada;

    // Método para activar la alarma
    public void Activar()
    {
        Console.WriteLine("Alarma activada.");
        // Disparar el evento si hay suscriptores
        if (AlarmaActivada != null)
        {
            AlarmaActivada(this, EventArgs.Empty);
        }
    }
}

// Clase que se suscribe al evento
class Monitor
{
    public void Suscribirse(Alarma alarma)
    {
        alarma.AlarmaActivada += MostrarMensaje;
    }

    // Método que maneja el evento
    private void MostrarMensaje(object sender, EventArgs e)
    {
        Console.WriteLine("¡Atención! La alarma ha sido activada.");
    }
}

// Programa principal
class Program
{
    static void Main()
    {
        Alarma alarma = new Alarma();
        Monitor monitor = new Monitor();

        // Suscribir el monitor al evento de la alarma
        monitor.Suscribirse(alarma);

        // Activar la alarma
        alarma.Activar();
    }
}