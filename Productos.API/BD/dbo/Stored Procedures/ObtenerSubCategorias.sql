-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE ObtenerSubCategorias
	-- Add the parameters for the stored procedure here
	@IdCategoria uniqueidentifier
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT Id, IdCategoria, Nombre
	FROM SubCategorias
	WHERE (IdCategoria = @IdCategoria)
END