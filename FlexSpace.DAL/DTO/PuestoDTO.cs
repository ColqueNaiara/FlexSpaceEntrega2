using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexSpace.DAL.DTO
{
    public class PuestoDTO
    {
        public int id { get; set; }
        public string codigo { get; set; }
        public string tipoPuesto { get; set; }
        public decimal tarifaBasePorHora { get; set; }
    }
}
