CREATE PROC addInvestigador(
@CC						CHAR(8) = NULL,
@Nome					VARCHAR(100) = NULL,
@Email					VARCHAR(100) = NULL,
@EntPatronal			INT = NULL,
@Status                 INT = 1 OUTPUT
) AS
	DECLARE @Join_Date AS DATE;

	SET @Join_Date = GETDATE();

	IF @Email IS NULL OR @CC IS NULL OR @Nome IS NULL
	BEGIN
		SET @Status = -1
		PRINT 'ERRO: É necessário preencher os campos de CC, Nome e E-Mail!'
		SELECT @Status
		RETURN @Status
	END

	IF @EntPatronal NOT IN (SELECT Num_Registo FROM EntPatronal)
	BEGIN
		SET @Status = -2
		PRINT 'ERRO: A Entidade Patronal deve estar inserida na Base de Dados!'
		SELECT @Status
		RETURN @Status
	END

	INSERT INTO Investigador VALUES (@CC, @Nome, @Email, 0, @EntPatronal, @Join_Date)
	SELECT @Status
	RETURN @Status
GO

CREATE PROC editInvestigador(
@Nome					VARCHAR(100) = NULL,
@Email					VARCHAR(100) = NULL,
@EntPatronal			INT = NULL,
@CC						VARCHAR(8),
@Status					INT = 1 OUTPUT
) AS
	IF @Email IS NULL OR @Nome IS NULL
	BEGIN
		SET @Status = -1
		PRINT 'ERRO: É necessário preencher os campos de CC, Nome e E-Mail!'
		SELECT @Status
		RETURN @Status
	END

	IF @EntPatronal NOT IN (SELECT Num_Registo FROM EntPatronal)
	BEGIN
		SET @Status = -2
		PRINT 'ERRO: A Entidade Patronal deve estar inserida na Base de Dados!'
		SELECT @Status
		RETURN @Status
	END

	UPDATE Investigador SET Nome = @Nome, Email = @Email, EntPatronal = @EntPatronal WHERE CC = @CC
	SELECT @Status
	RETURN @Status
GO

GO
CREATE PROC searchInvestigador @Nome AS VARCHAR(100) AS
	SELECT * FROM Investigador WHERE Nome LIKE '%' + @Nome + '%'
GO

CREATE INDEX nameIndex ON Investigador (Nome)