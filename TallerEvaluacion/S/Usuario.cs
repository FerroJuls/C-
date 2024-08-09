using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SResponsabilidadUnica
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Usuario(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
    }

    public class UsuarioGuardar
    {
        public void GuardarUsuario(Usuario usuario)
        {
            Console.WriteLine($"el usuario {usuario.Nombre} con correo {usuario.Email} se a guardado con exito.");
        }
    }
}
