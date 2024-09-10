CREATE PROCEDURE sp_RecuperarProductos
AS
BEGIN
    SELECT 
        p.Codigo,
        p.Descripcion, 
        p.PrecioCompra,
        p.PrecioVenta,
        p.CantidadActual, 
        p.CantidadMinima,
        c.Codigo AS CodigoCategoria,
        p.CuitProveedor, -- Columna de Productos
        pr.Cuit -- Información adicional del proveedor
    FROM Productos p
    INNER JOIN Categorias c ON c.Id = p.CategoriaId
    LEFT JOIN Proveedores pr ON pr.Cuit = p.CuitProveedor; -- JOIN con Proveedores
END;
GO