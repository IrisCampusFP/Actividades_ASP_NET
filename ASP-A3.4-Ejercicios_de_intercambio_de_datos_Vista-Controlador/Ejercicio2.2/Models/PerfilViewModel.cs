namespace Ejercicio2._2.Models
{
    public class PerfilViewModel
    {
        // Propiedades
        public string Nombre { get; set; }
        public string Email { get; set; }
        public bool EsAdmin { get; set; }

        // Constructor vacío
        public PerfilViewModel()
        {
        }

        // Constructor con propiedades
        public PerfilViewModel(string nombre, string email, bool esAdmin)
        {
            Nombre = nombre;
            Email = email;
            EsAdmin = esAdmin;
        }
    }
}
