namespace ConsoleApp
{
    using SResponsabilidadUnica;
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main()
        {
            Usuario usuario = new Usuario("Juan", "juan@gmal.com");
            UsuarioGuardar guardar = new UsuarioGuardar();
            guardar.GuardarUsuario(usuario);
        }
    }
}