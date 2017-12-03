CREATE TABLE [dbo].[Tarefa]
(
	[Id] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [Titulo] VARCHAR(50) NOT NULL, 
    [Finalizada] BIT NOT NULL
)
