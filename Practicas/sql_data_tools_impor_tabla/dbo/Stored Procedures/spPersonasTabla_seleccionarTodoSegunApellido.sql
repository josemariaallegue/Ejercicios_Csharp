
-- =============================================
-- Author:		<Jose Maria Allegue>
-- Create date: <11/03/2020>
-- Description:	<Selecciona todo de dbo.personasTabla segun un apellido>
-- =============================================
CREATE PROCEDURE dbo.spPersonasTabla_seleccionarTodoSegunApellido
	
	@apellido nvarchar(20)

AS
BEGIN

	SET NOCOUNT ON;

	select *
	from dbo.personasTabla
	where dbo.personasTabla.Apellido = @apellido

END
