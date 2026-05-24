USE ShipmentsDB;
GO

-- usuario de prueba para el login
INSERT INTO Usuarios (Username, PasswordHash)
VALUES ('admin', 'Admin123');
GO

-- datos de ejemplo
INSERT INTO Shipments 
    (TrackingNumber, PaisOrigen, PaisDestino, CiudadOrigen, CiudadDestino,
     NombreRemitente, NombreDestinatario, DescripcionMercancia, PesoKg, 
     Estado, FechaCreacion, FechaEstimadaEntrega)
VALUES
    -- Estado: Creado
    ('COD-001', 'Colombia', 'México', 'Bogotá', 'Ciudad de México',
     'Felipe Herrera', 'Maira López', 'Ropa y accesorios', 5.50,
     'Creado', GETDATE(), DATEADD(DAY, 10, GETDATE())),

    -- Estado: En tránsito
    ('COD-002', 'Colombia', 'España', 'Medellín', 'Madrid',
     'Allison Gómez', 'Pedro Fernandez', 'Libros y papelería', 3.20,
     'En tránsito', GETDATE(), DATEADD(DAY, 15, GETDATE())),

    -- Estado: Entregado
    ('COD-003', 'Colombia', 'Argentina', 'Cali', 'Buenos Aires',
     'Luis Torres', 'Sofia Díaz', 'Electrónicos', 8.00,
     'Entregado', DATEADD(DAY, -20, GETDATE()), DATEADD(DAY, -5, GETDATE())),

    -- Estado: Cancelado
    ('COD-004', 'Colombia', 'Chile', 'Bogotá', 'Santiago',
     'Juliana Castro', 'Diego Morales', 'Documentos', 0.80,
     'Cancelado', DATEADD(DAY, -10, GETDATE()), DATEADD(DAY, -2, GETDATE()));
GO