-- SELEÇÃO DOS PARTICIPANTES QUE OBEDECEM AOS CRITÉRIOS DEFINIDOS POR UM INVESTIGADOR NO RECRUTAMENTO

GO
CREATE PROC Select_Valid_ParticipantsEI @MinAge INT = 18, @MaxAge INT = 120,  @Gender CHAR = 'B'
AS
	IF @Gender = 'B'
		BEGIN
			SELECT * FROM Participante WHERE Idade BETWEEN @MinAge AND @MaxAge;
		END
	ELSE
		BEGIN
			SELECT * FROM Participante WHERE (Idade BETWEEN @MinAge AND @MaxAge) AND Genero = @Gender;
		END	
GO

GO
CREATE PROC Select_Valid_ParticipantsEC @MinAge INT = 18, @MaxAge INT = 120, @Gender CHAR = 'B'
AS
	IF @Gender = 'B'
		BEGIN
			SELECT Participante_EC.ID, CC, Email, IBAN, NIF, Genero, Localidade, Idade, Cod_Analises, AnnualStudies, AnnualPay
			FROM Participante_EC JOIN 
				(SELECT ID, COUNT(ID) AS AnnualStudies, SUM(Renum) AS AnnualPay
				FROM Participante_EC WHERE (Idade BETWEEN @MinAge AND @MaxAge) AND Cod_Analises IS NOT NULL
				GROUP BY ID
				HAVING COUNT(ID) < 2 AND SUM(Renum) < 500) AS AnnualInfo ON Participante_EC.ID = AnnualInfo.ID

		END
	ELSE
		BEGIN
			SELECT Participante_EC.ID, CC, Email, IBAN, NIF, Genero, Localidade, Idade, Cod_Analises, AnnualStudies, AnnualPay
			FROM Participante_EC JOIN 
				(SELECT ID, COUNT(ID) AS AnnualStudies, SUM(Renum) AS AnnualPay
				FROM Participante_EC WHERE (Idade BETWEEN @MinAge AND @MaxAge) AND (Cod_Analises IS NOT NULL) AND (Genero = @Gender)
				GROUP BY ID
				HAVING COUNT(ID) < 2 AND SUM(Renum) < 500) AS AnnualInfo ON Participante_EC.ID = AnnualInfo.ID
		END	
GO

-- Recrutamento de um Participante para um Estudo
GO
CREATE PROC Add_ParticipantEI @ID_Part INT, @Cod_Est INT
AS
	DECLARE @Status AS INT, @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part, @Vagas =  Num_Vagas FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = @Vagas
		BEGIN
			PRINT 'ERRO: O total de vagas para este estudo já foi preenchido!'
			SET @Status = -1
			RETURN @Status
		END

	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 9);
	INSERT INTO Participa_EI VALUES (@ID_Part, @Cod_Est, @Consent);
	UPDATE Estudo SET Num_Part += 1 WHERE Codigo = @Cod_Est
GO

GO
CREATE PROC Add_ParticipantEC @ID_Part INT, @Cod_Est INT
AS
	DECLARE @Status AS INT, @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part, @Vagas =  Num_Vagas FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = @Vagas
		BEGIN
			PRINT 'ERRO: O total de vagas para este estudo já foi preenchido!'
			SET @Status = -1
			RETURN @Status
		END

	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 9);
	INSERT INTO Participa_EC VALUES (@ID_Part, @Cod_Est, @Consent);
GO

-- MUDAR O ESTADO DE ESTUDO PARA ATIVO

GO
CREATE PROC changeStudyState @Cod_Est INT
AS
	DECLARE @Status AS INT, @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = 0
		BEGIN
			PRINT 'ERRO: O estudo ainda não tem participantes recrutados!'
			SET @Status = -1
			RETURN @Status
		END

	UPDATE Estudo SET Estado = 2 WHERE Codigo = @Cod_Est
GO