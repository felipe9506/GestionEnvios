USE ShipmentsDB;
GO


-- CONSULTA 1: Buscar por estado
SELECT 
    Id,
    TrackingNumber,
    PaisOrigen,
    PaisDestino,
    NombreRemitente,
    NombreDestinatario,
    PesoKg,
    Estado,
    FechaCreacion,
    FechaEstimadaEntrega
FROM Shipments
WHERE Estado = 'En tránsito';
GO

-- CONSULTA 2: Buscar por país de origen o destino

SELECT 
    Id,
    TrackingNumber,
    PaisOrigen,
    PaisDestino,
    NombreRemitente,
    NombreDestinatario,
    Estado
FROM Shipments
WHERE PaisOrigen = 'Colombia'
   OR PaisDestino = 'Colombia';
GO


-- CONSULTA 3: Buscar por rango de fechas

SELECT 
    Id,
    TrackingNumber,
    PaisOrigen,
    PaisDestino,
    Estado,
    FechaCreacion,
    FechaEstimadaEntrega
FROM Shipments
WHERE FechaCreacion >= DATEADD(DAY, -30, GETDATE())
  AND FechaCreacion <= GETDATE()
ORDER BY FechaCreacion DESC;
GO


-- CONSULTA 4: Resumen por estado

SELECT 
    Estado,
    COUNT(*) AS TotalShipments,
    SUM(PesoKg) AS PesoTotalKg
FROM Shipments
GROUP BY Estado
ORDER BY TotalShipments DESC;
GO