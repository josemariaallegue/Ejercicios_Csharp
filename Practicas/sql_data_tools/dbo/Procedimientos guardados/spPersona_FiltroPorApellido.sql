CREATE PROCEDURE [dbo].[spPersona_FiltroPorApellido]
	@apellido nvarchar(20)
AS
	
begin
	SELECT p.[Id], p.[Nombre], p.[Apellido]
	from dbo.Persona as p
	where p.Apellido = @apellido
end
