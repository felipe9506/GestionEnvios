namespace GestionEnvios.Models
{
    //clase para representar un envío
<<<<<<< HEAD
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
=======
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
>>>>>>> 52c012a4f7a60ed63a4c1e2f4a27768957515cc4
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEstimadaEntrega { get; set; }
    }
}
