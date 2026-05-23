namespace GestionEnvios.Models
{
    //clase para representar un envío
    public class Shipment
    {
        //propiedades del envío
        public int Id { get; set; }
        public string TrackingNumber { get; set; }
        public string PaisOrigen { get; set; }
        public string PaisDestino { get; set; }
        public string CiudadOrigen { get; set; }
        public string CiudadDestino { get; set; }
        public string NombreRemitente { get; set; } = string.Empty;
        public string NombreDestinatario { get; set; } = string.Empty;
        public string DescripcionMercancia { get; set; }
        public decimal PesoKg { get; set; }
        public string Estado { get; set; } = "Creado";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEstimadaEntrega { get; set; }
    }
}
