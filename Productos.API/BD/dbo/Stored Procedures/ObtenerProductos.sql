-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ObtenerProductos
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT Producto.IdSubCategoria, Producto.Id, Producto.Nombre, Producto.Descripcion, Producto.Precio, Producto.Stock, Producto.CodigoBarras, SubCategorias.Nombre AS SubCategoria, Categorias.Nombre AS Categoria
FROM     Producto INNER JOIN
                  SubCategorias ON Producto.IdSubCategoria = SubCategorias.Id INNER JOIN
                  Categorias ON SubCategorias.IdCategoria = Categorias.Id
END