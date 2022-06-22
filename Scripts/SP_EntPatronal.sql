SELECT * FROM EntPatronal

GO
CREATE PROC addEntPatronal(
@Nome			   VARCHAR(100) = NULL,
@Endereco		   VARCHAR(100) = NULL,
@Num_Telefone	   CHAR(9) = NULL,
@IBAN			   CHAR(25) = NULL,
@NIF			   CHAR(9) = NULL,
@Tipo_EntPatronal  INT = 0,
@Status			   INT OUTPUT
) AS

DECLARE @Num_Registo AS INT;

SET @Num_Registo = (SELECT TOP 1 Num_Registo FROM EntPatronal ORDER BY Num_Registo DESC) + 1;

IF @Nome IS NULL
BEGIN
	SET @Status = -1
	PRINT 'ERRO: É necessário Nome'
	SELECT @Status
	RETURN @Status
END

INSERT INTO EntPatronal VALUES (@Num_Registo, @Nome, @Endereco, @Num_Telefone, @IBAN, @NIF, @Tipo_EntPatronal)
SELECT @Status
RETURN @Status
GO

-- Procurar Entidade Patronal
GO
CREATE PROC searchEntPatronal @Nome AS VARCHAR(100) AS
SELECT * FROM EntPatronal WHERE Nome LIKE '%' + @Nome + '%'
GO

SELECT count(cc) FROM Estudo JOIN (SELECT Num_Registo, CC FROM EntPatronal JOIN Investigador ON Num_Registo = EntPatronal) AS Something ON CC_Inv = CC WHERE Num_Registo = 59
SELECT * FROM Estudo

-- NonClustered Index para percorrer por Nome
CREATE INDEX nomeIndex ON EntPatronal (Nome)