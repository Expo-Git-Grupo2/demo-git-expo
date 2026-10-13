using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGit
{
    internal class Login
    {
        public bool Validar(string usuario, string clave)
        {
            if (usuario == "admin" && clave == "1234")
            {
                Console.WriteLine("Bienvenido, " + usuario);
                return true;
            }

            Console.WriteLine("Usuario o clave incorrecto");
            return false;
        }
    }

    
}
