USE PetStore
GO

CREATE PROC dbo.usp_CreateInitialColorsTable
AS

IF  NOT EXISTS (SELECT * FROM sys.objects 
WHERE object_id = OBJECT_ID(N'[dbo].[Colors]') AND type in (N'U'))
	BEGIN
		CREATE TABLE [dbo].[Colors]
		(
			ColorId int IDENTITY(1,1) NOT NULL,
			ColorType nvarchar(20) NOT NULL
		)

		ALTER TABLE [dbo].[Colors] 
		ADD  CONSTRAINT [PK_Colors] 
		PRIMARY KEY CLUSTERED (ColorId ASC)

		ALTER TABLE [dbo].[Pets] 
		ADD	CONSTRAINT FK_Pets_Colors
		FOREIGN    KEY (ColorId)
		REFERENCES Colors(ColorId)
	END
GO

EXEC dbo.usp_CreateInitialColorsTable
GO

CREATE PROC dbo.usp_FillInitialColorsTable
AS
	INSERT INTO dbo.Colors (ColorType) VALUES
	('black'),
	('white'),
	('red'),
	('mixed')
GO

EXEC dbo.usp_FillInitialColorsTable
GO