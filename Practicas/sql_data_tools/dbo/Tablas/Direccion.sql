CREATE TABLE [dbo].[Direccion]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonaId] INT NULL, 
    [DireccionCalle] NVARCHAR(50) NULL, 
    [Ciudad] NVARCHAR(50) NULL, 
    [Provincia] NVARCHAR(50) NULL, 
    [CodigoPostal] INT NULL, 
    CONSTRAINT [FK_Direccion_Persona] FOREIGN KEY ([PersonaId]) REFERENCES Persona(Id)
)
