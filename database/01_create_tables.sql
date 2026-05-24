-- Crear la base de datos
CREATE DATABASE ShipmentsDB;
GO

USE ShipmentsDB;
GO

-- Tabla de usuarios para el login
CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL
);
GO

-- Tabla principal de shipments
CREATE TABLE Shipments (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TrackingNumber NVARCHAR(50) NOT NULL UNIQUE,
    PaisOrigen NVARCHAR(100) NOT NULL,
    PaisDestino NVARCHAR(100) NOT NULL,
    CiudadOrigen NVARCHAR(100) NOT NULL,
    CiudadDestino NVARCHAR(100) NOT NULL,
    NombreRemitente NVARCHAR(150) NOT NULL,
    NombreDestinatario NVARCHAR(150) NOT NULL,
    DescripcionMercancia NVARCHAR(500) NOT NULL,
    PesoKg DECIMAL(10,2) NOT NULL,
    Estado NVARCHAR(50) NOT NULL DEFAULT 'Creado',
    FechaCreacion DATETIME NOT NULL DEFAULT GETDATE(),
    FechaEstimadaEntrega DATETIME NOT NULL
);
GO