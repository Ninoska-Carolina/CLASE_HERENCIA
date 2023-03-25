using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES_HERENCIA
{
    internal class Usuario
    {
        public string Cuenta { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public bool login(string username, string password)
        {
            if (username == this.Cuenta && password == Password)
            {
                Console.WriteLine("BIENVENIDOS A SISTEMAS");
                return true;
            }
            else
            {
                Console.WriteLine("EEROR");
                return false;
            }
        }
        public void login()
        {
            Console.WriteLine("LOGIN CON POLIMORFISMO");

        }



    }
}
