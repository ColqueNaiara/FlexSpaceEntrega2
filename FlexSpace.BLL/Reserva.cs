namespace FlexSpace.BLL
{
    public class Reserva
    {
        public int id {  get; set; }
        public int clienteId {  get; set; }
        public int puestoId {  get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaFin { get; set; }
        public string estado { get; set; }
        public decimal costoTotal { get; set; }
    }
}
