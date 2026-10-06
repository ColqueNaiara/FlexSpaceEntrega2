using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexSpace.DAL.DTO
{
    public class ClienteDTO
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public string tipoCliente { get; set; }
        public int sancionesActivas { get; set; }
    }
}
