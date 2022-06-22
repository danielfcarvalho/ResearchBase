-- Inserir um novo participante na base de dados
GO
CREATE PROC addParticipante(
@CC				CHAR(8) = NULL,
@Email			VARCHAR(100) = NULL,
@IBAN			CHAR(25) = NULL,
@NIF			CHAR(9) = NULL,
@Data_nasc		DATE = NULL,
@Genero			CHAR(1) = NULL,
@Localidade		VARCHAR(100) = NULL,
@Cod_Analises	CHAR(8) = NULL,
@Status			INT OUTPUT
) AS

DECLARE @ID AS INT;
DECLARE @Join_Date AS DATE;
DECLARE @Idade AS INT;

SET @ID = (SELECT TOP 1 ID FROM Participante ORDER BY ID DESC) + 1;
SET @Join_Date = GETDATE();

IF @Email IS NULL OR @CC IS NULL
BEGIN
	SET @Status = -1
	PRINT 'ERRO: É necessário CC e Email'
	SELECT @Status
	RETURN @Status
END

INSERT INTO Participante VALUES (@ID, @CC, @Email, @IBAN, @NIF, @Data_nasc, @Genero, @Localidade, 0, null, @Cod_Analises, @Join_Date)
SELECT @Status
RETURN @Status
GO

-- Editar um participante na base de dados
GO
CREATE PROC editParticipante(
@CC				CHAR(8),
@Email			VARCHAR(100) = NULL,
@IBAN			CHAR(25) = NULL,
@NIF			CHAR(9) = NULL,
@Data_nasc		DATE = NULL,
@Genero			CHAR(1) = NULL,
@Localidade		VARCHAR(100) = NULL,
@Cod_Analises	CHAR(8) = NULL,
@Status			INT = 1 OUTPUT
) AS


IF @Email IS NULL
BEGIN
	SET @Status = -1
	PRINT 'ERRO: É necessário Email'
	SELECT @Status
	RETURN @Status
END

Update Participante SET Email = @Email, IBAN = @IBAN, NIF = @NIF, Data_nasc = @Data_nasc, Genero = @Genero, Localidade = @Localidade, Cod_Analises = @Cod_Analises WHERE CC = @CC
SELECT @Status
RETURN @Status
GO

-- Procurar Participante
GO
CREATE PROC searchParticipant @CC AS VARCHAR(8) AS
SELECT * FROM Participante WHERE CC LIKE '%' + @CC + '%'
GO

-- NonClustered Index para percorrer por CC
CREATE INDEX ccIndex ON Participante (CC)