namespace GestionEnvios.Models
{

    public class Shipment
    {
        //propiedades del envío
        public int Id { get; set; }
        public string TrackingNumber { get; set; } = string.Empty;
        public string PaisOrigen { get; set; } = string.Empty;
        public string PaisDestino { get; set; } = string.Empty;
        public string CiudadOrigen { get; set; } = string.Empty;
        public string CiudadDestino { get; set; } = string.Empty;
        public string NombreRemitente { get; set; } = string.Empty;
        public string NombreDestinatario { get; set; } = string.Empty;
        public string DescripcionMercancia { get; set; } = string.Empty;
        public decimal PesoKg { get; set; }
        public string Estado { get; set; } = "Creado";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime FechaEstimadaEntrega { get; set; }

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
}
