namespace GestionEnvios.Models
{
    //clase para representar un envío
    public class shipment
    {
        //propiedades del envío
        public int Id { get; set; }
        public String TrackingNumber { get; set; }
        public String PaisOrigen { get; set; }
        public String PaisDestino { get; set; }
        public String CiudadOrigen { get; set; }
        public String CiudadDestino { get; set; }
        public String DescripcioMercancia { get; set; }
        public decimal Peso { get; set; }
        public String Estado { get; set; } = "Creado";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEstimadaEntrega { get; set; }
    }
}
