-- INSERIR UM NOVO ESTUDO

GO
CREATE PROC insertStudy 
(	
	@Titulo		VARCHAR(100) = NULL,
	@Num_Vagas	INT = NULL,
	@Renum		money = NULL,
	@CC			char(8) = NULL,
	-- PhaseStartDate, Estado
	@Cod_Inf	char(8) = NULL,
	@Cod_CEIC	char(8) = NULL,
	@Cod_Proc	char(8) = NULL,
	@Follow_up	Bit = NULL,
	@Num_Tomas	int = NULL,
	@Cod_Tipo	int = NULL,
	@Num_Sessoes int = NULL,
	@Status     INT = 1 OUTPUT,
	@Tipo_Est	int			-- 1-> Ensaio Clinico, 2-> Estudo de Investigação
)
AS
	DECLARE @Codigo AS INT
	SET @Codigo = (SELECT TOP 1 Codigo FROM Estudo ORDER BY Codigo DESC) + 1;

	IF @Titulo IS NULL 
	BEGIN
		SET @Status = -1
		PRINT 'ERRO: É necessário preencher o campo do Título!'
		SELECT @Status
		RETURN @Status
	END

	IF @Num_Vagas IS NULL 
	BEGIN
		SET @Status = -2
		PRINT 'ERRO: É necessário preencher o número de vagas!'
		SELECT @Status
		RETURN @Status
	END

	IF @Renum IS NULL 
	BEGIN
		SET @Status = -3
		PRINT 'ERRO: É necessário atribuir uma Remuneração!'
		SELECT @Status
		RETURN @Status
	END

	IF @CC NOT IN (SELECT CC FROM Investigador)
	BEGIN
		SET @Status = -4
		PRINT 'ERRO: O Investigador associado deve estar inserida na Base de Dados!'
		SELECT @Status
		RETURN @Status
	END	

	IF @Tipo_Est = 1
		BEGIN
			INSERT INTO Estudo VALUES (@Codigo, @Titulo, 1, 0, @Num_Vagas, @Renum, @CC, GETDATE());
			INSERT INTO Ensaio_Clinico VALUES (@Codigo, @Cod_Inf, @Cod_CEIC, @Cod_Proc, @Follow_up, @Num_Tomas, @Cod_Tipo);
		END
	ELSE
		BEGIN
			INSERT INTO Estudo VALUES (@Codigo, @Titulo, 1, 0, @Num_Vagas, @Renum, @CC, GETDATE());
			INSERT INTO Estudo_Investigacao VALUES (@Codigo, @Cod_Tipo, @Num_Sessoes);
		END
GO

-- EDIÇÃO DE UM ESTUDO

GO
CREATE PROC editStudy 
(	
	@Codigo		INT,
	@Titulo		VARCHAR(100) = NULL,
	@Num_Vagas	INT = NULL,
	@Renum		money = NULL,
	@CC			char(8) = NULL,
	-- PhaseStartDate, Estado
	@Cod_Inf	char(8) = NULL,
	@Cod_CEIC	char(8) = NULL,
	@Cod_Proc	char(8) = NULL,
	@Follow_up	Bit = NULL,
	@Num_Tomas	int = NULL,
	@Cod_Tipo	int = NULL,
	@Num_Sessoes int = NULL,
	@Status     INT = 1 OUTPUT,
	@Tipo_Est	int			-- 1-> Ensaio Clinico, 2-> Estudo de Investigação
)
AS
	IF @Titulo IS NULL 
	BEGIN
		SET @Status = -1
		PRINT 'ERRO: É necessário preencher o campo do Título!'
		SELECT @Status
		RETURN @Status
	END

	IF @Num_Vagas IS NULL 
	BEGIN
		SET @Status = -2
		PRINT 'ERRO: É necessário preencher o número de vagas!'
		SELECT @Status
		RETURN @Status
	END

	IF @Renum IS NULL 
	BEGIN
		SET @Status = -3
		PRINT 'ERRO: É necessário atribuir uma Remuneração!'
		SELECT @Status
		RETURN @Status
	END

	IF @CC NOT IN (SELECT CC FROM Investigador)
	BEGIN
		SET @Status = -4
		PRINT 'ERRO: O Investigador associado deve estar inserida na Base de Dados!'
		SELECT @Status
		RETURN @Status
	END	

	IF @Tipo_Est = 1
		BEGIN
			UPDATE Estudo SET Titulo = @Titulo, Num_Vagas = @Num_Vagas, Renum = @Renum, CC_Inv = @CC WHERE Codigo = @Codigo
			UPDATE Ensaio_Clinico SET Cod_Inf = @Cod_Inf, Cod_CEIC = @Cod_CEIC, Cod_Proc = @Cod_Proc, Cod_Tipo = @Cod_Tipo, Follow_Up = @Follow_up, Num_Tomas = @Num_Tomas WHERE Codigo = @Codigo
		END
	ELSE
		BEGIN
			UPDATE Estudo SET Titulo = @Titulo, Num_Vagas = @Num_Vagas, Renum = @Renum, CC_Inv = @CC WHERE Codigo = @Codigo
			UPDATE Estudo_Investigacao SET Num_Sessoes = @Num_Sessoes WHERE Cod_Est = @Codigo
		END

	SELECT @Status
	RETURN @Status
GO

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
            SELECT Participante.ID, CC, Email, IBAN, NIF, Genero, Localidade, Idade, Cod_Analises, AnnualStudies, AnnualPay
            FROM Participante LEFT OUTER JOIN 
                (SELECT *
                FROM Participante_ECAnual)
                AS AnnualInfo ON Participante.ID = AnnualInfo.ID
            WHERE (Idade BETWEEN @MinAge AND @MaxAge) AND Cod_Analises IS NOT NULL AND ((AnnualStudies < 2 AND AnnualPay < 500) OR (AnnualStudies IS NULL AND AnnualPay IS NULL))

        END
    ELSE
        BEGIN
            SELECT Participante.ID, CC, Email, IBAN, NIF, Genero, Localidade, Idade, Cod_Analises, AnnualStudies, AnnualPay
            FROM Participante LEFT OUTER JOIN 
                (SELECT *
                FROM Participante_ECAnual) 
                AS AnnualInfo ON Participante.ID = AnnualInfo.ID
            WHERE (Idade BETWEEN @MinAge AND @MaxAge) AND Cod_Analises IS NOT NULL AND ((AnnualStudies < 2 AND AnnualPay < 500) OR (AnnualStudies IS NULL AND AnnualPay IS NULL)) AND (Genero = @Gender)
        END    
GO

-- Recrutamento de um Participante para um Estudo
GO
CREATE PROC Add_ParticipantEI @ID_Part INT, @Cod_Est INT, @status INT OUTPUT
AS
	DECLARE @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part, @Vagas =  Num_Vagas FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = @Vagas
		BEGIN
			PRINT 'ERRO: O total de vagas para este estudo já foi preenchido!'
			SET @Status = -1
			SELECT @Status
			RETURN @Status
		END

	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 9);
	INSERT INTO Participa_EI VALUES (@ID_Part, @Cod_Est, @Consent);
	SELECT @Status
	RETURN @Status
GO

GO
CREATE PROC Add_ParticipantEC @ID_Part INT, @Cod_Est INT, @status INT OUTPUT
AS
	DECLARE @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part, @Vagas =  Num_Vagas FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = @Vagas
		BEGIN
			PRINT 'ERRO: O total de vagas para este estudo já foi preenchido!'
			SET @Status = -1
			SELECT @Status
			RETURN @Status
		END

	DECLARE @Consent AS CHAR(8);
	SET @Consent = SUBSTRING(CONVERT(VARCHAR(255), NEWID()), 0, 9);
	INSERT INTO Participa_EC VALUES (@ID_Part, @Cod_Est, @Consent);
	SELECT @Status
	RETURN  @Status
GO

-- MUDAR O ESTADO DE ESTUDO PARA ATIVO

GO
CREATE PROC finishRecruiting @Cod_Est INT, @status AS INT OUTPUT
AS
	DECLARE @NumPart AS INT, @Vagas AS INT
	SET @Status = 1

	SELECT @NumPart = Num_Part FROM Estudo WHERE Codigo = @Cod_Est

	IF @NumPart = 0
		BEGIN
			PRINT 'ERRO: O estudo ainda não tem participantes recrutados!'
			SET @Status = -1
			SELECT @status
			RETURN @Status
		END

	UPDATE Estudo SET Estado = 2, Phase_StartDate = GETDATE() WHERE Codigo = @Cod_Est
	SELECT @status
	RETURN @Status
GO

-- MUDAR O ESTADO DO ESTUDO PARA COMPLETADO
	-- Participantes devem ser pagos pelo estudo que completaram

GO
CREATE PROC completeStudy @Cod_Est INT
AS
	DECLARE @ID AS INT;
	DECLARE @pay AS MONEY;

	SELECT ID_Participante FROM Lista_Participantes WHERE Cod_Estudo = @Cod_Est;
	SELECT @pay = renum FROM Estudo WHERE Codigo = @Cod_Est;

	DECLARE C CURSOR
		FOR SELECT ID_Participante FROM Lista_Participantes WHERE Cod_Estudo = @Cod_Est;

		OPEN C;
		FETCH C INTO @ID;

		WHILE @@FETCH_STATUS = 0
			BEGIN
				UPDATE Participante SET Renum_Total = Renum_Total + @pay WHERE ID = @ID;
				FETCH C INTO @ID;
			END;

		CLOSE C;
		DEALLOCATE C;

	UPDATE Estudo SET Estado = 3, Phase_StartDate = GETDATE() WHERE Codigo = @Cod_Est
GO

-- Pesquisa de Estudos por Nome

GO
CREATE PROC searchEstudo @Nome AS VARCHAR(100) AS
	SELECT * FROM Estudo WHERE Titulo LIKE '%' + @Nome + '%'
GO

-- Indice
CREATE INDEX estudoTitulo ON Estudo (Titulo)