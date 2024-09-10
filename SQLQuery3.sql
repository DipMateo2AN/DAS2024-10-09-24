CREATE PROCEDURE sp_AgregarProveedor
    @Cuit INT,
    @RazonSocial NVARCHAR(255),
    @Telefono INT,
    @Direccion NVARCHAR(255)
AS
BEGIN
    INSERT INTO Proveedores (Cuit, RazonSocial, Telefono, Direccion)
    VALUES (@Cuit, @RazonSocial, @Telefono, @Direccion);
END;
