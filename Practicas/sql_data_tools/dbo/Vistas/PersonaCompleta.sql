CREATE VIEW [dbo].[PersonaCompleta]
	as
	select [p].[Nombre], [p].[Apellido]
		, [a].[PersonaId], [a].[DireccionCalle], [a].[Ciudad], [a].[Provincia], [a].[CodigoPostal]
	from dbo.Persona as p
	left join dbo.Direccion as a on p.Id = a.PersonaId
