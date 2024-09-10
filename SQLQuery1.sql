CREATE TABLE Proveedores (
    Cuit INT PRIMARY KEY, -- Identificador único para cada proveedor
    RazonSocial NVARCHAR(255) NOT NULL, -- Nombre o razón social del proveedor
    Telefono INT NOT NULL, -- Número de teléfono del proveedor
    Direccion NVARCHAR(255) NOT NULL -- Dirección del proveedor
);