# GestionEnvios

Sistema web para registrar y gestionar envíos internacionales de mercancía.

## Tecnologías utilizadas
- ASP.NET Core MVC 
- SQL Server 2025
- Entity Framework Core
- Bootstrap 5

## Arquitectura
El proyecto sigue el patrón MVC:
- **Models/** → Entidades y DbContext
- **Controllers/** → Lógica de negocio
- **Views/** → Pantallas del usuario

## Modelo de datos
- **Shipment** → envío con origen, destino, remitente, destinatario, peso y estado
- **Usuario** → usuario para autenticación

## Pasos para ejecutar

### 1. Base de datos
Ejecutar los scripts en orden en SQL Server Management Studio:
1. `database/01_create_tables.sql`
2. `database/02_initial_data.sql`
3. `database/03_consultas.sql`

### 2. Configurar conexión
En `appsettings.json` verificar la cadena de conexión:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=ShipmentsDB;
  Trusted_Connection=True;TrustServerCertificate=True"
}
```

### 3. Ejecutar el backend
Abrir la solución en Visual Studio y presionar F5.

## Usuario de prueba# GestionEnvios
Usuario:    admin
Contraseña: Admin123

## Estados del envío
- **Creado** → envío recién registrado
- **En tránsito** → en camino al destino
- **Entregado** → llegó al destino (no editable)
- **Cancelado** → anulado (no editable)

## Decisiones técnicas
- Se usó MVC en lugar de Angular para simplificar el proyecto
- Autenticación por sesión simple sin Identity
- Entity Framework Core para evitar SQL manual en el código

## Uso de IA
Se utilizó Copilot como apoyo para:

- Ayuda con errores de compilación
- Ayuda con sintaxis de C# 
- ayudapara mejorar el aspecto visual de las vistas con Bootstrap
- Todas las decisiones de arquitectura y lógica fueron revisadas 
  y entendidas por el candidato