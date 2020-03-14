
-- =============================================
-- Author:		<Jose Maria Allegue>
-- Create date: <11/03/2020>
-- Description:	<Selecciona todo de dbo.personasTabla>
-- =============================================
CREATE PROCEDURE dbo.[spPersonasTabla_seleccionarTodo]

AS
BEGIN

	SET NOCOUNT ON;

	select * 
	from dbo.personasTabla

END
