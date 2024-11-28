using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador2024.Entidades
{
    public class ClienteIndividuo
    {
        public ClienteIndividuo(string pNombre, string pApellido, string pCUIT, string pEmail, string pTelefono, string pDireccion)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.CUIT = pCUIT;
            this.Email = pEmail;
            this.Telefono = pTelefono;
            this.Direccion = pDireccion;
        }

        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}
